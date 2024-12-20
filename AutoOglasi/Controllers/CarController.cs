﻿using AutoOglasi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoOglasi.Controllers
{   
    //provera da su korisnici autentifikovani tj ulogovani pre pristupa
    [Authorize]
    public class CarController : Controller
    {
        private readonly IMongoCollection<Car> _car;//kolekcija Cars iz baze
        private readonly UserManager<ApplicationUser> _userManager;

        public CarController(IMongoDatabase database, UserManager<ApplicationUser> userManager)
        {
            _car = database.GetCollection<Car>("Cars");//inicijalizacija kolekcije
            _userManager = userManager;
        }

        //pregledaj sve oglase
        public async Task<IActionResult> Index(string brand,string year)
        {
            //filtriraj po godini proizvodnje
            var filterBuilder = Builders<Car>.Filter;
            var filter = filterBuilder.Empty;

            if (!string.IsNullOrEmpty(brand))
            {
                filter = filterBuilder.And(filter, filterBuilder.Eq(c => c.Brand, brand));

            }
            if (!string.IsNullOrEmpty(year))
            {
                if (int.TryParse(year, out int yearValue))
                {
                    filter = filterBuilder.And(filter, filterBuilder.Eq(c => c.Year, yearValue));
                }
                else
                {
                    Console.WriteLine("Greska");
                }
            }



            var oglasi = await _car.Find(filter).ToListAsync();
            return View(oglasi);
        }

        //samo oglasi ulogovanog korisnika
        public async Task<IActionResult> MojiOglasi()
        {
            var userId = _userManager.GetUserId(User);// Identifikacija trenutnog korisnika
            var oglasi = await _car.Find(oglas => oglas.UserId == userId).ToListAsync();//pronalazenje oglasa trenutnog korisnika
            return View(oglasi);
        }

        //Postavi oglas GET
        public IActionResult Create()
        {
            return View();
        }

        // Postavi oglas POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car, List<IFormFile> images)
        {
            if (ModelState.IsValid)
            {
                car.UserId = _userManager.GetUserId(User);
                car.CreatedAt = DateTime.UtcNow;

                // Obrada dodavanja slika, prebacuje se slika u bytearray da bi mogla da se cuva u bazi
                foreach (var image in images)
                {
                    using (var ms = new MemoryStream())
                    {
                        await image.CopyToAsync(ms);
                        var imageData = ms.ToArray();
                        car.Images.Add(new BsonBinaryData(imageData));
                    }
                }

                await _car.InsertOneAsync(car);

                return RedirectToAction(nameof(MojiOglasi));
            }

            // ukolioko ima gresaka u modelu, debug deo
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                if (state.Errors.Any())
                {
                    foreach (var error in state.Errors)
                    {
                        Console.WriteLine($"Validation error for '{key}': {error.ErrorMessage}");
                    }
                }
            }

            Console.WriteLine("Invalid model state.");
            return View(car);
        }


        //izmeni oglas GET
        public async Task<IActionResult> Edit(string id)
        {
            var oglas = await _car.Find(a => a.Id == id && a.UserId == _userManager.GetUserId(User)).FirstOrDefaultAsync();
            if (oglas == null)
            {
                return NotFound();
            }
            return View(oglas);
        }

        //izmeni oglas POST
        // izmeni oglas POST
        [HttpPost]
        public async Task<IActionResult> Edit(string id, Car car, List<IFormFile> images)
        {
            if (ModelState.IsValid)
            {
                var existingCar = await _car.Find(a => a.Id == id && a.UserId == _userManager.GetUserId(User)).FirstOrDefaultAsync();
                if (existingCar == null)
                {
                    return NotFound();
                }

                existingCar.Brand = car.Brand;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;
                existingCar.Description = car.Description;

                // dodaj novu sliku
                foreach (var image in images)
                {
                    using (var ms = new MemoryStream())
                    {
                        await image.CopyToAsync(ms);
                        var imageData = ms.ToArray();
                        existingCar.Images.Add(new BsonBinaryData(imageData));
                    }
                }

                var updateResult = await _car.ReplaceOneAsync(a => a.Id == id && a.UserId == _userManager.GetUserId(User), existingCar);
                if (updateResult.IsAcknowledged)
                {
                    return RedirectToAction(nameof(MojiOglasi));
                }
            }
            return View(car);
        }

        // obrisi oglas GET
        public async Task<IActionResult> Delete(string id)
        {
            var oglas = await _car.Find(a => a.Id == id && a.UserId == _userManager.GetUserId(User)).FirstOrDefaultAsync();
            if (oglas == null)
            {
                return NotFound();
            }
            return View(oglas);
        }

        // obrisi oglas POST
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var oglas = await _car.Find(a => a.Id == id && a.UserId == _userManager.GetUserId(User)).FirstOrDefaultAsync();
            if (oglas == null)
            {
                return NotFound();
            }

            var deleteResult = await _car.DeleteOneAsync(a => a.Id == id);
            if (deleteResult.IsAcknowledged)
            {
                return RedirectToAction(nameof(MojiOglasi));
            }
            return View(oglas);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Detaljno(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var auto = await _car.Find(c => c.Id == id).FirstOrDefaultAsync();
            if (auto == null)
            {
                return NotFound();
            }

            // provera da li je korisnik povezan sa autom po userId DA BI prikazali userName
            var carUser = await _userManager.FindByIdAsync(auto.UserId);
            if (carUser != null)
            {
                auto.User = carUser;
            }

            // provera da li je korisnik povezan sa komentarom po userId DA BI prikazali userName
            foreach (var comment in auto.Comments)
            {
                var user = await _userManager.FindByIdAsync(comment.UserId);
                if (user != null)
                {
                    comment.User = user;
                }
            }
            return View(auto);
        }

        //komentari
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddComment(string id, string text)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(text))
            {
                return BadRequest();
            }

            var car = await _car.Find(c => c.Id == id).FirstOrDefaultAsync();
            if (car == null)
            {
                return NotFound();
            }

            // Postavi komentar
            var comment = new Comment
            {
                UserId = _userManager.GetUserId(User),
                Text = text,
                CreatedAt = DateTime.UtcNow
            };

            car.Comments.Add(comment); // Komentar za auto
            var updateResult = await _car.ReplaceOneAsync(c => c.Id == id, car); // Apdejt auta u bazi

            if (updateResult.IsAcknowledged)
            {
                return RedirectToAction(nameof(Detaljno), new { id }); // Redirekcija na detaljno
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}

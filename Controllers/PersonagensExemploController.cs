using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExemploController : ControllerBase
    {
        private static List<Personagem> Personagems
        = new List<Personagem>()
        {
            new Personagem(){Id=1, Nome="frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe
            = Models.Enuns.ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=Models.Enuns.ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=Models.Enuns.ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=Models.Enuns.ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=Models.Enuns.ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=Models.Enuns.ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=Models.Enuns.ClasseEnum.Mago }
        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Personagem P = Personagems[0];
            return Ok(P); 
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(Personagems);
        }

        [HttpGet("{id}")]

        public IActionResult GetSingle(int id)
        {
            return Ok (Personagems.FirstOrDefault(pe => pe.Id == id));
        }

    }
}
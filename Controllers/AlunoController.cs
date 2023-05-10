using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gestor_escola.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> Alunos()
        {
            return new List<Aluno>{
                new Aluno{ Name= "Chris", Id_card = "007001390LA092" }
            };
        }
    }
}
﻿using System.ComponentModel.DataAnnotations;

namespace Universidade.Server.Models
{
  public class Matricula
  {
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    public int DisciplinaId { get; set; }
    public Disciplina Disciplina { get; set; }
  }
}

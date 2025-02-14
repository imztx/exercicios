
using SistemaUniversitario;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Robson";
pessoa.Salario = 4500;
pessoa.Endereco = "Rua 123";
pessoa.Idade = 30;
pessoa.ExibirInformacoes();

Console.WriteLine("-------------------------------");

Aluno aluno = new Aluno();
aluno.Nome = "Luiz";
aluno.Salario = 0;
aluno.Endereco = "Rua 764";
aluno.Idade = 20;
aluno.Curso = "Ciência da Computação";
aluno.Matricula = "578932";

aluno.ExibirInformacoes();

Console.WriteLine("-------------------------------");

Professor professor = new Professor();
professor.Nome = "Botega";
professor.Idade = 43;
professor.Salario = 10000;
professor.Disciplina = "PO";
professor.ExibirInformacoes();

Console.WriteLine("-------------------------------");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Marcos";
funcionario.Idade = 53;
funcionario.Salario = 3000;
funcionario.Endereco = "Rua abc";
funcionario.Cargo = "Segurança";
funcionario.Departamento = "Unimar";

funcionario.ExibirInformacoes();
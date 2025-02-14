using Banco;

Conta conta1 = new Conta();
Conta conta2 = new Conta();

conta1.Saldo = 1000;
conta1.Numero = 1234;
conta1.Nome = "Asdrubal";

conta2.Saldo = 500;
conta2.Numero = 9876;
conta2.Nome = "Jao";

ContaPoupanca contaPoupanca = new ContaPoupanca();  
contaPoupanca.Saldo = 1500;
contaPoupanca.Saca(50);
Console.WriteLine(contaPoupanca.Saldo);

TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();
totalizadorDeContas.Soma(conta1);
totalizadorDeContas.Soma(conta2);
totalizadorDeContas.Soma(contaPoupanca);

//Console.WriteLine(totalizadorDeContas.ValorTotal);

//ContaPoupanca contaPoupanca = new ContaPoupanca();
//contaPoupanca.Numero = 4455;
//contaPoupanca.Saldo = 1000;
//contaPoupanca.Nome = "Ze";

//ContaInvestimento contaInvestimento = new ContaInvestimento();


//var taxaPoupanca = contaPoupanca.CalcularValorTarifaManutencao();
//var taxaInvestimento = contaInvestimento.CalcularValorTarifaManutencao();
//var taxaConta = conta1.CalcularValorTarifaManutencao();

////Efetuar Saque na Conta1
//if (conta1.Saca(200))
//{
//    Console.WriteLine("Saque efetuado com sucesso");
//    Console.WriteLine("Saldo atual: " +  conta1.Saldo);
//}
//else
//{
//    Console.WriteLine("Problemas ao sacar, entre em contato com o seu Manager");
//}



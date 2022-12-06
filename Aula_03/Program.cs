using Aula_02.models;


ContaCorrente cc = new ContaCorrente(50);
cc.Numero = 1254;
cc.ExibirSaldo();

cc.Sacar(100);

cc.ExibirSaldo();
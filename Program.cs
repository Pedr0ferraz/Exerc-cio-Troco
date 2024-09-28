decimal Compra, Pago, Troco;

Console.WriteLine("---Troco---");

Console.WriteLine();

Console.Write("valor da Compra R$: ");
Compra = Convert.ToDecimal(Console.ReadLine());

Console.Write("valor Pago R$: ");
Pago = Convert.ToDecimal(Console.ReadLine());

Troco = Pago - Compra;

Console.WriteLine($"{Troco}");
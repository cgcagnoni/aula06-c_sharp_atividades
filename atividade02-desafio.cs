float quilometrosPercorridosPeloVeiculo;
float milhasConvertidas;
float milha = 0.62137119f;

Console.WriteLine("Digite quantos quilômetros foram percorridos: ");
quilometrosPercorridosPeloVeiculo = float.Parse(Console.ReadLine());

milhasConvertidas = quilometrosPercorridosPeloVeiculo*milha;

Console.WriteLine("Seu veículo percorreu um total de  " + milhasConvertidas + " milhas.");

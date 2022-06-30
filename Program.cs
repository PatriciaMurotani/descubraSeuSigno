
// Projeto em C#: descubra seu signo 

//=============================================================================================================================================    
//                            DECLARAÇÃO DE VARIÁVEIS
//=============================================================================================================================================     
int dia, mes;

//Define as configurações de layout do Conversor
Console.Title = "DESCUBRA SEU SIGNO";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

//============================================================================================================================================= 

Console.WriteLine("\n--------------------------------------------------------------------");
Console.WriteLine("------------------------ DESCUBRA SEU SIGNO ------------------------");
Console.WriteLine("--------------------------------------------------------------------");

Console.Write("\n\n Digite o dia do seu nascimento: ");
dia = int.Parse(Console.ReadLine());

Console.Write("\n Digite o mês de seu nascimento: ");
mes = int.Parse(Console.ReadLine());

if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
    Console.WriteLine("\n Você é do signo de Áries, algumas características do seu signo são: Pioneirismo, Coragem e Autonomia");

if ((dia >= 21 && mes == 4) || (dia <= 21 && mes == 5))
    Console.WriteLine("\n Você é do signo de Touro, algumas características do seu signo são: Estabilidade, Praticidade e Paciência");

if ((dia >= 22 && mes == 5) || (dia <= 21 && mes == 6))
    Console.WriteLine("\n Você é do signo de Gêmeos, algumas características do seu signo são: Curiosidade, Inteligência e Adaptabilidade");

if ((dia >= 21 && mes == 6) || (dia <= 23 && mes == 7))
    Console.WriteLine("\n Você é do signo de Câncer, algumas características do seu signo são: Sensibilidade, Nostalgia e Proteção");

if ((dia >= 24 && mes == 7) || (dia <= 23 && mes == 8))
    Console.WriteLine("\n Você é do signo de Leão, algumas características do seu signo são: Criatividade, Generosidade e Otimismo");

if ((dia >= 24 && mes == 8) || (dia <= 23 && mes == 9))
    Console.WriteLine("\n Você é do signo de Virgem, algumas características do seu signo são: Organização, Exigência e Análise");

if ((dia >= 24 && mes == 9) || (dia <= 23 && mes == 10))
    Console.WriteLine("\n Você é do signo de Libra, algumas características do seu signo são: Sociabilidade, Diplomacia e Cooperação");

if ((dia >= 24 && mes == 10) || (dia <= 22 && mes == 11))
    Console.WriteLine("\n Você é do signo de Escorpião, algumas características do seu signo são: Magnetismo, Investigação e Intensidade");

if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
    Console.WriteLine("\n Você é do signo de Sagitário, algumas características do seu signo são: Filosofia, Entusiasmo e Liberdade");

if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
    Console.WriteLine("\n Você é do signo de Capricórnio, algumas características do seu signo são: Cautela, Responsabilidade e Razão");

if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
    Console.WriteLine("\n Você é do signo de Aquário, algumas características do seu signo são: Inovação, Independência e Revolução");

if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
    Console.WriteLine("\n Você é do signo de Peixes, algumas características do seu signo são: Compaixão, Imaginação e Intuição");

Console.WriteLine("\n Fonte: Astrolink");
Console.Write("\n\n Pressione qualquer tecla para terminar . . . ");
Console.ReadKey();
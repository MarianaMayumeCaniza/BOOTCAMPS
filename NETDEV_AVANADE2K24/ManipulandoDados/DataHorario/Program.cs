using System.Globalization;

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());


DateTime datacompleta = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine(datacompleta);

string dataString = "2022-04-17 18:00";

DateTime data2 = DateTime.Parse(dataString);
Console.WriteLine(data2);


DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);
Console.WriteLine(data3);


bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data4);

if (sucesso){
    Console.WriteLine($"Conversão com sucesso! Data: {data4}");
}else{
    Console.WriteLine($"{dataString} não é uma data válida");
}

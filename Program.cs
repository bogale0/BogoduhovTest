using InspectorLib;
Random rand = new Random();
//создаём объект
FunctionInsp mainInspection = new FunctionInsp(
    "Автоинспекция г. Чита",
    "Васильев Василий Иванович",
    new List<string> {
        "Иванов И.И.",
        "Зиронов Т.А.",
        "Миронов А.В.",
        "Васильев В.И."
    }
);
Console.WriteLine($"Название инспекции: {mainInspection.GetСarInspection()}");
Console.WriteLine($"Главный инспектор: {mainInspection.GetInspector()}");

Console.WriteLine("Список работников:");
List<string> workers = mainInspection.GetWorker();
foreach (string worker in workers)
    Console.WriteLine(worker);

Console.Write("Введите имя нового работника: ");
mainInspection.AddWorker(Console.ReadLine());
for (; ; ) {
    Console.Write("Введите имя нового инспектора: ");
    if (mainInspection.SetInspector(Console.ReadLine()))
        break; //завершение цикла если новый инспекто успешно задан
    Console.WriteLine("Нет работника с таким именем!");
}
Console.WriteLine($"Новый инспектор: {mainInspection.GetInspector()}");
int number = rand.Next();
Console.WriteLine($"Госномер: {mainInspection.GenerateNumber(
    number % 1000, //случайное число от 0 до 999
    (char)('a' + number / 1000 % 26))}" //случайная буква от 'a' до 'z'
);

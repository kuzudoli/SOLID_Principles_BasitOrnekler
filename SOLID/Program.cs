using SOLID;
#region Single Responsibility Principle
/*
var readRepo = new ReadTextRepository();
readRepo.ReadText();

var writeRepo = new WriteTextRepository();
writeRepo.WriteText();
*/
#endregion

#region Open-Closed Principle
/*
var fileLogger = new FileLogger();
fileLogger.Log();

var dbLogger = new DbLogger();
dbLogger.Log();
*/
#endregion

#region Liskov‘s Substitution Principle
/*
var senior = new SeniorDeveloper();
senior.SolidKullan();
senior.KodYaz();

var junior = new JuniorDeveloper();
junior.KodYaz();
*/
#endregion

#region Interface Segregation Principle
/*
var bmw = new BMW();
bmw.Calistir();
bmw.KlimaAc();
bmw.Durdur();

var tofas = new Tofas();
tofas.Calistir();
tofas.Durdur();
*/
#endregion

#region Dependency Inversion Principle
var person = new Person(new Knife());//İnsan sınıfına bıçak aleti verildi
person.CutPizza();

var person2 = new Person(new Cutter());//İnsan sınıfına dilimleyici aleti verildi
person2.CutPizza();
#endregion
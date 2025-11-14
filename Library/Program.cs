using Library;

var b1 = new Book("Гарри Поттер", "Дж.К. Роулинг", 3);
var b2 = new Book("Преступление и наказание", "Ф. Достоевский", 2);

var r1 = new Reader("Еремечев Артем");
var r2 = new Reader("Анисимов Сергей");

b1.Borrow();
r1.TakeBook(b1.Id);

Console.WriteLine($"После выдачи: {b1}");

b1.Return();
r1.ReturnBook(b1.Id);

Console.WriteLine($"После возврата: {b1}");

Console.WriteLine(r1);
Console.WriteLine(r2);

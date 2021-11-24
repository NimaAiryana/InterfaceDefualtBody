using InterfaceDefualtBody;

Console.WriteLine("Hello, World!");

IInterface face = new NoImplement();
Console.WriteLine(face.Method());

Implement body = new Implement();
Console.WriteLine(body.Method());

IInterface faceUp = new Implement();
Console.WriteLine(faceUp.Method());

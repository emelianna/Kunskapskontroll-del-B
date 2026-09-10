Student erik = new("Erik Svensson");
Student frida = new("Frida Fågelgren");
Student alfons = new("Alfons Åberg");
Student silvia = new("Silvia");

Course hemkunskap = new("Hemkunskap", 2);
Course kemi = new("Kemi", 4);
Course matte = new("Matematik", 2);
Course virkning = new("Virkning", 5);

alfons.Join(virkning);
frida.Join(virkning);
frida.Join(virkning);
alfons.Join(kemi);
alfons.Join(matte);
silvia.Join(matte);
frida.Join(matte);

alfons.Leave(hemkunskap);
frida.Leave(virkning);
virkning.Remove(alfons);

alfons.Schedule();
erik.Schedule();

virkning.RollCall();
hemkunskap.RollCall();
matte.RollCall();
kemi.RollCall();


Console.WriteLine(virkning);
Console.WriteLine(hemkunskap);
Console.WriteLine(matte);
Console.WriteLine(kemi);
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nk1 = new Nokia("123456789", "75984", "nk1", 16);

Nokia nk2 = new Nokia("123456789", "75983", "nk2", 32);

Iphone iphone14 = new Iphone("987654321", "713524", "iphone15", 64);

Iphone iphone15 = new Iphone("987654321", "713529", "iphone15", 128);

nk1.InstalarAplicativo("facebook");
nk2.InstalarAplicativo("whatsapp");

iphone14.InstalarAplicativo("Instagram");
iphone15.InstalarAplicativo("X");
using OopEncapsulation;

SunFlower flower = new();
//flower.Protected();//là con nên dc dùng
flower.Internal();//trong cùng project / assembly
//flower.PrivateProtected();//hoặc private hoặc là protected thì dc dùng
flower.ProtectedInternal();
flower.Public();
//flower .Private ==> error vì chỉ đứng tại class đó ms dc dùng
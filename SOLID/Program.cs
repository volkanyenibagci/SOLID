
using SOLID.InterfaceSegregationPrinciple.WithISP;
using SOLID.InterfaceSegregationPrinciple.WithoutISP;
using SOLID.LiskovSubstutionPrinciple.WithLSP;
using SOLID.LiskovSubstutionPrinciple.WithoutLSP;
using SOLID.OpenClosedPrinciple.WithOCP;
using SOLID.OpenClosedPrinciple.WithoutOCP;
using SOLID.Single_Responsibility_Principle;
using System;

//Single responsibility prensibi sınıflarımızın iyi tanımlanmış tek bir sorumluluğu olması gerektiğini anlatmaktadır.
#region Single Responsibility Principle

#region WithoutSRP

//UserWithoutSRP
//İlerleyen süreçte adreste ZIP alanı gerektiğini düşünelim. Bu durum User sınıfını etkileyecektir. User sınıfı direkt olarak sorumlu olmadığı bir işlemden etkilenmiş olacak."street", "city" gibi alanlar sadece adres için gereklidir, bu durumda "Address" adında yeni bir class oluşturmak daha doğru. 
UserWithoutSRP uSerWithoutSRP = new UserWithoutSRP(1, "Name", "Street1", "City1", "Username");

#endregion WithoutSRP

#region WithSRP

//UserWithSRP
Address address = new Address("Street", "City", "zip");
UserWithSRP userWithSRP = new UserWithSRP(1, "Name", "Username", address);

#endregion

#endregion Single Responsibility Principle

//Bir sınıf ya da fonksiyon var olan özellikleri korumalı yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabilmelidir.
//Yani bir sınıf veya fonksiyon gelişime açık değişime kapalı olmalıdır.
#region Open Closed Principle

#region WithoutOCP

AnimalSoundWithoutOCP animalSoundWithoutOCP = new AnimalSoundWithoutOCP();
animalSoundWithoutOCP.MakeDogSound();
//eğer yeni bir hayvan sesi istersem mesela inek AnimalSoundWithoutOCP class ını değiştirmem gerekir. Değişime kapalı olması gerekir
animalSoundWithoutOCP.MakeCowSound();

#endregion WithoutOCP

#region WithOCP

AnimalSoundWithOCP animalSoundWithOCP =new AnimalSoundWithOCP();
Cat cat=new Cat();
animalSoundWithOCP.MakeAnimalSoundWithOCP(cat);
//Ocp prensibi ile geliştirildiğinde ise mevcut kodu değiştirmeden geliştirebiliriz.
Cow cow = new Cow();
animalSoundWithOCP.MakeAnimalSoundWithOCP(cow);

#endregion WithOCP


#endregion Open Closed Principle

//bir sınıfın nesnelerinin, o sınıfın bir alt sınıfının nesneleriyle değiştirilebilir olması gerektiğini belirtir. Başka bir deyişle, bir üst sınıfın herhangi bir yöntemi, alt sınıflar tarafından değiştirilemez veya bozulamaz.
#region Liskov Substitution Principle

#region Without LSP
//Orange nesnesi miras aldığı apple nesnesini override ederek değiştiriyor. Karmaşanın engellenmesi için miras alınan nesneyi değiştirmemesi gerekir.
OrangeWithoutLSP orange = new OrangeWithoutLSP();
Console.WriteLine(orange.GetColor());

#endregion Without LSP

#region With LSP
//Orange ve apple sınıfları IFruit interface ini miras aldı. üst nesnenin işlevini değiştirmemiş olduk böylece.
IFruitWithLSP fruit = new OrangeWithLSP();
Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
fruit = new AppleWithLSP();
Console.WriteLine($"Color of Apple: {fruit.GetColor()}");

#endregion With LSP

#endregion Liskov Substitution Principle

//Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmayı tercih etmemizi söyleyen prensiptir.
#region Interface Segregation Principle

#region Without ISP
//Bu örnekte kullanılmayan bir method implement edilmiş oldu. Böyle bir yapı okunabilirliği azaltır. Gerek duyulmayan metotları implement etmek zorunda kaldık ve bakımı zor bir hal almış oldu.
BirdWithoutISP bird = new BirdWithoutISP();
bird.bark();

#endregion Without ISP

#region With ISP
//Bu şekilde havlama sınıfını kuşa implement etmemiş olduk. Gereksiz implementden kaçınmış olduk.
BirdWithISP birdWithISP = new BirdWithISP();
birdWithISP.fly();

#endregion With ISP

#endregion Interface Segregation Principle




using SOLID.OpenClosedPrinciple.WithOCP;
using SOLID.OpenClosedPrinciple.WithoutOCP;
using SOLID.Single_Responsibility_Principle;

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



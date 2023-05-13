using SOLID.Single_Responsibility_Principle;



//UserWithoutSRP
//İlerleyen süreçte adreste ZIP alanı gerektiğini düşünelim. Bu durum User sınıfını etkileyecektir. User sınıfı direkt olarak sorumlu olmadığı bir işlemden etkilenmiş olacak."street", "city" gibi alanlar sadece adres için gereklidir, bu durumda "Address" adında yeni bir class oluşturmak daha doğru. 
UserWithoutSRP uSerWithoutSRP = new UserWithoutSRP(1, "Name", "Street1", "City1", "Username");

//UserWithSRP
Address address = new Address("Street", "City", "zip");
UserWithSRP userWithSRP = new UserWithSRP(1, "Name","Username", address);





using System.Linq;

List<Users> users = new List<Users>(){
    new Users (){Id=1, FirstName="Ali", LastName="Can", Email="ali.can@hotmail.com", Job="Avukat" },
    new Users (){Id=2, FirstName="Emin", LastName="Asaf", Email="emin.asag@hotmail.com", Job="Ogrenci" },
    new Users (){Id=3, FirstName="Sevval", LastName="Sen", Email="sevval@hotmail.com", Job="Avukat" },
    new Users (){Id=4, FirstName="Aziz", LastName="Melih", Email="aziz.melih@hotmail.com", Job="Ogrenci" },
    new Users (){Id=5, FirstName="Hayrettin", LastName="Utku", Email="utkuyazici@hotmail.com", Job="Basketbolcu" },
    new Users (){Id=6, FirstName="Ikbal", LastName="Can", Email="ikbal@hotmail.com", Job="Mimar" },
    new Users (){Id=7, FirstName="Serkan", LastName="Bayrak", Email="serkan@gmail.com", Job="Fotografci" },
    new Users (){Id=8, FirstName="Selin", LastName="Ak", Email="selin@hotmail.com", Job="Ogretmen" },
    new Users (){Id=9, FirstName="Meva", LastName="Veli", Email="meva@hotmail.com", Job="Doktor" },
    new Users (){Id=10, FirstName="Sare", LastName="", Email="sara@hotmail.com", Job="Ic Mimar" },
};

/*
First ve FirstorDefault arasindaki fark:
first verilen sarta uygun ilk objeyi donuyor eger yoksa hata firlatiyor. 
FirstorDefault ise ilk objeyi donuyor eger yoksa objenin default degeri olan null'i donuyor.
*/
// var firstOrDefault = users.FirstOrDefault(u => u.Id == 11);
// System.Console.WriteLine($"user1 : {firstOrDefault}");

// var first = users.First(u => u.Id == 13);
// System.Console.WriteLine($"user2 : {first.FirstName}");


// Take ilk 3 elemani lsteliyor. takelast sondan 3 elemani listeliyor.
var takes = users.Where(u => u.Id > 3).Take(3).ToList();
// var takes = users.TakeLast(3).ToList();


takes.ForEach((take) =>
{
    System.Console.WriteLine($"{take.Id} - {take.FirstName} {take.LastName} - {take.Email} - {take.Job}");
});

System.Console.WriteLine($"---------------------------------------");

var usersOrderBy = users.OrderBy(u => u.Id).Skip(2).ToList();

usersOrderBy.ForEach((userOrderBy) =>
{
    System.Console.WriteLine(userOrderBy.Id);
});

List<Users> secondUsersList = new List<Users>(){
   new Users (){Id=10, FirstName="Sare", LastName="", Email="sara@hotmail.com", Job="Ic Mimar" },
    new Users (){Id=11, FirstName="Sabri", LastName="", Email="sabri@hotmail.com", Job="Ic Mimar" },
};

System.Console.WriteLine($"---------------------------------------");

var newUsers = secondUsersList.Where(u => (!users.Any(s => s.Id == u.Id))).ToList();
var existUsers = secondUsersList.Where(u => (users.Any(s => s.Id == u.Id))).ToList();
var deleteUsers = users.Where(s => (!secondUsersList.Any(u => u.Id == s.Id))).ToList();

System.Console.WriteLine($"New Users");
newUsers.ForEach((newUser) =>
{
    System.Console.WriteLine($"{newUser.Id}");
});
System.Console.WriteLine($"------------------------------------");

System.Console.WriteLine($"Exist Users");
existUsers.ForEach((existUser) =>
{
    System.Console.WriteLine($"{existUser.Id}");
});
System.Console.WriteLine($"------------------------------------");

System.Console.WriteLine($"Deleted Users");
deleteUsers.ForEach((deleteUser) =>
{
    System.Console.WriteLine($"{deleteUser.Id}");
});
System.Console.WriteLine($"------------------------------------");

/*
Max, dizideki en büyük elemanın değerini döndürür. Min ile aynı kullanımı sahiptir.
Sum, dizideki tüm elemanların toplamını döndürür.
Count, dizideki eleman sayısını verir. Toplam eleman sayısını verebileceği gibi, belirli kriterlerin uygulandığı eleman sayısının toplamını da verebilir.
FirstOrDefault, kritere uyan ilk elemanı döndürür. Herhangi bir kriter belirlenmezse dizideki ilk elemanı döndürür.
Any, dizide kritere uygun eleman olup olmadığını bool cinsinden döndürür, kriter girilmezse dizide eleman olup olmadığını kontrol eder.
Skip, girilen parametre kadar (int) dizinin başından o kadar elemanı atlar.
Take, girilen parametre kadar (int) diziden o kadar elemanı seçer.
OrderBy, dizideki elemanları girilen kritere göre A’dan Z’ye sıralar
OrderByDescending, dizideki elemanları girilen kritere göre Z’den A’ya sıralar.
Distinct, dizideki elemanları seçer ancak aynı değere sahip elemanları tek alır, dizide 5 adet elemanın değeri 2 ise, 1 adet 2 döner.
Select, her bir dizi elemanı içinden sadece belirli tipleri seçmeyi sağlar, “new” anahtar kelimesi altında çoklu alan seçilirse dönen değer anonimdir ve “var” olarak tanımlanmalıdır.
ToDictionary, çift parametreli olarak diziyi Dictionary tipine aktarır.
ToArray, IEnumerable<tip> olarak dönen diziyi tip[] şeklinde diziye çevirir.
ToList, IEnumerable<tip> olarak dönen diziyi List<tip> şeklinde diziye çevirir.
Except, dizinin, parametre olarak girilen 2. dizide olmayan elemanlarını listeler.
Union, diziye, parametre olarak girilen 2. dizinin elemanlarını ekler.
Intersect, dizinin, paramatre olarak girilen 2. dizi ile olan ortak elemanlarını listeler.
*/
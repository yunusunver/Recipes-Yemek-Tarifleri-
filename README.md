### Recipes(Yemek Tarifleri)
Bu projeyi aşağıdaki listelediğim teknolojileri, tasarım kalıplarını ve Aspect Oriented Programming tekniğini daha etkin kullanabilmek için `Yemek Tarifleri` senaryosu adı altında planlayarak tekrar amaçlı oluşturdum. 
İstenilen UI,API katmanı entegre edilebilir. Backend tarafında bütün operasyonlar çalışır durumdadır. 

### Kullanılan Teknolojiler
* Entity Framework
* NHibernate
* Ninject
* PostSharp
* Log4Net
* Fluent Validation
* AutoMapper

### Kullanılan Tasarım Kalıpları
* MVC
* Generic Repository Pattern
* Factory Pattern

### Cross Cutting Concerns İmplementasyonları 
`Bu implementasyonlar için Aspect Oriented Programming tekniğini kullanarak projemi SOLID'e uygun hale getirdim.`
* Validation Configuration
* Transaction Management
* Cache Management - Memory Cache
* Log Management
* Security - Cookie



## Veri Sözlüğü

### Category Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Kategori ID Numarası |
| CategoryName | Nvarchar | 50 | Kategori İsmi |
| Image | nvarchar | MAX | Kategori Resmi |


### Meal Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Tarif ID Numarası |
| UserId | int |  | Kullanıcı Id |
| CategoryId | int |  | Kategori Id |
| Name | varchar |  50 | Tarif İsmi |
| Description | varchar | MAX  | Açıklama |
| CookingTime | varchar | 50  | Pişirme Süresi |
| PersonQuantity | varchar | 50  | Kaç Kişilik |
| PreparationTime | varchar |  50 | Hazırlama Süresi |
| Point | int | 50  | varchar |
| CreatedDate | DateTime |   | Oluşturulma Tarihi |
| Image | varchar | MAX | Resim |

### Role Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Rol Id |
| Name | varchar | 50 | Rol Adı |

### User Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Kullanıcı Id |
| UserName | varchar | 50 | Kullanıcı Adı |
| Password | varchar |  100 | Parola |
| FirstName | varchar | 50 | Kullanıcı Adı |
| LastName | varchar |  50 | Kullanıcı Soyadı |
| Email | varchar | 50 | Mail Adresi |


### UserRole Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Rol Id |
| UserId | int | 50 | Kullanıcı Id |
| RoleId | int | 50 | Rol Id |

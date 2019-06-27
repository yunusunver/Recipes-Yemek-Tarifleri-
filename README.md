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
| CategoryName | nvarchar | 50 | Kategori İsmi |
| Image | nvarchar | MAX | Kategori Resmi |


### Meal Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Tarif ID Numarası |
| UserId | int |  | Kullanıcı Id |
| CategoryId | int |  | Kategori Id |
| Name | varchar |  50 | Tarif İsmi |
| Description | nvarchar | MAX  | Açıklama |
| CookingTime | nvarchar | 50  | Pişirme Süresi |
| PersonQuantity | nvarchar | 50  | Kaç Kişilik |
| PreparationTime | nvarchar |  50 | Hazırlama Süresi |
| Point | int | 50  | varchar |
| CreatedDate | DateTime |   | Oluşturulma Tarihi |
| Image | nvarchar | MAX | Resim |

### Role Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Rol Id |
| Name | nvarchar | 50 | Rol Adı |

### User Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Kullanıcı Id |
| UserName | nvarchar | 50 | Kullanıcı Adı |
| Password | nvarchar |  100 | Parola |
| FirstName | nvarchar | 50 | Kullanıcı Adı |
| LastName | nvarchar |  50 | Kullanıcı Soyadı |
| Email | nvarchar | 50 | Mail Adresi |


### UserRole Tablosu

| Değişken Adı | Veri Tipi | Uzunluk | Açıklama |
| --- | --- | --- | --- |
| Id | int |   | Rol Id |
| UserId | int | 50 | Kullanıcı Id |
| RoleId | int | 50 | Rol Id |

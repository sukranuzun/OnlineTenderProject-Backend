# OnlineTenderProject
Proje Adı: Online İhale Yönetimi

Proje Konusu: Online ortamda sistem yöneticisi (admin) tarafından herhangi bir konuda oluşturulmuş ihaleye, son kullanıcının (client) sisteme kayıt olduktan sonra teklif vermesi ve ihale sonunda en yüksek teklifi verene ihalenin sonuçlanması şeklinde yürütülecek bir sistemin tasarlanması hedeflenmektedir.
Proje Teknik Bilgileri: Web projesi olarak yapılacaktır. Üç ana başlıkta değerlendirilecektir.

Backend: .net core
Database: MsSql

Proje Detay: Proje iki ana rolden ilerlemektedir.

1. Sistem Yöneticisi (admin)
Sistemin yöneticisi olarak görev almaktadır. Sisteme admin olarak giriş yaptıktan sonra aşağıdaki işlemleri ve durumları gerçekleştirir:
 Yeni ihale oluşturabilir.
o İhaleye ilişkin fotoğraf yükler
o Sistem otomatik olarak bir ihale numarası oluşturur
o İhale başlangıç ve bitiş tarihini ve saatini belirler
o Kategori seçimi yapar (ev, araba, eşya … vb)
o İhale başlangıç fiyatını girer
 Aktif olan ihaleleri görüntüler
 İptal olmuş ihaleleri görüntüler
 Tamamlanmış ihaleleri görüntüler
 Aktif ihaleleri iptal edebilir
 Tüm ihaleler için (aktif, iptal, tamamlanmış) detay görüntüleyebilir. Detayda
o İhale bilgileri (oluşturulurken girdiği)
o Teklif geçmişi görüntülenir (Hangi kullanıcı ne zaman ne kadar teklif verdi gibi)

2. Son Kullanıcı (client)
Sistemde teklif veren olarak görev almaktadır. İhaleye teklif verebilmesi için sisteme kayıt olması gerekmektedir. Kayıt olmadan sadece ihaleleri görüntüleyebilir. Kayıt olduktan sonra:
 Aktif olan ihaleleri görüntüler
 Teklif verebilir
 Daha öncesinde kazandığı ihaleleri görüntüler
 Daha öncesinde girdiği fakat kazanamadığı ihaleleri görüntüler

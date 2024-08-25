var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

string[] makamlar = new[]
{
"Âb-ı Kevser", "Acem", "Acem-Aşîrân", "Acem-Bâ-Zir-Keşîde", "Acem-Bûselik", "Acem-Irak", "Acem-Kürdî", "Acem-Murassa", "Acem-Rast", "Acem-Zemzeme", "Acem-Zir-Keşîde", "Acemli Rast", "Âgâaze-i Kâbili", "Aheng-i-Tarâb", "Akberi", "Anber-Efşân", "Arabân", "Arabân-Kürdî", "Arabân-Nigâr", "Arabân-ı-Cedîd", "Arazbâr", "Arazbâr-Bûselik", "Arazbâr-Zemzeme", "Âvâz-ı Zenbûr", "Azrâ", "Aşîrân", "Aşîrân-Mâye", "Aşîrân-Vefâdar", "Aşîrân-Zemzeme", "Aşk-Efzâ", "Bâd-ı-Sabâ", "Bahâr", "Bahr-i-Nâzik", "Bayâti", "Bayâti-Arabân", "Bayâti-Arabân-Bûselik", "Bayâti-Aşîrân", "Bayâti-Bûselik", "Bayâti-Hisâr", "Bayâti-Isfahân", "Bayâti-Kürdî", "Bend-i-Bûselik", "Bend-i-Hisâr", "Beste-Hisâr", "Beste-Isfahân", "Beste-Nigâr", "Beste-Nigâr-Hisarek", "Beste-Nigâr-ı-Atîyk", "Beste-Nigâr-ı-Kadîm", "Beynel-Bahreyn", "Beyzâ", "Bezm-i Tarâb", "Bezmâra", "Buhârî", "Bûselik", "Bûselik-Aşîrân", "Bûselik-Gerdâniye", "Bûselik-Geveyşt", "Bûselik-Mâye", "Bûselik-Nevrûz", "Bûselik-Selmek", "Bûselik-Şehnaz", "Bûstan", "Büzürk", "Büzürk-Gerdâniye", "Büzürk-Geveyşt", "Büzürk-Mâye", "Büzürk-Nevrûz", "Büzürk-Selmek", "Büzürk-Şehnâz", "Canfezâ", "Çârgâh", "Çârgâh-Âcem", "Çârgâh-Gerdâniye", "Çârgâh-Mahûr", "Çehâr-Âgâazin", "Daği-Bayâti", "Danişverân", "Dil Âvîz", "Dil-Ârâ", "Dil-Efruz", "Dil-Keşîde", "Dil-Nişîn", "Dil-Rübâ", "Dil-Sûz", "Dildâr", "Dilkeş-Hâverân", "Dilküşâ", "Dost-Gahî", "Dügâh", "Dügâh-Bûselik", "Dügâh-Mâye", "Dügâh-ı Acem", "Dügâh-ı Kadîm", "Ebû-Selik", "Efrûhiten", "Evcârâ", "Evc (Eviç)", "Evc-Aşirân", "Evc-Bûselik", "Evc-Gerdâniye", "Evc-i Muhâlif", "Evc-Isfahân", "Evc-Maklüb", "Evc-Mâye", "Evc-Nihâvendi", "Ferâh", "Ferâh-Âver", "Ferâh-Zâyi", "Ferâhfezâ", "Ferâhnâk", "Ferâhnümâ", "Ferâhzâr", "Gamz-Edâ", "Gazâl", "Gerdâniye", "Gerdâniye-Bûselik", "Gerdâniye-Büzürk", "Gerdâniye-Hicâz", "Gerdâniye-Hüseynî", "Gerdâniye-Irak", "Gerdâniye-Isfahân", "Gerdâniye-Kûçek", "Gerdâniye-Kürdî", "Gerdâniye-Nevâ", "Gerdâniye-Nigâr", "Gerdâniye-Nikrîzi", "Gerdâniye-Rast", "Gerdâniye-Rehâvî", "Gerdâniye-Uşşâk", "Gerdâniye-Zirgüle", "Geveyşt", "Geveyşt-Bûselik", "Geveyşt-Büzürk", "Geveyşt-Gerdâniye", "Geveyşt-Hicâz", "Geveyşt-Hüseynî", "Geveyşt-Irak", "Geveyşt-Isfahân", "Geveyşt-Kûçek", "Geveyşt-Nevâ", "Geveyşt-Rehâvî", "Geveyşt-Uşşâk", "Geveyşt-Zirgüle", "Gonca-i-Rânâ", "Gururî", "Gül-Ruh", "Güldeste", "Gülistân", "Gülizâr", "Gülnâri", "Gülzâr", "Gülşen-i Vefâ", "Hadrâ (Hazrâ)", "Harran", "Hâver", "Hayâl-i Murâd", "Hayân", "Hazân", "Heftgâh", "Hicâz", "Hicâz Aşirân", "Hicâz-Acem", "Hicâz-Bûselik", "Hicâz-Büzürk", "Hicâz-Gerdâniye", "Hicâz-Geveyşt", "Hicâz-Irak", "Hicâz-Mâye", "Hicâz-Nevrûz", "Hicâz-Selmek", "Hicâz-ı Muhâlif", "Hicâz-ı Reke", "Hicâz-ı Türkî", "Hicâz-ı-Hicâz", "Hicâz-Zemzeme", "Hicâz-Şehnâz", "Hicâzeyn", "Hicâzî Hüseynî", "Hicâzî Isfahân", "Hicâzî Uşşâk", "Hicâzkâr", "Hicâzkâr-Bûselik", "Hicâzkârı-Kürdî", "Hisâr", "Hisâr- Vech-i Şehnâz", "Hisâr-Aşîrân", "Hisâr-Bûselik", "Hisâr-Evc", "Hisâr-ı Büzürk", "Hisâr-ı Gayr-ı Müstear", "Hisâr-ı Kâdim", "Hisâr-ı Kürdî", "Hisâr-ı Nîk", "Hisârek", "Hocest", "Horasan", "Hoş-Serâ", "Hucet", "Hudavendigâr", "Hufte-Isfahân", "Hûzi", "Huzî-Aşîrân", "Hûzi-Bûselik", "Hümâyûn", "Hüseynî", "Hüseynî- Geveyşt", "Hüseynî-Acem", "Hüseynî-Aşîrân", "Hüseynî-Bûselik", "Hüseynî-Gerdâniye", "Hüseynî-Horasâni", "Hüseynî-Kürdî (Zemzeme)", "Hüseynî-Nevrûz", "Hüseynî-Nikrîz", "Hüseynî-Rehâvi", "Hüseynî-Sabâ", "Hüseynî-Şehnâz", "Hüsn-ü Ân", "Hüzzâm", "Hüzzâm-ı Cedîd", "Hüzzâm-ı Kadîm", "Hüzzâm-ı Rûmi", "Irak", "Irak-Geceyşt", "Irak-Gerdâniye", "Irak-Mâye", "Irak-Nevrûz", "Irak-Selmek", "Irak-Şehnâz", "Irakı Acem", "Isfahân", "Isfahân-Bûselik", "Isfahân-Gerdâniye", "Isfahân-Geveyşt", "Isfahân-Irak", "Isfahân-Mâye", "Isfahân-Nevrûz", "Isfahân-Selmek", "Ifahân-ı Cedîd", "Isfahân-ı Sultâni", "Isfahân-Zemzeme", "Isfahân-Şehnâz", "Isfahânek-i Atîyk", "Isfahânek-i Cedîd", "Isfahânek", "Kâbilî", "Karcığar", "Kebûter", "Kûçek", "Kûçek-Geveyşt", "Kûçek-Mâye", "Kûçek-Nevrûz", "Kûçek-Selmek", "Kûçek-Sümbüle", "Kûçek-Zemzeme", "Kûçek-Şehnâz", "Kürdî", "Kürdî-Aşîrân", "Kürdîli Çârgâh", "Kürdîli Hicâzkâr", "Kürdîli Hümâyûn", "Lâle-Gül", "Lâle-Rûh", "Mâhûr", "Mâhûr-Aşîrân", "Mâhûr-Bûselik", "Mâhûr-Hân", "Mâhûr-i Kebîr", "Mâhûr-i Kebîr-i Kadîm", "Mâhûr-i Sagîyr", "Mâhûrek (Mâhûr-i Sagîyr)", "Mâhûri", "Matlûb", "Matlûbek", "Mâverâünnehr", "Mâye", "Mâye-Bûselik", "Mâye-Büzürk", "Mâye-Hicâz", "Mâye-Hüseynî", "Mâye-i Atîyk", "Mâye-i Kebîr", "Mâye-i Kevser", "Mâye-Irak", "Mâye-Isfahân", "Mâye-Kûçek", "Mâye-Nevâ", "Mâye-Rast (Rast-Mâye)", "Mâye-Rehâvî", "Mâye-Uşşâk", "Mâye-Zirgüle", "Mâşûk", "Meclis-Efrûz", "Mellâhi", "Mezmîm", "Mihr-i Cân", "Muhâlif", "Muhâlif-i Irak", "Muhâlif-i Rast", "Muhâlifek", "Muhayyer", "Muhayyer Bûselik", "Muhayyer Irak", "Muhayyer Kürdî", "Muhayyer Segâh", "Muhayyer Sümbüle", "Muhayyer Zirgüle", "Muhayyer-Zîrkeş", "Mûtedil", "Mûtrıbân", "Mûvafık", "Müberkâa", "Mücenebûr-Remel", "Müjdegâni", "Mürgâk", "Müsteâr", "Müsteârek", "Müteaddi", "Müşküye (Segâh-Aşîrân)", "Na-Murâd", "Nağme-i Kâbil", "Nâz", "Nâz-u Niyaz", "Nâzenin", "Necd-i Hüseynî", "Nesîm", "Nev-Edâ", "Nev-Eser", "Nev-Resîde", "Nevâ", "Nevâ-Acem", "Nevâ-Aşîrân", "Nevâ-Bûselik", "Nevâ-Gerdâniye", "Nevâ-Geveyşt", "Nevâ-Hüseynî", "Nevâ-Kürdî", "Nevâ-Mâye", "Nevâ-Nevrûz", "Nevâ-Selmek", "Nevâ-Şehnâz", "Nevây-ı Uşşâk", "Nevâziş", "Nevbahâr", "Nevrûz", "Nevrûz-Bayâti", "Nevrûz-Bûselik", "Nevrûz-Büzürk", "Nevrûz-Hicâz", "Nevrûz-Hüseynî", "Nevrûz-i Acem", "Nevrûz-i Arâb", "Nevrûz-i Hârâ", "Nevrûz-i Rast", "Nevrûz-i Rûmî", "Nevrûz-i Sultâni", "Nevrûz-Irak", "Nevrûz-Isfahân", "Nevrûz-Kûçek", "Nevrûz-Nevâ", "Nevrûz-Rehâvî", "Nevrûz-Sabâ", "Nevrûz-Uşşâk", "Nevrûz-Zirgüle", "Neşât-Âver", "Nigâr", "Nigâr-ı Nîk", "Nigâr-ı Nîk-Acem", "Nigârçek", "Nigârek", "Nihâvend", "Nihâvendi Cedîd", "Nihâvendi Kebir", "Nihâvendi Rûmî", "Nihâvendi Sagîyr", "Nikrîz", "Nikrîz-i Kebir", "Nikrîz-i Sagîyr", "Nikrîz-Segâh", "Nişâbûr (Nişâpûr)", "Nişâbûrek", "Nühüft (Nihift)", "Nühüft-Hicâzî", "Nühüft-i Kâdîm", "Pay-Zen-i Sabâ", "Pençgâh", "Pençgâh-ı Aşl", "Pençgâh-ı Zâid (Zâide)", "Perzerîn", "Pesendîde", "Pûşegân", "Râh-i Gül", "Râh-i Hâr-Ken", "Râh-i Hâr-Keş", "Râh-i Hûsrevâni", "Râh-i Rûh", "Râh-i Şeb-Diz", "Rahat-Fezâ", "Rahâtül-Ervâh", "Râmiş-Huvar", "Râmiş-i Cân", "Rast", "Rast-Acem", "Rast-Gerdâniye", "Rast-Geveyşt", "Rast-Hâverân", "Rast-Kürdî", "Rast-Mâhir", "Rast-Mâye", "Rast-Nevrûz", "Rast-Selmek", "Rast-ı Cedîd", "Rast-ı Kebîr", "Rast-Şehnâz", "Rehâvî (Rehâvî)", "Rehâvî-Gerdanîye", "Rehâvî-Geveyşt", "Rehâvî-Mâye", "Rehâvî-Nevrûz", "Rehâvî-Selmek", "Rehâvî-Şehnâz", "Rekb (Çârgâh-Rekb)", "Rekb-i Nevrûz", "Reng-i Dil", "Revâ-Irak", "Revnâk-Nümâ", "Ridâyî", "Rûh", "Rûh-Efzâ", "Rûhnevâz (Rûhnüvâz)", "Rûy-i Aşîrân", "Rûy-i Hicâz", "Rûy-i Irak", "Rıdvân", "Sabâ", "Sabâ-Aşîrân", "Sabâ-Bûselik", "Sabâ-Uşşâk", "Sabâ-Zemzeme", "Safâ", "Sâzkâr", "Se-Bahr", "Sebz-Ender-Sebz", "Sebz-Ender-Sebz-i Hisâr", "Sebz-Ender-Sebz-i Kadîm", "Sebz-î Hisâr", "Sebz-î Tâze", "Sebzî", "Segâh", "Segâh-Acem", "Segâh-Arabân", "Segâh-Mâye (Mâye)", "Segâh-Muhayyer", "Selmek (Selmekî)", "Selmek-Büzürk", "Selmek-Hicâz", "Selmek-Hüseynî", "Selmek-i Kebîr", "Selmek-i Sagîyr", "Selmek-Irak", "Selmek-Isfahân", "Selmek-Kûçek", "Selmek-Rast", "Selmek-Rehâvî", "Selmek-Zirgüle", "Ser-Bülend", "Ser-Henk", "Serendâz (Seng-Endâz)", "Sipihr", "Sipihr-Hüseynî", "Sipihr-Uşşâk", "Sireng", "Sultân-ı Bûselik", "Sultân-ı Cedîd", "Sultân-ı Nevâ", "Sultân-ı Segâh", "Sultân-ı Yegâh", "Sultân-ı-Irak", "Suz-i Dil", "Suz-i Dilâra", "Sûznâk (Basit Sûzinâk)", "Sünbüle", "Sünbüle-i Kâdîm", "Sünbüle-Nihâvend", "Şâd-Kâmı", "Şâh", "Şâhî", "Şâhvâr (Şehvâr)", "Şedd-i Arabân", "Şehnâz", "Şehnâz-Aşîrân", "Şehnâz-Bûselik", "Şehnâz-Büzürk", "Şehnâz-Hâverân (Irak)", "Şehnâz-Hicâz", "Şehnâz-Hüseynî", "Şehnâz-Kûçek", "Şehnâz-Kürdî", "Şehnâz-Nevâ", "Şehnâz-Rast", "Şehnâz-Rehâvî", "Şehnâz-Uşşâk", "Şehnâz-Zirgüle", "Şehr-i Naz (Şehr-Nâz)", "Şehvâr", "Şems-Efrûz", "Şeref-Nümâ", "Şevk-Âver", "Şevk-Efzâ", "Şevk-Engîz", "Şevk-i Cedîd", "Şevk-i Dil", "Şevk-i Serâb", "Şevk-i Tarâb", "Şeşgâh", "Şiâr", "Şinâver", "Şirâz", "Şirâz-Sünbüle", "Şirîn", "Şîvekâr", "Şîvekeş", "Şîvenümâ", "Şûrî", "Şüster", "Tâhir", "Tâhir-Bûselik", "Tâhir-i Kebîr", "Tâhir-i Sagîyr", "Tâhir-Kürdî", "Tanık", "Tarz-ı Bihîn", "Tarz-ı Cedîd", "Tarz-ı Nevîn", "Tebrîz", "Tehrîzî", "Tereşşüd", "Terkîb-i Sabâ", "Tüvânger", "Urfa-Mâhûr", "Uzzâl", "Uzzâl-Acem", "Uzzâl-Hüseynî", "Uzzâl-Şehnâz", "Uşşâk", "Uşşâk-Aşîrân", "Uşşâk-Gerdâniye", "Uşşâk-Geveyşt", "Uşşâk-Mâye", "Uşşâk-Nevrûz", "Uşşâk-Selmek", "Uşşâk-Şehnâz", "Vâmık", "Vech-i Arazbâr", "Vech-i Bûselik", "Vech-i Hüseynî", "Vech-i Şehnâz", "Yâr", "Yegâh", "Zâd-ı Dil", "Zâvîl (Zavil)", "Zâvîli (Zâvûli)", "Zâvîli Isfahân", "Zâvîli Segâh", "Zemzem", "Zemzeme (Eski Zemzeme)", "Zemzeme-Kürdî", "Zende-Rûd", "Zengüle (Zirgüle)", "Zengüle-Bûselik", "Zengüle-Gerdâniye", "Zengüle-Geveyşt", "Zengüle-Mâye", "Zengüle-Nevrûz", "Zengüle-Selmek", "Zengüle-Şehnâz", "Zengüleli Sûznak", "Zevk-Bahş", "Zevk-i Dil", "Zevk-u Tarâb", "Zirefkend", "Zirefkend Şarkı", "Zirefkend-i Büzürk", "Zirefkend-i Kûçek", "Zirefkend-i Rûmi", "Zirkeş-Hâveran", "Zirkeş-Hüseynî", "Zirkeşîde", "Zülf-i Nigâr"
};

app.MapGet("/", () =>
"Es Selamu aleyküm aziz dost!" +
"\n\nEğer istersin bir makam bulmak:" +
"\nYaz a dost tarayıcın anlına '/yâHak'." +
"\n\nEğer istersin hepsini göresin;" +
"\nYaz tarayıcın anlına '/Hepisi'."
);

// Tüm makamları döndüren bir GET isteği
app.MapGet("/Hepisi", () =>
{
    return makamlar;
});

// Rastgele bir makam döndüren bir GET isteği
app.MapGet("/yâHak", () =>
{
    var randomMakam = makamlar[Random.Shared.Next(makamlar.Length)];
    return randomMakam;
});

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

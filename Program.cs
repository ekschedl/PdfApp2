using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        QuestPDF.Settings.License = LicenseType.Community;

        var image = File.ReadAllBytes("photo.jpg");

        Document
            .Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(40);

                    page.Header()
                        .Height(50)
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Ekaterina Schedlberger BA")
                        .FontSize(20)
                        .Bold()
                        .FontColor("#2980B9");

                    page.Content()
                        .Column(col =>
                        {
                            col.Spacing(15);

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Column(contactCol =>
                                {
                                    contactCol.Spacing(10);
                                    contactCol.Item().Text("Tel: +43 660 552 0575").FontSize(14);
                                    contactCol.Item().Text("Email: ek.schedl@gmail.com").FontSize(14);
                                    contactCol.Item().Text("Hafnerstraße 42-1, 8055 Graz").FontSize(14);
                                    contactCol.Item().Text("freier Zugang zum Arbeitsmarkt").FontSize(14);
                                });

                                row.AutoItem().Width(110).Image(image);
                            });

                            col.Item().Text("Ausbildungsweg")
                                .FontSize(20)
                                .Bold()
                                .FontColor("#2980B9");

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2022 – 2023 ").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("WIFI Steiermark , Ausbildung zur Web Developerin\n• WordPress,\n• HTML,\n• CSS,\n• Javascript & jQuery,\n• PHP,\n• Python,\n• VS Code, Git, SEO").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2010 – 2015 ").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Karl-Franzens-Universität Graz\nTranskulturelle Kommunikation: Deutsch, Italienisch, Russisch").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2002 – 2006 ").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Baikal Universität für Ökonomie und Recht, Russland\nÖkonom – Manager").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2000 – 2002").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Kolleg der Baikal Universität für Ökonomie und Recht, Russland\nBankwesen").FontSize(14);
                            });

                            col.Item().Text("Weiterbildung")
                                .FontSize(20)
                                .Bold()
                                .FontColor("#2980B9");

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2024 – a dato").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Meta Front-End Developer Professional Certificate, Online-Lernplattform: Coursera.org").FontSize(14);
                            });

                            col.Item().Row(row =>
                           {
                               row.RelativeItem().Text("2024 – 2024").FontSize(14).AlignLeft();
                               row.RelativeItem().Text("JavaScript online Intensivkurs").FontSize(14);
                           });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2017, 2020").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Englisch (B1)\nInternationles Sprachzentrum, Graz").FontSize(14);
                            });

                            col.Item().Text("Berufserfahrung")
                                .FontSize(20)
                                .Bold()
                                .FontColor("#2980B9");

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2020 – 2024").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Rezeption, Boutiquehotel Dom, Graz").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2014 – 2015").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Dolmetscherin für Russisch, ehrenamtlich, Ambulatorium Caritas Marienambulanz, Graz").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("2002 – 2009").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Back Office, internes Controlling, Bereich: Wertpapier").FontSize(14);
                            });

                            col.Item().Text("Skills")
                                .FontSize(20)
                                .Bold()
                                .FontColor("#2980B9");

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("Frontend Development: ").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("HTML, CSS, JavaScript, Vue.js (Grundkenntnisse)").FontSize(14).AlignLeft();
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("Backend Basics: ").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("Python (erste Projekte), PHP (Grundkenntnisse)").FontSize(14).AlignLeft();
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("Tools & Technologies: ").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("VS Code, PyCharm, Git, SEO, WordPress").FontSize(14).AlignLeft();
                            });

                            col.Item().Text("Sprachen")
                                .FontSize(20)
                                .Bold()
                                .FontColor("#2980B9");

                            col.Item().Row(row =>
                          {
                              row.RelativeItem().Text("Russisch:").FontSize(14).AlignLeft();
                              row.RelativeItem().Text("Muttersprache").FontSize(14);
                          });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("Deutsch:").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("C1 – fließend in Wort und Schrift").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("Englisch:").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("B1 – gute Grundkenntnisse, beruflich einsetzbar").FontSize(14);
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("Italienisch:").FontSize(14).AlignLeft();
                                row.RelativeItem().Text("A2").FontSize(14);
                            });

                            col.Item().Text("Portfolio:")
                                .FontSize(20)
                                .Bold()
                                .FontColor("#16A085");

                            col.Item().Text("https://ekschedl.com")
                                .FontSize(14)
                                .Underline()
                                .FontColor("#2980B9");

                            col.Item().Text("https://sibsladosti.ru")
                                .FontSize(14)
                                .Underline()
                                .FontColor("#2980B9");

                            col.Item().Text("https://ekschedl.github.io")
                                .FontSize(14)
                                .Underline()
                                .FontColor("#2980B9");

                        });

                    page.Footer()
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .AlignLeft()
                                .Text($"Datum: {DateTime.Now:dd.MM.yyyy HH:mm}")
                                .FontSize(8)
                                .FontColor("#888888");

                            row.RelativeItem()
                                .AlignRight()
                                .Text("Dokument erstellt mit der QuestPDF-Bibliothek")
                                .FontSize(8)
                                .FontColor("#888888");
                        });
                });
            })
            .GeneratePdf("output.pdf");

        Console.WriteLine("PDF wurde generiert!");
    }
}
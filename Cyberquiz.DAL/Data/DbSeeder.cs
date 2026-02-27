using Cyberquiz.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyberquiz.DAL.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (await context.Quizzes.AnyAsync())
                return;

            // SVARSALTERNATIV — globalt bibliotek, återanvänds fritt mellan frågor

            // Städer & länder
            var aParis          = new AnswerOptionModel { Answer = "Paris" };
            var aLondon         = new AnswerOptionModel { Answer = "London" };
            var aBerlin         = new AnswerOptionModel { Answer = "Berlin" };
            var aMadrid         = new AnswerOptionModel { Answer = "Madrid" };
            var aRom            = new AnswerOptionModel { Answer = "Rom" };
            var aStockholm      = new AnswerOptionModel { Answer = "Stockholm" };
            var aGoteborg       = new AnswerOptionModel { Answer = "Göteborg" };
            var aMalmo          = new AnswerOptionModel { Answer = "Malmö" };
            var aUppsala        = new AnswerOptionModel { Answer = "Uppsala" };
            var aRyssland       = new AnswerOptionModel { Answer = "Ryssland" };      // ✓ störst land + flest invånare Europa
            var aTyskland       = new AnswerOptionModel { Answer = "Tyskland" };      // ✗ återanvänds i flera frågor
            var aFrankrike      = new AnswerOptionModel { Answer = "Frankrike" };
            var aItalien        = new AnswerOptionModel { Answer = "Italien" };       // ✓ antika Rom, ✗ VM-guld, ✗ invånare
            var aGrekland       = new AnswerOptionModel { Answer = "Grekland" };
            var aSpanien        = new AnswerOptionModel { Answer = "Spanien" };
            var aTurkiet        = new AnswerOptionModel { Answer = "Turkiet" };
            var aKanada         = new AnswerOptionModel { Answer = "Kanada" };
            var aUSA            = new AnswerOptionModel { Answer = "USA" };
            var aKina           = new AnswerOptionModel { Answer = "Kina" };          // ✗ återanvänds i geografi + mat
            var aJapan          = new AnswerOptionModel { Answer = "Japan" };         // ✓ sushi + Spirited Away
            var aBrasilien      = new AnswerOptionModel { Answer = "Brasilien" };     // ✓ VM-guld fotboll + kaffe
            var aArgentina      = new AnswerOptionModel { Answer = "Argentina" };
            var aSydkorea       = new AnswerOptionModel { Answer = "Sydkorea" };      // ✗ återanvänds i mat + film
            var aVietnam        = new AnswerOptionModel { Answer = "Vietnam" };       // ✗ återanvänds i mat + geografi
            var aKolombia       = new AnswerOptionModel { Answer = "Colombia" };
            var aEtiopien       = new AnswerOptionModel { Answer = "Etiopien" };
            var aAthen          = new AnswerOptionModel { Answer = "Aten" };

            // Floder
            var aNilen          = new AnswerOptionModel { Answer = "Nilen" };
            var aAmazonas       = new AnswerOptionModel { Answer = "Amazonas" };
            var aYangtze        = new AnswerOptionModel { Answer = "Yangtze" };
            var aMississippi    = new AnswerOptionModel { Answer = "Mississippi" };

            // Siffror — återanvänds brett över kategorier
            var a2  = new AnswerOptionModel { Answer = "2" };
            var a3  = new AnswerOptionModel { Answer = "3" };
            var a4  = new AnswerOptionModel { Answer = "4" };   // ✗ gitarr, insekt, ✓ OS-intervall
            var a5  = new AnswerOptionModel { Answer = "5" };
            var a6  = new AnswerOptionModel { Answer = "6" };   // ✓ gitarrsträngar + hexagon + insektben
            var a7  = new AnswerOptionModel { Answer = "7" };
            var a8  = new AnswerOptionModel { Answer = "8" };   // ✗ gitarr, insekt, hexagon
            var a9  = new AnswerOptionModel { Answer = "9" };
            var a10 = new AnswerOptionModel { Answer = "10" };
            var a11 = new AnswerOptionModel { Answer = "11" };  // ✓ fotbollsspelare, ✗ kvadratrot 144
            var a12 = new AnswerOptionModel { Answer = "12" };  // ✓ kvadratrot 144, ✗ fotboll
            var a13 = new AnswerOptionModel { Answer = "13" };
            var a14 = new AnswerOptionModel { Answer = "14" };
            var a45  = new AnswerOptionModel { Answer = "45" };
            var a60  = new AnswerOptionModel { Answer = "60" };
            var a90  = new AnswerOptionModel { Answer = "90" };
            var a180 = new AnswerOptionModel { Answer = "180" };

            // Årtal
            var a395  = new AnswerOptionModel { Answer = "395" };
            var a410  = new AnswerOptionModel { Answer = "410" };
            var a476  = new AnswerOptionModel { Answer = "476" };
            var a500  = new AnswerOptionModel { Answer = "500" };
            var a1943 = new AnswerOptionModel { Answer = "1943" };
            var a1944 = new AnswerOptionModel { Answer = "1944" };
            var a1945 = new AnswerOptionModel { Answer = "1945" };
            var a1946 = new AnswerOptionModel { Answer = "1946" };
            var a1969 = new AnswerOptionModel { Answer = "1969" };
            var a1970 = new AnswerOptionModel { Answer = "1970" };
            var a1972 = new AnswerOptionModel { Answer = "1972" };
            var a1975 = new AnswerOptionModel { Answer = "1975" };
            var a1995 = new AnswerOptionModel { Answer = "1995" };
            var a1997 = new AnswerOptionModel { Answer = "1997" };
            var a1998 = new AnswerOptionModel { Answer = "1998" };
            var a1999 = new AnswerOptionModel { Answer = "1999" };
            var a2000 = new AnswerOptionModel { Answer = "2000" };
            var a2001 = new AnswerOptionModel { Answer = "2001" };

            // Svenska regenter
            var aKarlXII       = new AnswerOptionModel { Answer = "Karl XII" };
            var aGustavIIAdolf = new AnswerOptionModel { Answer = "Gustav II Adolf" };
            var aKarlXI        = new AnswerOptionModel { Answer = "Karl XI" };
            var aGustavIII     = new AnswerOptionModel { Answer = "Gustav III" };

            // Kemi
            var aH2O  = new AnswerOptionModel { Answer = "H₂O" };
            var aCO2  = new AnswerOptionModel { Answer = "CO₂" };
            var aNaCl = new AnswerOptionModel { Answer = "NaCl" };
            var aO2   = new AnswerOptionModel { Answer = "O₂" };

            // Grundämnen
            var aVate   = new AnswerOptionModel { Answer = "Väte" };
            var aHelium = new AnswerOptionModel { Answer = "Helium" };
            var aSyre   = new AnswerOptionModel { Answer = "Syre" };
            var aKol    = new AnswerOptionModel { Answer = "Kol" };

            // Hastigheter
            var a300000 = new AnswerOptionModel { Answer = "300 000 km/s" };
            var a150000 = new AnswerOptionModel { Answer = "150 000 km/s" };
            var a500000 = new AnswerOptionModel { Answer = "500 000 km/s" };
            var a100000 = new AnswerOptionModel { Answer = "100 000 km/s" };

            // Vetenskapsmän — återanvänds i fysikfrågor
            var aNewton   = new AnswerOptionModel { Answer = "Newton" };
            var aEinstein = new AnswerOptionModel { Answer = "Einstein" };
            var aGalileo  = new AnswerOptionModel { Answer = "Galileo" };
            var aHawking  = new AnswerOptionModel { Answer = "Hawking" };

            // Kompositörer
            var aBeethoven = new AnswerOptionModel { Answer = "Beethoven" };
            var aMozart    = new AnswerOptionModel { Answer = "Mozart" };
            var aBach      = new AnswerOptionModel { Answer = "Bach" };
            var aChopin    = new AnswerOptionModel { Answer = "Chopin" };

            // Band
            var aQueen         = new AnswerOptionModel { Answer = "Queen" };
            var aBeatles       = new AnswerOptionModel { Answer = "The Beatles" };
            var aLedZeppelin   = new AnswerOptionModel { Answer = "Led Zeppelin" };
            var aRollingStones = new AnswerOptionModel { Answer = "Rolling Stones" };

            // Skådespelare
            var aRDJ            = new AnswerOptionModel { Answer = "Robert Downey Jr." };
            var aChrisEvans     = new AnswerOptionModel { Answer = "Chris Evans" };
            var aChrisHemsworth = new AnswerOptionModel { Answer = "Chris Hemsworth" };
            var aMarkRuffalo    = new AnswerOptionModel { Answer = "Mark Ruffalo" };

            // Animationsstudios
            var aDisney     = new AnswerOptionModel { Answer = "Disney" };
            var aPixar      = new AnswerOptionModel { Answer = "Pixar" };
            var aDreamWorks = new AnswerOptionModel { Answer = "DreamWorks" };
            var aWarnerBros = new AnswerOptionModel { Answer = "Warner Bros" };

            // Förkortningar (teknik)
            var aCpuCorrect = new AnswerOptionModel { Answer = "Central Processing Unit" };
            var aCpuWrong1  = new AnswerOptionModel { Answer = "Computer Power Unit" };
            var aCpuWrong2  = new AnswerOptionModel { Answer = "Central Program Unit" };
            var aCpuWrong3  = new AnswerOptionModel { Answer = "Core Processing Unit" };
            var aWwwCorrect = new AnswerOptionModel { Answer = "World Wide Web" };
            var aWwwWrong1  = new AnswerOptionModel { Answer = "World Wire Web" };
            var aWwwWrong2  = new AnswerOptionModel { Answer = "Wide World Web" };
            var aWwwWrong3  = new AnswerOptionModel { Answer = "Web World Wide" };

            // Teknikföretag — återanvänds i Windows + Google-frågor
            var aMicrosoft = new AnswerOptionModel { Answer = "Microsoft" };
            var aApple     = new AnswerOptionModel { Answer = "Apple" };
            var aGoogle    = new AnswerOptionModel { Answer = "Google" };
            var aIBM       = new AnswerOptionModel { Answer = "IBM" };

            // Pi
            var aPi314 = new AnswerOptionModel { Answer = "3,14" };
            var aPi312 = new AnswerOptionModel { Answer = "3,12" };
            var aPi316 = new AnswerOptionModel { Answer = "3,16" };
            var aPi318 = new AnswerOptionModel { Answer = "3,18" };

            // Djur
            var aElefant   = new AnswerOptionModel { Answer = "Afrikansk elefant" };
            var aNoshorn   = new AnswerOptionModel { Answer = "Noshörning" };
            var aFlodhaest = new AnswerOptionModel { Answer = "Flodhäst" };
            var aGiraff    = new AnswerOptionModel { Answer = "Giraff" };

            // Träd
            var aEk    = new AnswerOptionModel { Answer = "Ek" };
            var aBjork = new AnswerOptionModel { Answer = "Björk" };
            var aGran  = new AnswerOptionModel { Answer = "Gran" };
            var aTall  = new AnswerOptionModel { Answer = "Tall" };

            // Biologiska processer
            var aFotosyntes  = new AnswerOptionModel { Answer = "Fotosyntes" };
            var aMetabolism  = new AnswerOptionModel { Answer = "Metabolism" };
            var aOsmos       = new AnswerOptionModel { Answer = "Osmos" };
            var aRespiration = new AnswerOptionModel { Answer = "Respiration" };

            // Mat & dryck
            var aAvokado = new AnswerOptionModel { Answer = "Avokado" };
            var aTomat   = new AnswerOptionModel { Answer = "Tomat" };
            var aLok     = new AnswerOptionModel { Answer = "Lök" };
            var aLime    = new AnswerOptionModel { Answer = "Lime" };
            var aDruvor  = new AnswerOptionModel { Answer = "Druvor" };
            var aApplen  = new AnswerOptionModel { Answer = "Äpplen" };
            var aParon   = new AnswerOptionModel { Answer = "Päron" };
            var aPlommon = new AnswerOptionModel { Answer = "Plommon" };


            // KATEGORIER & SUBKATEGORIER

            var catGeografi  = new CategoryModel { Name = "Geografi" };
            var catHistoria  = new CategoryModel { Name = "Historia" };
            var catVetenskap = new CategoryModel { Name = "Vetenskap" };
            var catSport     = new CategoryModel { Name = "Sport" };
            var catMusik     = new CategoryModel { Name = "Musik" };
            var catFilmTV    = new CategoryModel { Name = "Film & TV" };
            var catMatematik = new CategoryModel { Name = "Matematik" };
            var catNatur     = new CategoryModel { Name = "Natur" };
            var catTeknik    = new CategoryModel { Name = "Teknik" };
            var catMatDryck  = new CategoryModel { Name = "Mat & Dryck" };

            var subEuropa         = new SubCategoryModel { Name = "Europa" };
            var subVarlden        = new SubCategoryModel { Name = "Världen" };
            var subAntiken        = new SubCategoryModel { Name = "Antiken" };
            var subModernHistoria = new SubCategoryModel { Name = "Modern Historia" };
            var subKemi           = new SubCategoryModel { Name = "Kemi" };
            var subFysik          = new SubCategoryModel { Name = "Fysik" };
            var subFotboll        = new SubCategoryModel { Name = "Fotboll" };
            var subOS             = new SubCategoryModel { Name = "Olympiska Spelen" };
            var subKlassisk       = new SubCategoryModel { Name = "Klassisk Musik" };
            var subPopRock        = new SubCategoryModel { Name = "Pop & Rock" };
            var subHollywood      = new SubCategoryModel { Name = "Hollywood" };
            var subAnimation      = new SubCategoryModel { Name = "Animation" };
            var subAritmetik      = new SubCategoryModel { Name = "Aritmetik" };
            var subGeometri       = new SubCategoryModel { Name = "Geometri" };
            var subDjur           = new SubCategoryModel { Name = "Djur" };
            var subVaxter         = new SubCategoryModel { Name = "Växter" };
            var subDatorer        = new SubCategoryModel { Name = "Datorer" };
            var subInternet       = new SubCategoryModel { Name = "Internet" };
            var subMatlagning     = new SubCategoryModel { Name = "Matlagning" };
            var subDrycker        = new SubCategoryModel { Name = "Drycker" };

            subEuropa.Category     = catGeografi;
            subVarlden.Category    = catGeografi;
            subAntiken.Category    = catHistoria;
            subModernHistoria.Category = catHistoria;
            subKemi.Category       = catVetenskap;
            subFysik.Category      = catVetenskap;
            subFotboll.Category    = catSport;
            subOS.Category         = catSport;
            subKlassisk.Category   = catMusik;
            subPopRock.Category    = catMusik;
            subHollywood.Category  = catFilmTV;
            subAnimation.Category  = catFilmTV;
            subAritmetik.Category  = catMatematik;
            subGeometri.Category   = catMatematik;
            subDjur.Category       = catNatur;
            subVaxter.Category     = catNatur;
            subDatorer.Category    = catTeknik;
            subInternet.Category   = catTeknik;
            subMatlagning.Category = catMatDryck;
            subDrycker.Category    = catMatDryck;

            // FRÅGOR

            // --- Geografi: Europa ---
            var qFrankrikesHuvudstad = new QuestionModel
            {
                Question = "Vad är huvudstaden i Frankrike?",
                CategoryId = new List<CategoryModel> { catGeografi },
                SubCategoryId = new List<SubCategoryModel> { subEuropa }
            };
            var qSverigesHuvudstad = new QuestionModel
            {
                Question = "Vad är huvudstaden i Sverige?",
                CategoryId = new List<CategoryModel> { catGeografi },
                SubCategoryId = new List<SubCategoryModel> { subEuropa }
            };
            var qFlestInvanareEuropa = new QuestionModel
            {
                Question = "Vilket land har flest invånare i Europa?",
                CategoryId = new List<CategoryModel> { catGeografi },
                SubCategoryId = new List<SubCategoryModel> { subEuropa }
            };

            // --- Geografi: Världen ---
            var qStorstaLandYta = new QuestionModel
            {
                Question = "Vilket är världens största land till ytan?",
                CategoryId = new List<CategoryModel> { catGeografi },
                SubCategoryId = new List<SubCategoryModel> { subVarlden }
            };
            var qLangstaFlod = new QuestionModel
            {
                Question = "Vilket är världens längsta flod?",
                CategoryId = new List<CategoryModel> { catGeografi },
                SubCategoryId = new List<SubCategoryModel> { subVarlden }
            };

            // --- Historia: Antiken ---
            var qAntikRomLand = new QuestionModel
            {
                Question = "I vilket land låg det antika Rom?",
                CategoryId = new List<CategoryModel> { catHistoria },
                SubCategoryId = new List<SubCategoryModel> { subAntiken }
            };
            var qVastromerriketFall = new QuestionModel
            {
                Question = "Vilket år föll Västromerska riket?",
                CategoryId = new List<CategoryModel> { catHistoria },
                SubCategoryId = new List<SubCategoryModel> { subAntiken }
            };

            // --- Historia: Modern Historia ---
            var qAndraVK = new QuestionModel
            {
                Question = "Vilket år slutade andra världskriget?",
                CategoryId = new List<CategoryModel> { catHistoria },
                SubCategoryId = new List<SubCategoryModel> { subModernHistoria }
            };
            var qStoraNordiskaKriget = new QuestionModel
            {
                Question = "Vem var Sveriges kung under stora nordiska kriget?",
                CategoryId = new List<CategoryModel> { catHistoria },
                SubCategoryId = new List<SubCategoryModel> { subModernHistoria }
            };

            // --- Vetenskap: Kemi ---
            var qVattenFormel = new QuestionModel
            {
                Question = "Vad är den kemiska beteckningen för vatten?",
                CategoryId = new List<CategoryModel> { catVetenskap },
                SubCategoryId = new List<SubCategoryModel> { subKemi }
            };
            var qAtomNummer1 = new QuestionModel
            {
                Question = "Vilket grundämne har atomnummer 1?",
                CategoryId = new List<CategoryModel> { catVetenskap },
                SubCategoryId = new List<SubCategoryModel> { subKemi }
            };

            // --- Vetenskap: Fysik ---
            var qLjusets = new QuestionModel
            {
                Question = "Ungefär hur snabbt rör sig ljus i vakuum?",
                CategoryId = new List<CategoryModel> { catVetenskap },
                SubCategoryId = new List<SubCategoryModel> { subFysik }
            };
            var qGravitationslagen = new QuestionModel
            {
                Question = "Vem formulerade gravitationslagen?",
                CategoryId = new List<CategoryModel> { catVetenskap },
                SubCategoryId = new List<SubCategoryModel> { subFysik }
            };

            // --- Sport: Fotboll ---
            var qFotbollsspelare = new QuestionModel
            {
                Question = "Hur många spelare har ett fotbollslag på planen?",
                CategoryId = new List<CategoryModel> { catSport },
                SubCategoryId = new List<SubCategoryModel> { subFotboll }
            };
            var qVMGuldFotboll = new QuestionModel
            {
                Question = "Vilket land har vunnit flest VM-guld i fotboll?",
                CategoryId = new List<CategoryModel> { catSport },
                SubCategoryId = new List<SubCategoryModel> { subFotboll }
            };

            // --- Sport: OS ---
            var qForstaModernaOS = new QuestionModel
            {
                Question = "Var hölls de första moderna olympiska spelen (1896)?",
                CategoryId = new List<CategoryModel> { catSport },
                SubCategoryId = new List<SubCategoryModel> { subOS }
            };
            var qOSVartHurvangaar = new QuestionModel
            {
                Question = "Vart hur många år hålls de olympiska sommarspelen?",
                CategoryId = new List<CategoryModel> { catSport },
                SubCategoryId = new List<SubCategoryModel> { subOS }
            };

            // --- Musik: Klassisk ---
            var qFurElise = new QuestionModel
            {
                Question = "Vem komponerade \"Für Elise\"?",
                CategoryId = new List<CategoryModel> { catMusik },
                SubCategoryId = new List<SubCategoryModel> { subKlassisk }
            };
            var qGitarrStrangar = new QuestionModel
            {
                Question = "Hur många strängar har en standardgitarr?",
                CategoryId = new List<CategoryModel> { catMusik },
                SubCategoryId = new List<SubCategoryModel> { subKlassisk }
            };

            // --- Musik: Pop & Rock ---
            var qBohemianRhapsody = new QuestionModel
            {
                Question = "Vilket band sjöng \"Bohemian Rhapsody\"?",
                CategoryId = new List<CategoryModel> { catMusik },
                SubCategoryId = new List<SubCategoryModel> { subPopRock }
            };
            var qABBA = new QuestionModel
            {
                Question = "Vilket år bildades ABBA?",
                CategoryId = new List<CategoryModel> { catMusik },
                SubCategoryId = new List<SubCategoryModel> { subPopRock }
            };

            // --- Film & TV: Hollywood ---
            var qIronMan = new QuestionModel
            {
                Question = "Vem spelar Iron Man i MCU?",
                CategoryId = new List<CategoryModel> { catFilmTV },
                SubCategoryId = new List<SubCategoryModel> { subHollywood }
            };
            var qTitanicAr = new QuestionModel
            {
                Question = "Vilket år hade filmen Titanic premiär?",
                CategoryId = new List<CategoryModel> { catFilmTV },
                SubCategoryId = new List<SubCategoryModel> { subHollywood }
            };

            // --- Film & TV: Animation ---
            var qSpiritedAway = new QuestionModel
            {
                Question = "Vilket land producerade animationsfilmen \"Spirited Away\"?",
                CategoryId = new List<CategoryModel> { catFilmTV },
                SubCategoryId = new List<SubCategoryModel> { subAnimation }
            };
            var qLejonkungen = new QuestionModel
            {
                Question = "Vilket studio skapade \"Lejonkungen\" (1994)?",
                CategoryId = new List<CategoryModel> { catFilmTV },
                SubCategoryId = new List<SubCategoryModel> { subAnimation }
            };

            // --- Matematik: Aritmetik ---
            var qKvadratrot144 = new QuestionModel
            {
                Question = "Vad är kvadratroten ur 144?",
                CategoryId = new List<CategoryModel> { catMatematik },
                SubCategoryId = new List<SubCategoryModel> { subAritmetik }
            };
            var qHexagonSidor = new QuestionModel
            {
                Question = "Hur många sidor har en hexagon?",
                CategoryId = new List<CategoryModel> { catMatematik },
                SubCategoryId = new List<SubCategoryModel> { subAritmetik }
            };

            // --- Matematik: Geometri ---
            var qRatVinkel = new QuestionModel
            {
                Question = "Hur många grader är en rät vinkel?",
                CategoryId = new List<CategoryModel> { catMatematik },
                SubCategoryId = new List<SubCategoryModel> { subGeometri }
            };
            var qPi = new QuestionModel
            {
                Question = "Vad är talet pi avrundat till 2 decimaler?",
                CategoryId = new List<CategoryModel> { catMatematik },
                SubCategoryId = new List<SubCategoryModel> { subGeometri }
            };

            // --- Natur: Djur ---
            var qStorstaLanddjur = new QuestionModel
            {
                Question = "Vilket är världens största landlevande djur?",
                CategoryId = new List<CategoryModel> { catNatur },
                SubCategoryId = new List<SubCategoryModel> { subDjur }
            };
            var qInsektBen = new QuestionModel
            {
                Question = "Hur många ben har en insekt?",
                CategoryId = new List<CategoryModel> { catNatur },
                SubCategoryId = new List<SubCategoryModel> { subDjur }
            };

            // --- Natur: Växter ---
            var qEkollon = new QuestionModel
            {
                Question = "Vilket träd producerar ekollon?",
                CategoryId = new List<CategoryModel> { catNatur },
                SubCategoryId = new List<SubCategoryModel> { subVaxter }
            };
            var qFotosyntes = new QuestionModel
            {
                Question = "Vad heter processen där växter omvandlar solljus till energi?",
                CategoryId = new List<CategoryModel> { catNatur },
                SubCategoryId = new List<SubCategoryModel> { subVaxter }
            };

            // --- Teknik: Datorer ---
            var qCPU = new QuestionModel
            {
                Question = "Vad står förkortningen CPU för?",
                CategoryId = new List<CategoryModel> { catTeknik },
                SubCategoryId = new List<SubCategoryModel> { subDatorer }
            };
            var qWindowsSkapare = new QuestionModel
            {
                Question = "Vilket företag skapade operativsystemet Windows?",
                CategoryId = new List<CategoryModel> { catTeknik },
                SubCategoryId = new List<SubCategoryModel> { subDatorer }
            };

            // --- Teknik: Internet ---
            var qWWW = new QuestionModel
            {
                Question = "Vad står WWW för?",
                CategoryId = new List<CategoryModel> { catTeknik },
                SubCategoryId = new List<SubCategoryModel> { subInternet }
            };
            var qGoogleGrundat = new QuestionModel
            {
                Question = "Vilket år grundades Google?",
                CategoryId = new List<CategoryModel> { catTeknik },
                SubCategoryId = new List<SubCategoryModel> { subInternet }
            };

            // --- Mat & Dryck: Matlagning ---
            var qSushiUrsprung = new QuestionModel
            {
                Question = "Vilket land kommer sushi ursprungligen från?",
                CategoryId = new List<CategoryModel> { catMatDryck },
                SubCategoryId = new List<SubCategoryModel> { subMatlagning }
            };
            var qGuacamoleIngrediens = new QuestionModel
            {
                Question = "Vad är huvudingrediensen i guacamole?",
                CategoryId = new List<CategoryModel> { catMatDryck },
                SubCategoryId = new List<SubCategoryModel> { subMatlagning }
            };

            // --- Mat & Dryck: Drycker ---
            var qKaffeProducent = new QuestionModel
            {
                Question = "Vilket land är världens största producent av kaffe?",
                CategoryId = new List<CategoryModel> { catMatDryck },
                SubCategoryId = new List<SubCategoryModel> { subDrycker }
            };
            var qVinIngredienser = new QuestionModel
            {
                Question = "Av vad tillverkas vin?",
                CategoryId = new List<CategoryModel> { catMatDryck },
                SubCategoryId = new List<SubCategoryModel> { subDrycker }
            };

            // FRÅGA ↔ SVARSALTERNATIV  (IsCorrect = true på exakt ett svar/fråga)
            // Notera: samma AnswerOptionModel-instans återanvänds i flera frågor

            context.QuestionAnswerOptions.AddRange(

                // Vad är huvudstaden i Frankrike?
                new QuestionAnswerOptionModel { Question = qFrankrikesHuvudstad, AnswerOption = aParis,   IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qFrankrikesHuvudstad, AnswerOption = aLondon,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFrankrikesHuvudstad, AnswerOption = aBerlin,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFrankrikesHuvudstad, AnswerOption = aMadrid,  IsCorrect = false },

                // Vad är huvudstaden i Sverige?
                new QuestionAnswerOptionModel { Question = qSverigesHuvudstad, AnswerOption = aStockholm, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qSverigesHuvudstad, AnswerOption = aGoteborg,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qSverigesHuvudstad, AnswerOption = aMalmo,     IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qSverigesHuvudstad, AnswerOption = aUppsala,   IsCorrect = false },

                // Vilket land har flest invånare i Europa?
                new QuestionAnswerOptionModel { Question = qFlestInvanareEuropa, AnswerOption = aRyssland,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qFlestInvanareEuropa, AnswerOption = aTyskland,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFlestInvanareEuropa, AnswerOption = aFrankrike, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFlestInvanareEuropa, AnswerOption = aItalien,   IsCorrect = false },

                // Vilket är världens största land till ytan?  — aRyssland återanvänds!
                new QuestionAnswerOptionModel { Question = qStorstaLandYta, AnswerOption = aRyssland, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qStorstaLandYta, AnswerOption = aKanada,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qStorstaLandYta, AnswerOption = aUSA,      IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qStorstaLandYta, AnswerOption = aKina,     IsCorrect = false },

                // Vilket är världens längsta flod?
                new QuestionAnswerOptionModel { Question = qLangstaFlod, AnswerOption = aNilen,       IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qLangstaFlod, AnswerOption = aAmazonas,    IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qLangstaFlod, AnswerOption = aYangtze,     IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qLangstaFlod, AnswerOption = aMississippi, IsCorrect = false },

                // I vilket land låg det antika Rom?  — aItalien återanvänds!
                new QuestionAnswerOptionModel { Question = qAntikRomLand, AnswerOption = aItalien,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qAntikRomLand, AnswerOption = aGrekland, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qAntikRomLand, AnswerOption = aSpanien,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qAntikRomLand, AnswerOption = aTurkiet,  IsCorrect = false },

                // Vilket år föll Västromerska riket?
                new QuestionAnswerOptionModel { Question = qVastromerriketFall, AnswerOption = a476, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qVastromerriketFall, AnswerOption = a395, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVastromerriketFall, AnswerOption = a410, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVastromerriketFall, AnswerOption = a500, IsCorrect = false },

                // Vilket år slutade andra världskriget?
                new QuestionAnswerOptionModel { Question = qAndraVK, AnswerOption = a1945, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qAndraVK, AnswerOption = a1944, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qAndraVK, AnswerOption = a1946, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qAndraVK, AnswerOption = a1943, IsCorrect = false },

                // Vem var Sveriges kung under stora nordiska kriget?
                new QuestionAnswerOptionModel { Question = qStoraNordiskaKriget, AnswerOption = aKarlXII,       IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qStoraNordiskaKriget, AnswerOption = aGustavIIAdolf, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qStoraNordiskaKriget, AnswerOption = aKarlXI,        IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qStoraNordiskaKriget, AnswerOption = aGustavIII,     IsCorrect = false },

                // Vad är den kemiska beteckningen för vatten?
                new QuestionAnswerOptionModel { Question = qVattenFormel, AnswerOption = aH2O,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qVattenFormel, AnswerOption = aCO2,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVattenFormel, AnswerOption = aNaCl, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVattenFormel, AnswerOption = aO2,   IsCorrect = false },

                // Vilket grundämne har atomnummer 1?
                new QuestionAnswerOptionModel { Question = qAtomNummer1, AnswerOption = aVate,   IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qAtomNummer1, AnswerOption = aHelium, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qAtomNummer1, AnswerOption = aSyre,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qAtomNummer1, AnswerOption = aKol,    IsCorrect = false },

                // Ungefär hur snabbt rör sig ljus i vakuum?
                new QuestionAnswerOptionModel { Question = qLjusets, AnswerOption = a300000, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qLjusets, AnswerOption = a150000, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qLjusets, AnswerOption = a500000, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qLjusets, AnswerOption = a100000, IsCorrect = false },

                // Vem formulerade gravitationslagen?
                new QuestionAnswerOptionModel { Question = qGravitationslagen, AnswerOption = aNewton,   IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qGravitationslagen, AnswerOption = aEinstein, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGravitationslagen, AnswerOption = aGalileo,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGravitationslagen, AnswerOption = aHawking,  IsCorrect = false },

                // Hur många spelare har ett fotbollslag på planen?
                // a11 och a12 återanvänds i matematik!
                new QuestionAnswerOptionModel { Question = qFotbollsspelare, AnswerOption = a11, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qFotbollsspelare, AnswerOption = a10, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFotbollsspelare, AnswerOption = a12, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFotbollsspelare, AnswerOption = a9,  IsCorrect = false },

                // Vilket land har vunnit flest VM-guld i fotboll?
                // aBrasilien återanvänds i kaffeproducent! aTyskland + aItalien återanvänds!
                new QuestionAnswerOptionModel { Question = qVMGuldFotboll, AnswerOption = aBrasilien, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qVMGuldFotboll, AnswerOption = aTyskland,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVMGuldFotboll, AnswerOption = aItalien,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVMGuldFotboll, AnswerOption = aArgentina, IsCorrect = false },

                // Var hölls de första moderna olympiska spelen?
                // aParis, aLondon, aRom återanvänds!
                new QuestionAnswerOptionModel { Question = qForstaModernaOS, AnswerOption = aAthen,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qForstaModernaOS, AnswerOption = aParis,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qForstaModernaOS, AnswerOption = aLondon, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qForstaModernaOS, AnswerOption = aRom,    IsCorrect = false },

                // Vart hur många år hålls de olympiska sommarspelen?
                // a4 återanvänds i gitarr/insekt!
                new QuestionAnswerOptionModel { Question = qOSVartHurvangaar, AnswerOption = a4, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qOSVartHurvangaar, AnswerOption = a2, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qOSVartHurvangaar, AnswerOption = a3, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qOSVartHurvangaar, AnswerOption = a5, IsCorrect = false },

                // Vem komponerade "Für Elise"?
                new QuestionAnswerOptionModel { Question = qFurElise, AnswerOption = aBeethoven, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qFurElise, AnswerOption = aMozart,    IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFurElise, AnswerOption = aBach,      IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFurElise, AnswerOption = aChopin,    IsCorrect = false },

                // Hur många strängar har en standardgitarr?
                // a6 återanvänds i hexagon + insektben!
                new QuestionAnswerOptionModel { Question = qGitarrStrangar, AnswerOption = a6, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qGitarrStrangar, AnswerOption = a4, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGitarrStrangar, AnswerOption = a5, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGitarrStrangar, AnswerOption = a8, IsCorrect = false },

                // Vilket band sjöng "Bohemian Rhapsody"?
                new QuestionAnswerOptionModel { Question = qBohemianRhapsody, AnswerOption = aQueen,         IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qBohemianRhapsody, AnswerOption = aBeatles,       IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qBohemianRhapsody, AnswerOption = aLedZeppelin,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qBohemianRhapsody, AnswerOption = aRollingStones, IsCorrect = false },

                // Vilket år bildades ABBA?
                new QuestionAnswerOptionModel { Question = qABBA, AnswerOption = a1972, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qABBA, AnswerOption = a1969, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qABBA, AnswerOption = a1975, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qABBA, AnswerOption = a1970, IsCorrect = false },

                // Vem spelar Iron Man i MCU?
                new QuestionAnswerOptionModel { Question = qIronMan, AnswerOption = aRDJ,            IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qIronMan, AnswerOption = aChrisEvans,     IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qIronMan, AnswerOption = aChrisHemsworth, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qIronMan, AnswerOption = aMarkRuffalo,    IsCorrect = false },

                // Vilket år hade Titanic premiär?
                new QuestionAnswerOptionModel { Question = qTitanicAr, AnswerOption = a1997, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qTitanicAr, AnswerOption = a1995, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qTitanicAr, AnswerOption = a1999, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qTitanicAr, AnswerOption = a2001, IsCorrect = false },

                // Vilket land producerade "Spirited Away"?  — aJapan återanvänds i sushi!
                new QuestionAnswerOptionModel { Question = qSpiritedAway, AnswerOption = aJapan,    IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qSpiritedAway, AnswerOption = aUSA,      IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qSpiritedAway, AnswerOption = aSydkorea, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qSpiritedAway, AnswerOption = aKina,     IsCorrect = false },

                // Vilket studio skapade "Lejonkungen"?
                new QuestionAnswerOptionModel { Question = qLejonkungen, AnswerOption = aDisney,     IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qLejonkungen, AnswerOption = aPixar,      IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qLejonkungen, AnswerOption = aDreamWorks, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qLejonkungen, AnswerOption = aWarnerBros, IsCorrect = false },

                // Vad är kvadratroten ur 144?  — a12 och a11 återanvänds från fotboll!
                new QuestionAnswerOptionModel { Question = qKvadratrot144, AnswerOption = a12, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qKvadratrot144, AnswerOption = a14, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qKvadratrot144, AnswerOption = a11, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qKvadratrot144, AnswerOption = a13, IsCorrect = false },

                // Hur många sidor har en hexagon?  — a6 återanvänds i gitarr + insekt!
                new QuestionAnswerOptionModel { Question = qHexagonSidor, AnswerOption = a6, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qHexagonSidor, AnswerOption = a5, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qHexagonSidor, AnswerOption = a7, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qHexagonSidor, AnswerOption = a8, IsCorrect = false },

                // Hur många grader är en rät vinkel?
                new QuestionAnswerOptionModel { Question = qRatVinkel, AnswerOption = a90,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qRatVinkel, AnswerOption = a45,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qRatVinkel, AnswerOption = a180, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qRatVinkel, AnswerOption = a60,  IsCorrect = false },

                // Vad är pi avrundat till 2 decimaler?
                new QuestionAnswerOptionModel { Question = qPi, AnswerOption = aPi314, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qPi, AnswerOption = aPi312, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qPi, AnswerOption = aPi316, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qPi, AnswerOption = aPi318, IsCorrect = false },

                // Vilket är världens största landlevande djur?
                new QuestionAnswerOptionModel { Question = qStorstaLanddjur, AnswerOption = aElefant,   IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qStorstaLanddjur, AnswerOption = aNoshorn,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qStorstaLanddjur, AnswerOption = aFlodhaest, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qStorstaLanddjur, AnswerOption = aGiraff,    IsCorrect = false },

                // Hur många ben har en insekt?  — a6 återanvänds i gitarr + hexagon!
                new QuestionAnswerOptionModel { Question = qInsektBen, AnswerOption = a6,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qInsektBen, AnswerOption = a4,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qInsektBen, AnswerOption = a8,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qInsektBen, AnswerOption = a10, IsCorrect = false },

                // Vilket träd producerar ekollon?
                new QuestionAnswerOptionModel { Question = qEkollon, AnswerOption = aEk,    IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qEkollon, AnswerOption = aBjork, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qEkollon, AnswerOption = aGran,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qEkollon, AnswerOption = aTall,  IsCorrect = false },

                // Vad heter processen där växter omvandlar solljus till energi?
                new QuestionAnswerOptionModel { Question = qFotosyntes, AnswerOption = aFotosyntes,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qFotosyntes, AnswerOption = aMetabolism,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFotosyntes, AnswerOption = aOsmos,       IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qFotosyntes, AnswerOption = aRespiration, IsCorrect = false },

                // Vad står CPU för?
                new QuestionAnswerOptionModel { Question = qCPU, AnswerOption = aCpuCorrect, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qCPU, AnswerOption = aCpuWrong1,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qCPU, AnswerOption = aCpuWrong2,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qCPU, AnswerOption = aCpuWrong3,  IsCorrect = false },

                // Vilket företag skapade Windows?  — aMicrosoft/aApple/aGoogle återanvänds i Google!
                new QuestionAnswerOptionModel { Question = qWindowsSkapare, AnswerOption = aMicrosoft, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qWindowsSkapare, AnswerOption = aApple,     IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qWindowsSkapare, AnswerOption = aGoogle,    IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qWindowsSkapare, AnswerOption = aIBM,       IsCorrect = false },

                // Vad står WWW för?
                new QuestionAnswerOptionModel { Question = qWWW, AnswerOption = aWwwCorrect, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qWWW, AnswerOption = aWwwWrong1,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qWWW, AnswerOption = aWwwWrong2,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qWWW, AnswerOption = aWwwWrong3,  IsCorrect = false },

                // Vilket år grundades Google?  — a1998/a1995/a2000/a2001 återanvänds från historia/film!
                new QuestionAnswerOptionModel { Question = qGoogleGrundat, AnswerOption = a1998, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qGoogleGrundat, AnswerOption = a1995, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGoogleGrundat, AnswerOption = a2000, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGoogleGrundat, AnswerOption = a2001, IsCorrect = false },

                // Vilket land kommer sushi från?  — aJapan återanvänds från Spirited Away!
                new QuestionAnswerOptionModel { Question = qSushiUrsprung, AnswerOption = aJapan,    IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qSushiUrsprung, AnswerOption = aKina,     IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qSushiUrsprung, AnswerOption = aSydkorea, IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qSushiUrsprung, AnswerOption = aVietnam,  IsCorrect = false },

                // Vad är huvudingrediensen i guacamole?
                new QuestionAnswerOptionModel { Question = qGuacamoleIngrediens, AnswerOption = aAvokado, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qGuacamoleIngrediens, AnswerOption = aTomat,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGuacamoleIngrediens, AnswerOption = aLok,     IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qGuacamoleIngrediens, AnswerOption = aLime,    IsCorrect = false },

                // Vilket land är störst kaffeproducent?  — aBrasilien återanvänds från fotboll!
                new QuestionAnswerOptionModel { Question = qKaffeProducent, AnswerOption = aBrasilien, IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qKaffeProducent, AnswerOption = aKolombia,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qKaffeProducent, AnswerOption = aEtiopien,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qKaffeProducent, AnswerOption = aVietnam,   IsCorrect = false },

                // Av vad tillverkas vin?
                new QuestionAnswerOptionModel { Question = qVinIngredienser, AnswerOption = aDruvor,  IsCorrect = true  },
                new QuestionAnswerOptionModel { Question = qVinIngredienser, AnswerOption = aApplen,  IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVinIngredienser, AnswerOption = aParon,   IsCorrect = false },
                new QuestionAnswerOptionModel { Question = qVinIngredienser, AnswerOption = aPlommon, IsCorrect = false }
            );

            // QUIZAR

            var quizAllmanbildning = new QuizModel
            {
                Name = "Allmänbildningsquiz",
                Description = "Testa dina kunskaper inom geografi, historia, vetenskap, sport och mer!",
                Questions = new List<QuestionModel>
                {
                    qFrankrikesHuvudstad, qStorstaLandYta, qAndraVK,
                    qVattenFormel, qGravitationslagen, qFotbollsspelare,
                    qFurElise, qBohemianRhapsody, qKvadratrot144, qCPU
                }
            };

            var quizGeografi = new QuizModel
            {
                Name = "Geografiquiz",
                Description = "Hur bra kan du din geografi?",
                Questions = new List<QuestionModel>
                {
                    qFrankrikesHuvudstad, qSverigesHuvudstad,
                    qFlestInvanareEuropa, qStorstaLandYta, qLangstaFlod
                }
            };

            var quizHistoria = new QuizModel
            {
                Name = "Historiaquiz",
                Description = "Testa dina historiekunskaper!",
                Questions = new List<QuestionModel>
                {
                    qAntikRomLand, qVastromerriketFall,
                    qAndraVK, qStoraNordiskaKriget
                }
            };

            var quizVetenskap = new QuizModel
            {
                Name = "Vetenskapsquiz",
                Description = "Kemi, fysik och naturvetenskap!",
                Questions = new List<QuestionModel>
                {
                    qVattenFormel, qAtomNummer1,
                    qLjusets, qGravitationslagen, qFotosyntes
                }
            };

            context.Quizzes.AddRange(quizAllmanbildning, quizGeografi, quizHistoria, quizVetenskap);

            await context.SaveChangesAsync();
        }
    }
}

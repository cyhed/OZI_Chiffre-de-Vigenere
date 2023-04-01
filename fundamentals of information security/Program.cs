using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace fundamentals_of_information_security
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string RuAlphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            string EnAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string Numbers = "0123456789";
            string SpecSymbol = " ,.-!?";

            string CryptionMessage = "ИДОМЩНТЗ_УТЕИУТДДЛЙПИЙБЧМУЕПБПТЙВТНЯЙФ_ХРСЦВВПЗНМЗ_ЫКСЙН_УРЗЖРЛВЗТГУОЛЖАЖВТ_БКДНЬОХЛВФОФЭ_УРЛ_ЙУВУЬГСРЙКМЧЫЕХФВДОИГЯЛЙМТФКЧЙУКМЧ_ЪЗПЙЛ_МОЕСПОГФАОБИГСОХФУУКЛДБВТБВФЗМВБВЦРРТЛ_РКРТДОНБВТЛНЯБГФХПУВ_РВТЙОАЦККТД_УТИГСЕСУИПЮВДПСОРМГХНМДЕФУИЦЗТЙБВТЙГПВnВПАЕРВЯГЖЖГСРЙУПЙТОРБЭОМЕФФОРБИГЖЖТПОРБМТХЧПК_СВЧДД_ФВЗФВБТФКЧ\r\nБЭПЗКЦТОСПОЖЭЧМУЛМФЕПЮНТЛ_РВШМПЫГЯЛЙМТФРНСЭЙГЩИХНОЖРЙГКНЦЗГФВТТТ_МБКДНЬОХЛВФОФБПЙТЕИБУЫЗНЯОИГСОХФАЖКЛМБЦЙНЬГХСОРРМФЬГТАХЩЕЦЭ_ЦВБПКЦГЖЛВБНДДЕИЗНМА_ДТТМНЛЙТИМБЭСКАОББТНЬЬЗ_УРХТЖИПБНДБЭПЗКЦТОСПЫНБКДНЬОХЛВФОФБЧЙО_СВ_ОРМУЮЮЦЗРГПОГЖВТКЧСЭЕГЩИХНАГСРЙЖСЦВВПАЛМБУКЗ_СЗ_УТИРКТМДНЯОИГМОПЗСММАРК_ОВКГД_ДТИШООРЗТФВХГВ_АНЕОФРТПНЯОИГНАРСАРК_УЗРЙМЛБЩАЦЗЛВОИГУОПЖАЦЭ_УТИУКСДПНЯЗ_ОБЭЦРЙГРГФРМСРЙГОАЬКНЙБПТУТТАНСР_СРСМНИХЮ_ЖРКФХГГПЕЙБСОТИУА_ЦЗЛЙИКДОИГЖОЖЗРЩХ_СВБМФЫРК_АНЕОФРТПНЯОИГНАРСАРК_ХФОМНОГСЕФЗГТТЕЦЮ_ЩРТВББЯБОИПОНБЛДОПЙБКДМ_АПИДМ_ЦХТГИЕГДСЦВВДН_МБНДЩИСВЛДУЬГУУРВТТЧАГДСЙБСУЗШСР_МУКДНИГУГТТЕЖЪУББЛДОПЧБОИПОНБИЛБПФКЧМП_ЖРЗРРЖСР_МБНЙБСПКШОРМГЖОХФОЖЗРСРЙГУТТНЬГЩАХФОНБЗДОЕСЭ_ПВМУБСЫКТДНАХЮ_ЦВКДА_МЧ_ЦЗППР_МБСЖЗЧЙПИЙБПФКВПЗКД_ТГООЦЭЛ_МОЖБКТФОФЭЕГЙАПЗТД_ТГДНЧФР_БМДЪИСЭ_МБВЯЙЫЖВЮЦБКТТОЦМОЙБЗДОЫОВНМЗ_ЙУЛМБЭЦР_УТАЖЖАГФОГФЕФОИСБЖЧЩКМБПТЖ_ОРТТТЫРБИРЗЮЦУЯГД_ЖКДЧБОЬКБОК_ЖБПФРГФВМРПЫЩБИГВПУВРДФНЯЧ_ХТЕИУТЖВХГМОРСЬБФЕФРВГСРМРБФЗТДЗТГПОЖЭЙГУМЯУЛГМОЗЖАГДСЙБЛДОПЯБРДГОЦВЛМБИСИЕСЗРСЭЙГСЕФУОСВЛГООЗБНДУТФРИЦЮ_АПИДМ_СВ_ОВКЧ_НМГУИЮ_ЛВДДЩУГДРЧЩНЧ__МЙМЙПИЖБПТЖКП_ЧЙПИВБШЙУТ_БТЯУЯЫБПФРВТЖОЖБВХЗ_АФИГСРТДОИВ_УТИЩРДМНОХЮ_ЖПОЖЮ_УЗРЙМЛБЩАЦЮ_ОРГИВ_ЖУТДДАПВ_ИТУЗВЯГЙАИВЧДБВГТЕЬЗНМК_АФОНБПФРБПЗМЯБОХПОЖПУББЗДУЛЧЕУГСРМСИХЭВД_ТГЖЖТПУГЦОСБНЙЛМДПУГВМЙТИОВНЪХ_ЖЗНЗЗРХМОЗР_УТОМУХТИДЙПИВББПЗСЦАЩЙОУГХЧЙПОРХ_МЙВЙУТСРМЧБМСРГМОИГЖОХФИКЗНМАММБОЦБРДЙРДГОЦМИГФЕТТИМБИЗТ_ИР_ЖМЛДЖАГД_ХРЗИВНМЗ_ВЖЕФПОЗР_ТТУККЯГРНГСРМЖУРВЛГУХЙОУГМОЦРРТЛ_ИР_ХКХГСОФБСПЗДЧ_ТГДСЙБЦМЦРТДЫЙБКТОП__ТЙТЫГВРЩКТЙМТЧТАГЦОСБНЙЛМДПАГМАОБЕЙБТЙСЕФЮ_СВЗЯДАБФ_ЕВЗМТУЙФСВБНДБПФКНЪКПДЧ_ХЦОФОУПКРТДАСПЫЩБИРБВГКХГЩИХНОГДХТЖИЦБИГФАОРЙГД_ОРМУЮЮЦЗРЙБНЙБПФКДЙФСВБИЛОЕСАТ_БПТЖКП_ЧЙПИВБПФРВТЖОЖБЕХНИГДСЙБИСУТФХКЪКИГГУИХТГЧРДПИЦЮСВБВГЗГТБПДОЯЦК_МБКДМ_ЦРЛ_МОГЯТЧБИИЗЮГДОУНОЦКЛМБНДБПФВКЦККЙБРТЖИПУЯГУОЖТЕРЗНСЭЙГМОРСЬБФЕФБ";
            string CryptionMessage2 = "влцдутжбюцхъяррмшбрхцэооэцгбрьцмйфктъъюьмшэсяцпунуящэйтаьэдкцибр\r\nьцгбрпачкъуцпъбьсэгкцъгуущарцёэвърюуоюэкааэбрняфукабъарпяъафкъиьжяффнйо\r\nяфывбнэнфуюгбрьсшьжэтбэёчюъюръегофкбьчябашвёэуъъюаднчжчужцёэвлрнчулб\r\nюпцуруньъшсэюъзкцхъяррнрювяспэмасчкпэужьжыатуфуярюравртубурьпэщлафоуф\r\nбюацмнубсюкйтаьэдйюнооэгюожбгкбрънцэпотчмёодзцвбцшщвщепчдчдръюьскасэг\r\nъппэгюкдойрсрэвоопчщшоказръббнэугнялёкьсрбёуыэбдэулбюасшоуэтъшкрсдугэфл\r\nбубуъчнчтртпэгюкиугюэмэгюккъъпэгяапуфуэзьрадзьжчюрмфцхраююанчёчюъыхьъ\r\nцомэфъцпоирькнщпэтэузуябащущбаыэйчдфрпэцъьрьцъцпоилуфэдцойэдятррачкубу\r\nфнйтаьэдкцкрннцюабугюуубурьпйюэъжтгюркующоъуфъэгясуоичщщчдцсфырэдщэ\r\nъуяфшёчцюйрщвяхвмкршрпгюопэуцчйтаьэдкцибрьцыяжтюрбуэтэбдуящэубъибрюв\r\nъежагибрбагбрымпуноцшяжцечкфодщоъчжшйуъцхчщвуэбдлдъэгясуахзцэбдэулькнъ\r\nщбжяцэьрёдъьвювлрнуяфуоухфекьгцчччгэъжтанопчынажпачкъуъмэнкйрэфщэъьбуд\r\nэндадъярьеюэлэтчоубъцэфэвлнёэгфдсэвэёкбсчоукгаутэыпуббцчкпэгючсаъбэнэфърк\r\nацхёваетуфяепьрювържадфёжбьфутощоявьъгупчршуитеачйчирамчюфчоуяюонкяжы\r\nкгсцбрясшчйотъъжрсщчл";
            CryptionMessage2 = "члгф миёзьиыа рсацщис лц ущскзттмасзъашорхч спсйсъахиф ычшыоб щулкрю ф ядтлзъьячи жроыпнзвым ьдблсд.\r\nолю коьуфпсрямамлн рщждхчхъокяцтмасяаг эааочъкак чоёутне,ьдтыбгуркя tabularectaзочомагуоц(эааочък)взйуспря.\r\nтямчемлбицьмсщфюсрнэрюакчоёуттхоецихгрмсемзядьорхоёцядхаг уз рхятх пн 33 фчрмокср, уыициы окжггн хцегцмэкя рхятха ржрмнадхаг ша мзаощлынэ ущззщчн.\r\nэайлы тлрякэр, м тядъмбе осъчвадхаг 33 ыажочышыф ычшыоб щулкрю. ро окжгсы бэаоз жмярнеосуя зфютцьжцмцья пгцпучмюу дцфяечцё, въдчфкелюу ё табламчорхч тэ сзпртца йомыпвнёэ хцобг.";
            //Chiffre_De_Vigenere.Decryption(3, CryptionMessage, RuAlphabet + "_");
            Console.WriteLine(Chiffre_De_Vigenere.Decryption("ягодка", CryptionMessage2, RuAlphabet ));

            Chiffre_De_Vigenere.Decryption(3, CryptionMessage, RuAlphabet+"_");
            Console.WriteLine(Chiffre_De_Vigenere.Decryption("два", CryptionMessage, RuAlphabet + "_")  ); 
        }    
       
    }
    internal class Chiffre_De_Vigenere
    {
        //кодирует по виженеру,получая ключ, сообщение и алфавит, если символ-сообщения не кодируется то символ ключа сгорает
        public static string Encryption(string key, string message, string alphabet)
        {

            message = message.ToLower();
            string[] Table = new string[alphabet.Length];
            Table = FillingTable(alphabet.ToLower());
            

            StringBuilder EncryptionMessage = new StringBuilder(message);
            int indexOfSymbolMessage;
            int indexOfSymbolKey;

            int keyIteration = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (0 <= Table[0].IndexOf(message[i]))
                {
                    
                    // для того чтобы ключ не сгорал надо отвязать ключ от обшей итерации(i), для этого создается отдельная переменная-итераций 
                    // и она увеличевается только тогда когда симфвол есть в алфавите
                    indexOfSymbolKey = Table[0].IndexOf(key[keyIteration % (key.Length)]);
                    keyIteration++;

                    indexOfSymbolMessage = Table[0].IndexOf(message[i]);                 

                    EncryptionMessage[i] = Table[indexOfSymbolKey][indexOfSymbolMessage];
                }
            }

            return EncryptionMessage.ToString();
        }
        //декодирует по виженеру, получая ключ, сообщение и алфавит
        public static string Decryption(string key, string message, string alphabet)         
        {
            
            message = message.ToLower();
            string[] Table = new string[alphabet.Length];
            Table = FillingTable(alphabet.ToLower());


            StringBuilder DecryptionMessage = new StringBuilder(message);
            int indexOfSymbolMessage;
            int indexOfSymbolKey;

            int keyIteration = 0;
            for (int i = 0;i< message.Length;i++)
            {
                if (0 <= Table[0].IndexOf(message[i]))
                {
                    indexOfSymbolKey = Table[0].IndexOf(key[keyIteration % (key.Length)]);
                    keyIteration++;

                    indexOfSymbolMessage = Table[indexOfSymbolKey].IndexOf(message[i]);

                    DecryptionMessage[i] = Table[0][indexOfSymbolMessage];
                }                
            }
            return DecryptionMessage.ToString();
        }
        //декодирует получая длину ключа ,сооющение, алфавит
        //декодирует посредством анализа
        public static void Decryption(int keyLength, string CryptionMessage, string alphabet)
        {
            //получает ключ сдвиг
            int[][] KeysAsOffset = Chiffre_De_Vigenere.CreateKeysAsOffset(CryptionMessage, keyLength, alphabet);

            //рисует гистограмы частоты появления символов по группам
            for (int i = 0; i < keyLength; i++)
            {
                Chiffre_De_Vigenere.DrawHistogram(CryptionMessage, i, keyLength, alphabet);
                Console.WriteLine(alphabet + i);
            }
            //пишет ключ сдвиг
            foreach (var KeyAsOffset in KeysAsOffset)
            {
                foreach (var item in KeyAsOffset)
                {
                    Console.WriteLine(item);
                }
            }

            //в ключ сдвиг подставляет все буквы алфавита поочередно
            string[] Keys = Chiffre_De_Vigenere.KeySelection(KeysAsOffset, alphabet);
            foreach (var i in Keys)
            {
                Console.Write(i + "   ");
                string Message = Chiffre_De_Vigenere.Decryption(i, CryptionMessage, alphabet);
                Console.WriteLine(Message.Substring(0, 50));


            }

        }

        public static void DrawHistogram(string message, int keyLength, int firstElementNumber, string alphabet)
        {

            int[] SymbolFrequency = SymbolFrequencyAnalysis(message, keyLength, firstElementNumber, alphabet);
            float[] CharacterPercentage = NumberOfMeetingsAsPercentage(SymbolFrequency);
            int[] CharacterPercentageInt = new int[SymbolFrequency.Count()];

            for (int i = 0; i < CharacterPercentage.Count(); i++)
            {
                CharacterPercentageInt[i] = Convert.ToInt32(CharacterPercentage[i]);
            }

            for (int i = 0; i < SymbolFrequency.Count(); i++)
            {
                Console.Write($"{SymbolFrequency[i]} - {alphabet[i]}  ");
            }
            Console.WriteLine( );
            Console.WriteLine(Draw(CharacterPercentageInt));
            //Console.WriteLine(  );
            
        }

        // считывает максивум в каждой группе и возвращает сдвиги относительно первого макчимума группы-символключа
        //Возвлащает только один ключ-сдвиг, хотя максимумов может быть несколько в одной группе или они могут близко равны        
        //Необходимо дописать функцию ,чтобы она находиила все возможные ключи-сдвиг, т.е. все возможные комбинации
        public static int[][] CreateKeysAsOffset(string message, int keyLength, string alphabet)
        {
            int[][] KeysAsOffset= new int[1][];
            int[] SymbolFrequency;
            int Offset;
            int FirstOffset = 0;
            
            int[] KeyAsOffset = new int[keyLength];
            Console.WriteLine(  "smbol");
            for (int i = 0; i < keyLength; i++)
            {
                
                SymbolFrequency = SymbolFrequencyAnalysis(message,keyLength,i,alphabet);

                Offset = Array.IndexOf(SymbolFrequency, SymbolFrequency.Max());
                Console.WriteLine(Offset);
                if (i == 0) 
                    FirstOffset = Offset;
                KeyAsOffset[i] = Offset - FirstOffset;
            }
            KeysAsOffset[0] = KeyAsOffset;
            return KeysAsOffset;
        }
        //возвращает переборку всех ключей по сдвиг-ключам
        public static string[] KeySelection(int[][] KeysAsOffset, string alphabet)
        {
            
            string[] Keys = new string[KeysAsOffset.GetLength(0)* alphabet.Count()];// создаём массив ключей равный количеству сдвиг-ключей умножинное на кол-во символов алфавита
            
            // берем каждый сдвиг-ключ
            foreach (var KeyAsOffset in KeysAsOffset)
            {
                //каждый сдвиг ключ начинаем с каждой буквой алфавита
                for (int i = 0; i < alphabet.Count(); i++) 
                {
                    
                    //создается массив ключа
                    char[] Key = new char[KeyAsOffset.Count()];
                    for (int j = 0; j < KeyAsOffset.Count(); j++)
                    {

                        //заполняется ключ относительно буквы алфавите
                        int NumberSymbol= i + KeyAsOffset[j];
                        int LengthAlphabet = alphabet.Count();
                        Console.Write(NumberSymbol +" " + LengthAlphabet +"=");

                        if (NumberSymbol < 0)
                            NumberSymbol = LengthAlphabet + NumberSymbol;

                        if (NumberSymbol >= LengthAlphabet)
                            NumberSymbol = NumberSymbol - LengthAlphabet;

                        
                        Console.WriteLine(NumberSymbol);
                        Key[j] = alphabet[NumberSymbol];
                    }
                    Keys[i] = new String(Key);
                }

            }               
            return Keys;
        }
        /*public static float MatchIndex(int[])
        {
            float Index=0;

            return Index;
        }*/


        //заполнение таблицы виженера аофавитом
        private static string[] FillingTable(string Alphabet)
        {
            string TempTableSymbols = Alphabet;
            string[] Table = new string[Alphabet.Length];

            for (int i = 0; i < Alphabet.LongCount(); i++)
            {
                Table[i] = TempTableSymbols;
                TempTableSymbols = SingleLeftShift(TempTableSymbols);
            }
            return Table;
        }
        //сдвигание строки на символ влево
        private static string SingleLeftShift(string array)
        {
            StringBuilder TempArray = new StringBuilder(array);
            
            for(int i = 0; i< array.Length - 1;i++)
            { 
                TempArray[i] = array[i + 1];
                
            }
            TempArray[array.Length - 1]= array[0];
            return TempArray.ToString();
        }
        //Количество появления символа в сообщении , если он есть в алффавите
        private static int[] SymbolFrequencyAnalysis(string message, int keyLength, int firstElementNumber, string Alphabet)
        {
            if (keyLength == 0) { keyLength = 1; }
            message = message.ToLower();
            int[] SymbolFrequency = new int[Alphabet.Count()];
            for (int i = firstElementNumber; i < message.Count();)
            {
                int IndexOfMessage = Alphabet.IndexOf(message[i]);
                if (0 <= IndexOfMessage)
                {
                    SymbolFrequency[IndexOfMessage]++;
                }
                i += keyLength;
            }
            return SymbolFrequency;
        }
        //частота появления в процентах
        private static float[] NumberOfMeetingsAsPercentage(int[] SymbolFrequency)
        {
            float[] CharacterPercentage = new float[SymbolFrequency.Length];
            int Sum = SymbolFrequency.Sum();
            for (int i = 0; i < SymbolFrequency.Length; i++)
            {
                CharacterPercentage[i] = SymbolFrequency[i] * 100f / Sum;
            }            
            return CharacterPercentage;
        }
        //рисует столбцы высотой указанной в ячейках 
        private static string Draw(int[] waves)
        {
            char c1 = '■', c2 = '.';
            string strWaves = "";
            int max = waves.Max();
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < waves.Length; j++)
                {
                    if (waves[j] >= max - i)
                        strWaves += c1;
                    else
                        strWaves += c2;
                }
                if (i < max - 1)
                    strWaves += '\n';
            }

            return strWaves;
        }
    }
}

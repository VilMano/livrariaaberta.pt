using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AbertaAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CoverPicture",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverPicture", "Isbn", "Language", "Price", "Publisher", "ReleaseDate", "Stock", "Synopsis", "Title" },
                values: new object[,]
                {
                    { "972370806X", "Sandro Penna", "", "972370806X", "Português", 15.5f, "Assírio & Alvim", "2003-01-01", 1, "", "No brando rumor da vida" },
                    { "9727951783", "Samuel Rawet", "", "9727951783", "Português", 7.5f, "Cotovia", "2006-01-01", 0, "", "Que os mortos enterrem seus mortos (Usado)" },
                    { "9728423187", "Bernard-Marie Koltès", "", "9728423187", "Português", 10f, "Cotovia", "1999-01-01", 1, "", "Combate de negro e de cães" },
                    { "9728423829", "William Shakespeare", "", "9728423829", "Português", 5f, "Cotovia", "2000-01-01", 1, "", "Cimbelino (Usado)" },
                    { "9729013209", "Rainer Werner Fassbinder", "", "9729013209", "Português", 7.5f, "Cotovia", "1999-01-01", 0, "", "As lágrimas amargas de Petra von Kant (Usado)" },
                    { "9729013756", "E. M. Forster", "", "9729013756", "Português", 10f, "Cotovia", "1992-01-01", 1, "", "Pharos & Pharillon: Uma evocação de Alexandria" },
                    { "9780006540441", "Quentin Crisp", "", "9780006540441", "inglês", 14.5f, "Flamingo", "1985", 1, "", "The Naked Civil Servant" },
                    { "9780007205011", "", "https://covers.openlibrary.org/b/isbn/9780007205011-L.jpg", "9780007205011", "", 14.5f, "HarperCollins Publishers", "2006", 0, "", "The Female Eunuch" },
                    { "9780007292363", "Quentin Crisp", "", "9780007292363", "inglês", 13.25f, "HarperCollins Publishers Limited", "2008", 0, "", "How to Become a Virgin" },
                    { "9780008244125", "", "https://covers.openlibrary.org/b/isbn/9780008244125-L.jpg", "9780008244125", "", 12.35f, "Harper Collins", "2020", 0, "", "Loveless" },
                    { "9780008553807", "Jeffrey Eugenides", "", "9780008553807", "inglês", 15f, "HarperCollins Publishers Limited", "2022", 1, "", "Middlesex" },
                    { "9780008637569", "Michael Cunningham", "", "9780008637569", "inglês", 16.75f, "HarperCollins Publishers Limited", "2023", 1, "", "Day" },
                    { "9780022410213", "", "", "9780022410213", "", 14.5f, "", "", 1, "", "Physical" },
                    { "9780060959470", "Bell Hooks", "https://covers.openlibrary.org/b/isbn/9780060959470-L.jpg", "9780060959470", "inglês", 20f, "Harper Paperbacks", "January 9, 2001", 2, "", "All About Love: New Visions" },
                    { "9780061715440", "Dennis Cooper", "", "9780061715440", "inglês", 19f, "Harper Perennial", "2009", 0, "", "Ugly Man" },
                    { "9780061715617", "Dennis Cooper", "", "9780061715617", "inglês", 21.25f, "Harper Perennial", "2010", 1, "", "Smothered in Hugs: Essays, Interviews, Feedback, and Obituaries" },
                    { "9780061715631", "Dennis Cooper", "", "9780061715631", "inglês", 21.25f, "Harper Perennial", "2011", 1, "", "The Marbled Swarm" },
                    { "9780062985491", "Muriel Rukeyser", "https://covers.openlibrary.org/b/isbn/9780062985491-L.jpg", "9780062985491", "", 18.75f, "Ecco", "Jun 08, 2021", 0, "", "The Essential Muriel Rukeyser" },
                    { "9780063159563", "David Santos Donaldson", "https://covers.openlibrary.org/b/isbn/9780063159563-L.jpg", "9780063159563", "inglês", 16.5f, "HarperCollins Publishers", "2022", 1, "", "Greenland" },
                    { "9780099222910", "Derek Jarman", "", "9780099222910", "inglês", 14.45f, "Vintage, The Overlook Press", "1993", 1, "", "At Your Own Risk" },
                    { "9780099288719", "", "", "9780099288719", "", 23.7f, "", "", 1, "", "Time Travel: From the Sex Pistols to Nirvana: Pop, Media and Sexuality, 1977-96" },
                    { "9780099388616", "Angela Carter", "https://covers.openlibrary.org/b/isbn/9780099388616-L.jpg", "9780099388616", "inglês", 15.2f, "Vintage U. K., Random House, Vintage", "1994", 1, "", "Nights at the Circus" },
                    { "9780099422471", "Sidonie-Gabrielle Colette", "", "9780099422471", "inglês", 14.25f, "Penguin Random House", "2001", 0, "", "Claudine at School" },
                    { "9780099474913", "Derek Jarman", "", "9780099474913", "inglês", 14.95f, "Vintage, VINTAGE", "1995", 1, "", "Chroma" },
                    { "9780099485162", "Wendy Jones", "https://covers.openlibrary.org/b/isbn/9780099485162-L.jpg", "9780099485162", "inglês", 14.5f, "Vintage Books", "January 23, 2007", 0, "", "Portrait of the Artist as a Young Girl" },
                    { "9780099511885", "Dorothy Strachey", "", "9780099511885", "inglês", 11.95f, "Penguin Random House", "2008", 0, "", "Olivia" },
                    { "9780099561071", "Christopher Isherwood", "https://covers.openlibrary.org/b/isbn/9780099561071-L.jpg", "9780099561071", "", 15f, "VINTAGE, Vintage Classic", "Nov 01, 2012", 1, "", "Christopher and His Kind" },
                    { "9780099593379", "Lauren Elkin", "https://covers.openlibrary.org/b/isbn/9780099593379-L.jpg", "9780099593379", "", 14.35f, "Vintage, Vintage Books", "Sep 26, 2017", 1, "", "Flanêuse: Women Walk the City" },
                    { "9780099598176", "Jeanette Winterson", "", "9780099598176", "inglês", 15.2f, "Penguin Random House", "2014", 1, "", "Sexing the Cherry" },
                    { "9780099598275", "", "", "9780099598275", "inglês", 15.2f, "Penguin Random House", "2014", 1, "", "Written on the Body" },
                    { "9780099757719", "Christos Tsiolkas", "", "9780099757719", "inglês", 11.6f, "Penguin Random House", "1997", 0, "", "Loaded" },
                    { "9780140182750", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780140182750-L.jpg", "9780140182750", "", 13.5f, "Penguin Books Ltd", "January 25, 1990", 1, "", "The Fire Next Time" },
                    { "9780140184471", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780140184471-L.jpg", "9780140184471", "", 16.5f, "Penguin Books Ltd", "August 29, 1991", 1, "", "Nobody Knows My Name: More Notes of a Native Son" },
                    { "9780140184495", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780140184495-L.jpg", "9780140184495", "", 19.25f, "Penguin Classics", "July 25, 1991", 1, "", "Going to Meet the Man" },
                    { "9780140185850", "Евгений Иванович Замятин", "", "9780140185850", "inglês", 15f, "Penguin Books", "1993", 0, "", "We" },
                    { "9780140187977", "James Baldwin", "", "9780140187977", "inglês", 13.05f, "Penguin", "1994", 1, "", "If Beale Street Could Talk" },
                    { "9780140187991", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780140187991-L.jpg", "9780140187991", "", 16.8f, "Penguin Books Ltd", "October 27, 1994", 1, "", "Just Above My Head" },
                    { "9780140240801", "David B. Feinberg", "https://covers.openlibrary.org/b/isbn/9780140240801-L.jpg", "9780140240801", "inglês", 17.75f, "Penguin (Non-Classics)", "November 1, 1995", 0, "", "Queer and Loathing: Rants and Raves of a Raging AIDS Clone" },
                    { "9780140424515", "Walt Whitman", "https://covers.openlibrary.org/b/isbn/9780140424515-L.jpg", "9780140424515", "inglês", 25.45f, "Penguin Classics", "March 29, 2005", 1, "", "Leaves of Grass: The Complete Poems" },
                    { "9780140424744", "A. E. Housman", "", "9780140424744", "inglês", 13.05f, "Penguin Books, Limited", "2010", 1, "", "A Shropshire Lad and Other Poems" },
                    { "9780140432510", "Margery Kempe", "", "9780140432510", "inglês", 14.75f, "Penguin, Viking Penguin", "1985", 0, "", "The Book of Margery Kempe" },
                    { "9780140433722", "Margaret Cavendish, Duchess of Newcastle", "https://covers.openlibrary.org/b/isbn/9780140433722-L.jpg", "9780140433722", "inglês", 14.5f, "Penguin Classics", "October 1, 1994", 2, "", "The Blazing World and Other Writings" },
                    { "9780140445626", "Bartolomé de las Casas", "", "9780140445626", "inglês", 13.5f, "Penguin Books", "1992", 1, "", "A Short Account of the Destruction of the Indies" },
                    { "9780140446746", "Vincent van Gogh", "", "9780140446746", "inglês", 18.75f, "Penguin Books", "1997", 1, "", "The Letters of Vincent van Gogh" },
                    { "9780140447637", "Joris-Karl Huysmans", "https://covers.openlibrary.org/b/isbn/9780140447637-L.jpg", "9780140447637", "inglês", 14.5f, "Penguin Classics", "February 24, 2004", 0, "", "Against Nature (A Rebours)" },
                    { "9780140448061", "Sei Shōnagon", "https://covers.openlibrary.org/b/isbn/9780140448061-L.jpg", "9780140448061", "", 15.9f, "Penguin Classics", "October 30, 2007", 0, "", "The Pillow Book" },
                    { "9780141012377", "Susan Sontag", "", "9780141012377", "inglês", 13.95f, "Penguin Books, Limited", "2005", 0, "", "Regarding the Pain of Others" },
                    { "9780141022109", "Richard Sennett", "https://covers.openlibrary.org/b/isbn/9780141022109-L.jpg", "9780141022109", "inglês", 14.5f, "Penguin", "Aug 01, 2013", 0, "", "Together: The Rituals, Pleasures & Politics of Cooperation" },
                    { "9780141022116", "Richard Sennett", "", "9780141022116", "inglês", 17.1f, "Penguin Books, Limited", "2019", 0, "", "Building and Dwelling: Ethics for the City" },
                    { "9780141031682", "Susan Sontag", "", "9780141031682", "inglês", 18.8f, "Penguin Books, Limited", "2008", 0, "", "At the Same Time" },
                    { "9780141035789", "Susan Sontag", "", "9780141035789", "inglês", 16.5f, "Penguin Books, Limited", "2009", 0, "", "On Photography" },
                    { "9780141035826", "Marshall McLuhan", "https://covers.openlibrary.org/b/isbn/9780141035826-L.jpg", "9780141035826", "inglês", 13.5f, "Penguin", "1967", 0, "", "The Medium is the Massage" },
                    { "9780141045191", "Susan Sontag", "", "9780141045191", "inglês", 14.5f, "Penguin Books, Limited", "2009", 1, "", "Reborn: Diaries 1947-1963" },
                    { "9780141182209", "Paul Bowles", "https://covers.openlibrary.org/b/isbn/9780141182209-L.jpg", "9780141182209", "", 14.75f, "Penguin Books Ltd", "April 6, 2000", 1, "", "Let It Come Down" },
                    { "9780141182575", "Truman Capote", "https://covers.openlibrary.org/b/isbn/9780141182575-L.jpg", "9780141182575", "", 13.95f, "Penguin Books Ltd", "February 3, 2000", 0, "", "In Cold Blood" },
                    { "9780141182797", "Truman Capote", "https://covers.openlibrary.org/b/isbn/9780141182797-L.jpg", "9780141182797", "", 12.4f, "Penguin Classics", "April 27, 2000", 0, "", "Breakfast at Tiffany's" },
                    { "9780141182841", "Anaïs Nin", "https://covers.openlibrary.org/b/isbn/9780141182841-L.jpg", "9780141182841", "", 15f, "Penguin Classics", "March 30, 2000", 0, "", "Delta of Venus" },
                    { "9780141183282", "Anaïs Nin", "https://covers.openlibrary.org/b/isbn/9780141183282-L.jpg", "9780141183282", "", 14.35f, "Penguin Books Ltd", "October 25, 2001", 0, "", "Henry and June" },
                    { "9780141183404", "Anaïs Nin", "", "9780141183404", "inglês", 13.05f, "Penguin, imusti, Gardners Books", "1990", 0, "", "Little Birds" },
                    { "9780141184616", "Truman Capote", "https://covers.openlibrary.org/b/isbn/9780141184616-L.jpg", "9780141184616", "", 15f, "Penguin Books Ltd", "January 25, 2001", 1, "", "Music for Chameleons" },
                    { "9780141184760", "Allen Ginsberg", "", "9780141184760", "", 18.8f, "Penguin Books Ltd", "March 29, 2001", 0, "", "Selected Poems 1947-1995" },
                    { "9780141184968", "Marguerite Yourcenar", "https://covers.openlibrary.org/b/isbn/9780141184968-L.jpg", "9780141184968", "inglês", 15f, "Penguin Classics", "December 7, 2000", 1, "", "Memoirs of Hadrien" },
                    { "9780141185385", "Georges Bataille", "https://covers.openlibrary.org/b/isbn/9780141185385-L.jpg", "9780141185385", "", 11.75f, "Penguin Books Ltd.", "April 26, 2001", 0, "", "Story of the Eye" },
                    { "9780141185439", "Malcolm X", "https://covers.openlibrary.org/b/isbn/9780141185439-L.jpg", "9780141185439", "", 14.5f, "Penguin Books Ltd", "March 1, 2001", 0, "", "The Autobiography of Malcolm X" },
                    { "9780141185910", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780141185910-L.jpg", "9780141185910", "", 15f, "Penguin Books Ltd", "October 4, 2001", 1, "", "Go Tell It on the Mountain" },
                    { "9780141186351", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780141186351-L.jpg", "9780141186351", "", 14.75f, "Penguin Books Ltd", "October 4, 2001", 1, "", "Giovanni's Room" },
                    { "9780141186375", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9780141186375-L.jpg", "9780141186375", "", 15.5f, "Penguin Books Ltd", "September 11, 2001", 1, "", "Another Country" },
                    { "9780141186504", "Tennessee Williams", "https://covers.openlibrary.org/b/isbn/9780141186504-L.jpg", "9780141186504", "", 18.8f, "Penguin Books Ltd", "June 28, 2001", 0, "", "The Rose Tattoo and Other Plays" },
                    { "9780141187129", "Susan Sontag", "https://covers.openlibrary.org/b/isbn/9780141187129-L.jpg", "9780141187129", "", 19.55f, "Penguin Classics", "December 5, 2002", 1, "", "Illness as Metaphor & Aids and its Metaphors" },
                    { "9780141187655", "Truman Capote", "https://covers.openlibrary.org/b/isbn/9780141187655-L.jpg", "9780141187655", "", 15f, "Penguin Books Ltd", "May 27, 2004", 1, "", "Other Voices, Other Rooms" },
                    { "9780141187778", "Paul Bowles", "https://covers.openlibrary.org/b/isbn/9780141187778-L.jpg", "9780141187778", "inglês", 15f, "Penguin Books Ltd", "January 29, 2004", 0, "", "The Sheltering Sky" },
                    { "9780141189109", "Andy Warhol", "", "9780141189109", "inglês", 15f, "Penguin Books, Limited", "2007", 1, "", "The Philosophy of Andy Warhol" },
                    { "9780141189116", "", "https://covers.openlibrary.org/b/isbn/9780141189116-L.jpg", "9780141189116", "", 13.5f, "Penguin Books Ltd", "Apr 05, 2007", 0, "", "The Outsiders" },
                    { "9780141189291", "Tennessee Williams", "https://covers.openlibrary.org/b/isbn/9780141189291-L.jpg", "9780141189291", "inglês", 18.8f, "Penguin Books, Limited", "2008", 0, "", "Memoirs" },
                    { "9780141189420", "Andy Warhol", "", "9780141189420", "inglês", 16.8f, "Penguin Books, Limited", "2008", 0, "", "POPism" },
                    { "9780141189567", "", "https://covers.openlibrary.org/b/isbn/9780141189567-L.jpg", "9780141189567", "", 18.8f, "Penguin Books Ltd", "2008", 0, "", "Forbidden Colors" },
                    { "9780141189765", "William S. Burroughs", "", "9780141189765", "inglês", 14.75f, "Penguin Books, Limited", "2015", 1, "", "Naked Lunch" },
                    { "9780141189789", "William S. Burroughs", "", "9780141189789", "inglês", 14.5f, "Penguin Books, Limited", "2014", 1, "", "The Cut-Up Trilogy: 1 - The Soft Machine" },
                    { "9780141189826", "William S. Burroughs", "", "9780141189826", "inglês", 13.25f, "Penguin Books, Limited", "2009", 1, "", "Junky (Penguin)" },
                    { "9780141189833", "William S. Burroughs", "", "9780141189833", "inglês", 14.5f, "Penguin Books, Limited", "2008", 1, "", "The Wild Boys" },
                    { "9780141189840", "William S. Burroughs", "https://covers.openlibrary.org/b/isbn/9780141189840-L.jpg", "9780141189840", "", 14.5f, "Penguin Classic", "06 Nov 2008", 0, "", "Exterminator!" },
                    { "9780141189857", "William Burroughs", "https://covers.openlibrary.org/b/isbn/9780141189857-L.jpg", "9780141189857", "", 18.8f, "Penguin Classics", "Nov 06, 2008", 1, "", "The Job: Interviews" },
                    { "9780141189864", "William S. Burroughs", "", "9780141189864", "inglês", 20.9f, "Penguin Books, Limited", "2008", 0, "", "The Yage Letters" },
                    { "9780141189918", "William S. Burroughs", "", "9780141189918", "inglês", 15f, "Penguin Books, Limited", "2011", 2, "", "Queer (Burroughs)" },
                    { "9780141189932", "William S. Burroughs", "https://covers.openlibrary.org/b/isbn/9780141189932-L.jpg", "9780141189932", "", 17.35f, "Penguin Books", "Jan 01, 2010", 1, "", "Cities of the Red Night" },
                    { "9780141190051", "Susan Sontag", "", "9780141190051", "inglês", 20.95f, "Penguin Books, Limited", "2009", 1, "", "Styles of Radical Will" },
                    { "9780141190068", "Susan Sontag", "https://covers.openlibrary.org/b/isbn/9780141190068-L.jpg", "9780141190068", "inglês", 18.3f, "Penguin Books, Limited", "2009", 1, "", "Against Interpretation and Other Essays" },
                    { "9780141190082", "Susan Sontag", "", "9780141190082", "inglês", 17.4f, "Penguin Books, Limited", "2009", 1, "", "Under the Sign of Saturn" },
                    { "9780141190211", "Susan Sontag", "", "9780141190211", "inglês", 20.3f, "Penguin Books, Limited", "2009", 1, "", "Where the Stress Falss" },
                    { "9780141190266", "Tennessee Williams", "", "9780141190266", "inglês", 13.95f, "Penguin Books, Limited, Penguin", "2009", 1, "", "The Glass Menagerie" },
                    { "9780141190273", "Tennessee Williams", "", "9780141190273", "inglês", 14.75f, "Penguin Books, Limited", "2009", 0, "", "A Streetcar Named Desire" },
                    { "9780141190280", "Tennessee Williams", "", "9780141190280", "inglês", 15.5f, "Penguin Books, Limited", "2009", 1, "", "Cat on a Hot Tin Roof" },
                    { "9780141191089", "", "https://covers.openlibrary.org/b/isbn/9780141191089-L.jpg", "9780141191089", "", 14.75f, "Penguin Books", "2009", 1, "", "Sweet Bird of Youth and Other Plays" },
                    { "9780141191096", "", "https://covers.openlibrary.org/b/isbn/9780141191096-L.jpg", "9780141191096", "", 15.9f, "Penguin Books", "2010", 1, "", "Suddenly Last Summer and Other Plays" },
                    { "9780141191102", "Friedrich Engels", "https://covers.openlibrary.org/b/isbn/9780141191102-L.jpg", "9780141191102", "", 16.75f, "Penguin Classic", "Jun 02, 2009", 0, "", "The Condition of the Working Class in England" },
                    { "9780141191119", "", "https://covers.openlibrary.org/b/isbn/9780141191119-L.jpg", "9780141191119", "", 22f, "Penguin Books", "2010", 0, "", "The Origin of the Family, Private Property and the State" },
                    { "9780141191355", "Paul Bowles", "https://covers.openlibrary.org/b/isbn/9780141191355-L.jpg", "9780141191355", "", 21.75f, "Penguin Books", "May 01, 2010", 1, "", "Collected Stories" },
                    { "9780141191836", "Radclyffe Hall", "https://covers.openlibrary.org/b/isbn/9780141191836-L.jpg", "9780141191836", "inglês", 14.5f, "Penguin Books, Limited", "2015", 1, "", "The Well of Loneliness" },
                    { "9780141192055", "Betty Friedan", "", "9780141192055", "inglês", 15f, "Penguin Books, Limited", "2010", 0, "", "The Feminine Mystique" },
                    { "9780141192154", "", "https://covers.openlibrary.org/b/isbn/9780141192154-L.jpg", "9780141192154", "", 14.5f, "Penguin Books", "2012", 0, "", "The Gold-Rimmed Spectacles" },
                    { "9780141193076", "", "https://covers.openlibrary.org/b/isbn/9780141193076-L.jpg", "9780141193076", "", 24.6f, "Penguin Books", "Nov 01, 2010", 0, "", "The Andy Warhol Diaries" },
                    { "9780141195544", "", "https://covers.openlibrary.org/b/isbn/9780141195544-L.jpg", "9780141195544", "", 16.45f, "Penguin Books Ltd, Penguin Books, Limited (UK)", "2012", 1, "", "Blue of Noon" },
                    { "9780141195551", "Georges Bataille", "", "9780141195551", "inglês", 15.9f, "Penguin Books, Limited", "2012", 1, "", "My Mother / Madama Edwarda / The Dead Man" },
                    { "9780141195650", "", "https://covers.openlibrary.org/b/isbn/9780141195650-L.jpg", "9780141195650", "", 14.5f, "Penguin Books", "2011", 1, "", "Last Exit to Brooklyn" },
                    { "9780141198224", "", "https://covers.openlibrary.org/b/isbn/9780141198224-L.jpg", "9780141198224", "", 14.5f, "Penguin Books", "2012", 1, "", "Visions of Cody" },
                    { "9780141198248", "Jack Kerouac", "https://covers.openlibrary.org/b/isbn/9780141198248-L.jpg", "9780141198248", "", 14.5f, "Penguin Classics", "2012", 0, "", "Doctor Sax" },
                    { "9780141396064", "William S. Burroughs", "https://covers.openlibrary.org/b/isbn/9780141396064-L.jpg", "9780141396064", "", 14.5f, "Penguin Classics", "Apr 22, 2014", 1, "", "The Cut-Up Trilogy: 3 - Nova Express" },
                    { "9780141396118", "Peter Kropotkin", "https://covers.openlibrary.org/b/isbn/9780141396118-L.jpg", "9780141396118", "inglês", 14.75f, "Penguin Classics", "2015", 0, "", "The Conquest of Bread" },
                    { "9780141397986", "Karl Marx", "https://covers.openlibrary.org/b/isbn/9780141397986-L.jpg", "9780141397986", "inglês", 4.5f, "Penguin Books, Limited", "2015-02-26", 0, "", "The Communist Manifesto (Little Black Classics)" },
                    { "9780141398990", "Allen Ginsberg", "", "9780141398990", "inglês", 19.55f, "Penguin Books, Limited", "2015", 1, "", "The Essential Allen Ginsberg" },
                    { "9780141399010", "Allen Ginsberg", "", "9780141399010", "inglês", 17.35f, "Penguin Books, Limited", "2018", 0, "", "The Best Minds of My Generation: A Literary History of the Beats" },
                    { "9780141399027", "Allen Ginsberg", "https://covers.openlibrary.org/b/isbn/9780141399027-L.jpg", "9780141399027", "", 15f, "Penguin Classics", "Feb 25, 2016", 0, "", "Wait Till I'm Dead: Poems Uncollected" },
                    { "9780141439471", "Mary Shelley", "https://covers.openlibrary.org/b/isbn/9780141439471-L.jpg", "9780141439471", "inglês", 11.75f, "Penguin Books", "2003", 0, "", "Frankenstein (edição inglesa)" },
                    { "9780141981741", "", "https://covers.openlibrary.org/b/isbn/9780141981741-L.jpg", "9780141981741", "inglês", 14.5f, "Penguin Books", "2017", 0, "", "The Descent of Man" },
                    { "9780141984667", "Ruth Kinna", "https://covers.openlibrary.org/b/isbn/9780141984667-L.jpg", "9780141984667", "inglês", 15.8f, "Penguin Books, Limited, Pelican", "2020", 0, "", "The Government of No One: The Theory and Practice of Anarchism" },
                    { "9780141985985", "Lucy Delap", "", "9780141985985", "inglês", 16.8f, "Penguin Books, Limited", "2021", 1, "", "Feminisms: A Global History" },
                    { "9780141987880", "Patrizia Cavalli", "", "9780141987880", "inglês", 15f, "Penguin Books, Limited", "2018", 0, "", "My Poems Won't Change the World" },
                    { "9780141990149", "Walt Odets", "https://covers.openlibrary.org/b/isbn/9780141990149-L.jpg", "9780141990149", "inglês", 17.4f, "Penguin Books, Limited", "2020", 1, "", "Out of the Shadows: The Psychology of Gay Men's Lives" },
                    { "9780141991252", "PORTER CHARLIE", "https://covers.openlibrary.org/b/isbn/9780141991252-L.jpg", "9780141991252", "", 19.65f, "PENGUIN UK", "Jun 01, 2021", 1, "", "What Artists Wear" },
                    { "9780141991801", "Shon Faye", "", "9780141991801", "inglês", 16.25f, "Penguin Books, Limited", "2022", 1, "", "The Transgender Issue: An Argument for Justice (Paperback)" },
                    { "9780141993089", "Paris Lees", "", "9780141993089", "inglês", 16f, "Penguin Books, Limited", "2022", 0, "", "What It Feels Life for a Girl" },
                    { "9780141998213", "Alice Correia", "", "9780141998213", "inglês", 16.25f, "Penguin Books, Limited", "2022", 1, "", "What is Black Art?" },
                    { "9780143105978", "Haring, Keith.", "https://covers.openlibrary.org/b/isbn/9780143105978-L.jpg", "9780143105978", "inglês", 23.25f, "Penguin Group", "2010", 0, "", "Journals" },
                    { "9780143106180", "Katherine Howe", "https://covers.openlibrary.org/b/isbn/9780143106180-L.jpg", "9780143106180", "inglês", 14.75f, "Penguin Classics, Penguin Books", "2014", 0, "", "The Penguin Book of Witches" },
                    { "9780143106968", "Merle Miller", "https://covers.openlibrary.org/b/isbn/9780143106968-L.jpg", "9780143106968", "inglês", 13.05f, "Penguin Books", "2012", 0, "", "On Being Different: What It Means to Be a Homosexual" },
                    { "9780143131625", "Scott G. Bruce", "", "9780143131625", "inglês", 18.05f, "", "2018", 0, "", "The Penguin Book of Hell" },
                    { "9780143131700", "Sam Sax", "", "9780143131700", "inglês", 18.8f, "Penguin Books", "2017", 1, "", "Madness" },
                    { "9780143133384", "Dohra Ahmad", "https://covers.openlibrary.org/b/isbn/9780143133384-L.jpg", "9780143133384", "", 18.4f, "Penguin Classics", "Sep 17, 2019", 1, "", "The Penguin Book of Migration Literature" },
                    { "9780143133513", "", "https://covers.openlibrary.org/b/isbn/9780143133513-L.jpg", "9780143133513", "inglês", 19.05f, "Penguin Classics", "Apr 30, 2019", 0, "", "The Stonewall Reader" },
                    { "9780143133728", "Cristina Bacchilega", "", "9780143133728", "inglês", 21.25f, "Penguin Publishing Group", "2019", 1, "", "The Penguin Book of Mermaids" },
                    { "9780143134220", "Claude McKay", "https://covers.openlibrary.org/b/isbn/9780143134220-L.jpg", "9780143134220", "inglês", 15.5f, "Penguin Books, Limited, Penguin Classics", "2020", 0, "", "Romance in Marseille" },
                    { "9780143135616", "Dick Davis", "https://covers.openlibrary.org/b/isbn/9780143135616-L.jpg", "9780143135616", "inglês", 17.75f, "Penguin Books, Limited, Penguin Classics", "2021", 0, "", "The Mirror of My Heart: A Thousand Years of Persian Poetry by Women" },
                    { "9780143136071", "Luisa Capetillo", "https://covers.openlibrary.org/b/isbn/9780143136071-L.jpg", "9780143136071", "", 18.8f, "Penguin Classics", "Sep 14, 2021", 0, "", "A Nation of Women" },
                    { "9780143137078", "George S. Schuyler", "https://covers.openlibrary.org/b/isbn/9780143137078-L.jpg", "9780143137078", "inglês", 23.25f, "Penguin Publishing Group, Penguin Classics", "2023", 1, "", "Black Empire" },
                    { "9780143137269", "George Moses Horton", "https://covers.openlibrary.org/b/isbn/9780143137269-L.jpg", "9780143137269", "inglês", 20.95f, "Penguin Publishing Group, Penguin Classics", "2023", 1, "", "Minor Notes: Volume 1" },
                    { "9780143137467", "Carter Godwin Woodson", "https://covers.openlibrary.org/b/isbn/9780143137467-L.jpg", "9780143137467", "inglês", 19.5f, "Penguin Publishing Group, Penguin Classics", "2023", 1, "", "The Mis-Education of the Negro" },
                    { "9780224069823", "Joe Sacco", "https://covers.openlibrary.org/b/isbn/9780224069823-L.jpg", "9780224069823", "", 22.75f, "Jonathan Cape", "January 2, 2003", 0, "", "Palestine" },
                    { "9780224080514", "Alison Bechdel", "https://covers.openlibrary.org/b/isbn/9780224080514-L.jpg", "9780224080514", "", 19.55f, "Jonathan Cape, imusti", "Oct 01, 2006", 0, "", "Fun Home" },
                    { "9780224087063", "Alison Bechdel", "", "9780224087063", "inglês", 38f, "Penguin Random House", "2008", 1, "", "Dykes To Watch Out For: The Essential" },
                    { "9780224101905", "Alison Bechdel", "", "9780224101905", "inglês", 20.95f, "Penguin Random House", "2021", 1, "", "The Secret to Superhuman Strenght" },
                    { "9780241004623", "Colm Tóibín", "", "9780241004623", "inglês", 17.5f, "Penguin Books, Limited", "2021", 0, "", "The Magician" },
                    { "9780241251027", "Philippa Perry", "https://covers.openlibrary.org/b/isbn/9780241251027-L.jpg", "9780241251027", "inglês", 16.05f, "Penguin Books, Limited", "2020", 0, "", "The Book You Wish Your Parents Had Read (and Your Children Will be Glad That You Did)" },
                    { "9780241252536", "Binyavanga Wainaina", "", "9780241252536", "inglês", 15.75f, "Penguin Books, Limited", "2023", 1, "", "How to Write about Africa" },
                    { "9780241301197", "YUKIO MISHIMA", "https://covers.openlibrary.org/b/isbn/9780241301197-L.jpg", "9780241301197", "", 13.95f, "Penguin Classics", "", 0, "", "Confessions of a Mask" },
                    { "9780241302514", "Kathy Acker", "https://covers.openlibrary.org/b/isbn/9780241302514-L.jpg", "9780241302514", "", 14.5f, "Penguin", "2017-08-31", 1, "", "Blood and Guts in High School" },
                    { "9780241312995", "Alphonse James Albert Symons", "", "9780241312995", "inglês", 15.5f, "Penguin Books, Limited", "2018", 0, "", "The Quest for Corvo" },
                    { "9780241316757", "", "https://covers.openlibrary.org/b/isbn/9780241316757-L.jpg", "9780241316757", "inglês", 15.5f, "Penguin", "2017", 1, "", "The Origins of Totalitarianism" },
                    { "9780241334003", "James Baldwin", "", "9780241334003", "inglês", 14.45f, "Penguin Books, Limited", "2017", 1, "", "Notes of a Native Son" },
                    { "9780241337622", "", "https://covers.openlibrary.org/b/isbn/9780241337622-L.jpg", "9780241337622", "inglês", 3.7f, "Penguin Books, Limited", "2018-02-22", 0, "", "Television Was a Baby Crawling Toward That Deathchamber" },
                    { "9780241339145", "Truman Capote", "https://covers.openlibrary.org/b/isbn/9780241339145-L.jpg", "9780241339145", "inglês", 3.7f, "Penguin Books, Limited", "2018-02-22", 0, "", "The Duke in His Domain" },
                    { "9780241339541", "Anaïs Nin", "https://covers.openlibrary.org/b/isbn/9780241339541-L.jpg", "9780241339541", "inglês", 3.7f, "Penguin Books, Limited", "2018-02-22", 0, "", "The Veiled Woman" },
                    { "9780241339688", "Gertrude Stein", "https://covers.openlibrary.org/b/isbn/9780241339688-L.jpg", "9780241339688", "inglês", 3.7f, "Penguin Books, Limited", "2018-02-22", 0, "", "Food" },
                    { "9780241339701", "Susan Sontag", "https://covers.openlibrary.org/b/isbn/9780241339701-L.jpg", "9780241339701", "inglês", 3f, "Penguin Books, Limited", "2018-02-22", 0, "", "Notes on 'Camp'" },
                    { "9780241339725", "Gertrude Stein", "", "9780241339725", "inglês", 3f, "Penguin Books, Limited", "2018", 0, "", "The Master's Tools Will Never Dismantle the Master's House" },
                    { "9780241339800", "Andy Warhol", "https://covers.openlibrary.org/b/isbn/9780241339800-L.jpg", "9780241339800", "inglês", 2.9f, "Penguin Books, Limited", "2018-02-22", 0, "", "Fame" },
                    { "9780241342039", "James Baldwin", "", "9780241342039", "inglês", 15f, "Penguin Books, Limited", "2018", 1, "", "Tell Me How Long the Train's Been Gone" },
                    { "9780241351086", "Audre Lorde", "", "9780241351086", "inglês", 15.5f, "Penguin Books, Limited", "2018", 2, "", "Zami: A New Spelling of My Name" },
                    { "9780241351291", "Billie Holiday", "", "9780241351291", "inglês", 14.7f, "Penguin Books, Limited", "2018", 0, "", "Lady Sings the Blues" },
                    { "9780241352144", "Kathy Acker", "", "9780241352144", "inglês", 14.5f, "Penguin Books, Limited", "2018", 1, "", "Great Expectations" },
                    { "9780241360637", "Nicolaus Copernicus", "", "9780241360637", "inglês", 22f, "Penguin Books, Limited", "2023", 0, "", "The Dawn of Modern Cosmology" },
                    { "9780241371978", "Virginia Woolf", "", "9780241371978", "inglês", 13.65f, "Penguin Books, Limited", "2019", 0, "", "A Room of One's Own / Three Guineas" },
                    { "9780241388945", "Jack Kerouac", "", "9780241388945", "inglês", 13.15f, "Penguin Books, Limited", "2019", 0, "", "Mexico City Blues" },
                    { "9780241389010", "Jack Kerouac", "", "9780241389010", "inglês", 13.65f, "Penguin Books, Limited", "2019", 0, "", "Visions of Gerard" },
                    { "9780241396865", "Audre Lorde", "", "9780241396865", "inglês", 13.95f, "Penguin Books, Limited", "2019", 1, "", "The Black Unicorn" },
                    { "9780241408407", "Angela Y. Davis", "https://covers.openlibrary.org/b/isbn/9780241408407-L.jpg", "9780241408407", "inglês", 15f, "Penguin Books, Limited, Penguin Classics", "2019", 1, "", "Women, Race & Class" },
                    { "9780241410509", "Audre Lorde", "", "9780241410509", "inglês", 15.5f, "Penguin Books, Limited", "2019", 1, "", "Sister Outsider" },
                    { "9780241423141", "", "https://covers.openlibrary.org/b/isbn/9780241423141-L.jpg", "9780241423141", "inglês", 24f, "Allen Lane", "2021-09-02", 0, "", "The Transgender Issue: An Argument for Justice" },
                    { "9780241435083", "Michel Foucault", "https://covers.openlibrary.org/b/isbn/9780241435083-L.jpg", "9780241435083", "inglês", 20.15f, "Penguin Books, Limited, Penguin Classics", "2020", 0, "", "Power: Essential Works 1954-84" },
                    { "9780241435090", "Michel Foucault", "", "9780241435090", "inglês", 20.15f, "Penguin Books, Limited", "2020", 0, "", "Ethics: Essential Works 1954-84" },
                    { "9780241435113", "Michel Foucault", "", "9780241435113", "inglês", 19.45f, "Penguin Books, Limited", "2020", 0, "", "Aesthetics: Essential Works 1954-84" },
                    { "9780241436288", "Virginia Woolf", "", "9780241436288", "inglês", 9.5f, "Penguin Books, Limited", "2020", 0, "", "A Room of One's Own" },
                    { "9780241436301", "Virginia Woolf", "", "9780241436301", "inglês", 12f, "Penguin Books, Limited", "2020", 0, "", "Orlando" },
                    { "9780241453506", "Audre Lorde", "", "9780241453506", "inglês", 13.95f, "Penguin Books, Limited", "2020", 0, "", "The Cancer Journals" },
                    { "9780241472361", "Sojourner Truth", "https://covers.openlibrary.org/b/isbn/9780241472361-L.jpg", "9780241472361", "inglês", 9.3f, "Penguin Books, Limited, Penguin Books", "2020", 0, "", "Ain't I A Woman?" },
                    { "9780241508718", "June Jordan", "", "9780241508718", "inglês", 14.75f, "Penguin Books, Limited", "2021", 0, "", "The Essential June Jordan" },
                    { "9780241508749", "Dan Stone", "", "9780241508749", "inglês", 16.5f, "Penguin Books, Limited", "2024", 1, "", "The Holocaust: An Unfinished History" },
                    { "9780241514177", "Cedric J. Robinson", "", "9780241514177", "inglês", 18.8f, "Penguin Books, Limited", "2021", 0, "", "Black Marxism: The Making of the Black Radical Tradition" },
                    { "9780241515037", "", "https://covers.openlibrary.org/b/isbn/9780241515037-L.jpg", "9780241515037", "inglês", 12.25f, "Penguin Books", "2021", 0, "", "All Boys Aren't Blue" },
                    { "9780241519936", "", "https://covers.openlibrary.org/b/isbn/9780241519936-L.jpg", "9780241519936", "", 11.6f, "", "", 0, "", "Bodies Are Cool" },
                    { "9780241528457", "Diarmuid Hester", "", "9780241528457", "inglês", 30f, "Penguin Books, Limited", "2023", 1, "", "Nothing Ever Just Disappears" },
                    { "9780241532683", "Buchi Emecheta", "", "9780241532683", "inglês", 15.5f, "Penguin Books, Limited", "2021", 0, "", "Second-Class Citizen" },
                    { "9780241535394", "Aimé Césaire", "", "9780241535394", "inglês", 16.25f, "Penguin Books, Limited", "2023", 2, "", "Return to My Native Land" },
                    { "9780241537343", "Elaine Brown", "", "9780241537343", "inglês", 16.25f, "Penguin Books, Limited", "2021", 0, "", "A Taste of Power: A Black Woman's Story" },
                    { "9780241541388", "Aidan Chambers", "https://covers.openlibrary.org/b/isbn/9780241541388-L.jpg", "9780241541388", "inglês", 14f, "Penguin Books, Limited, Penguin", "2021", 0, "", "Dance On My Grave" },
                    { "9780241543740", "Angela Y. Davis", "", "9780241543740", "inglês", 18f, "Penguin Books, Limited", "2021", 0, "", "Abolition. Feminism. Now." },
                    { "9780241543757", "Angela Y. Davis", "", "9780241543757", "inglês", 15.5f, "Penguin Books, Limited", "2022", 0, "", "Abolition. Feminism. Now. (Paperback)" },
                    { "9780241547991", "Erving Goffman", "", "9780241547991", "inglês", 16.25f, "Penguin Books, Limited", "2022", 1, "", "The Presentation of Self in Everyday Life" },
                    { "9780241548004", "Erving Goffman", "", "9780241548004", "inglês", 19.25f, "Penguin Books, Limited", "2022", 1, "", "Asylums: Essays on the Social Situation of Mental Patients and Other Inmates" },
                    { "9780241548011", "Erving Goffman", "", "9780241548011", "inglês", 16.25f, "Penguin Books, Limited", "2022", 1, "", "Stigma: Notes on the Management of Spoiled Identity" },
                    { "9780241551271", "Angela Y. Davis", "", "9780241551271", "inglês", 21.25f, "Penguin Books, Limited", "2024", 1, "", "Abolition: Politics, Practices, Promises - Vol. 1" },
                    { "9780241552292", "Hannah Arendt", "", "9780241552292", "inglês", 16.25f, "Penguin Books, Limited", "2022", 2, "", "Eichmann in Jerusalem: A Report on the Banality of Evil" },
                    { "9780241575734", "Luke Edward Hall", "", "9780241575734", "inglês", 30.75f, "Penguin Books, Limited", "2023", 0, "", "300,000 Kisses: Tales of Queer Love from the Ancient World" },
                    { "9780241578131", "Buchi Emecheta", "", "9780241578131", "inglês", 14.75f, "Penguin Books, Limited", "2022", 0, "", "The Joys of Motherhood" },
                    { "9780241586402", "", "", "9780241586402", "", 18.14f, "", "", 1, "", "a" },
                    { "9780241595824", "", "https://covers.openlibrary.org/b/isbn/9780241595824-L.jpg", "9780241595824", "inglês", 31f, "Allen Lane", "2024", 0, "", "Who's Afraid of Gender?" },
                    { "9780241602751", "Charlie Porter", "", "9780241602751", "inglês", 23.75f, "Penguin Books, Limited", "2023", 0, "", "Bring No Clothes: Bloomsbury and the Philosophy of Fashion" },
                    { "9780241618042", "Ursula K. Le Guin", "", "9780241618042", "inglês", 13.5f, "Penguin Books, Limited", "2023", 0, "", "Earthsea: The First Four Books" },
                    { "9780241618257", "Chukwuebuka Ibeh", "", "9780241618257", "inglês", 18.75f, "Penguin Books, Limited", "2024", 0, "", "Blessings" },
                    { "9780241619537", "Sara Ahmed", "", "9780241619537", "inglês", 22.5f, "Penguin Books, Limited", "2023", 1, "", "The Feminist Killjoy Handbook" },
                    { "9780241631645", "Hannah Arendt", "", "9780241631645", "inglês", 12.75f, "Penguin Books, Limited", "2023", 0, "", "On Violence" },
                    { "9780241633977", "Hannah Dawson", "", "9780241633977", "inglês", 19.75f, "Penguin Books, Limited", "2023", 1, "", "The Penguin Book of Feminist Writing" },
                    { "9780241639795", "Dionne Brand", "", "9780241639795", "inglês", 24.5f, "Penguin Books, Limited", "2023", 0, "", "Nomenclature: New and Collected Poems" },
                    { "9780241707647", "Edward Morgan Forster", "", "9780241707647", "inglês", 15f, "Penguin Books, Limited", "2024", 2, "", "The Life to Come and Other Stories" },
                    { "9780241711187", "James Baldwin - undifferentiated", "", "9780241711187", "inglês", 15f, "Penguin Books, Limited", "2024", 1, "", "No Name in the Street" },
                    { "9780241954461", "Susan Sontag", "https://covers.openlibrary.org/b/isbn/9780241954461-L.jpg", "9780241954461", "inglês", 18.8f, "Penguin Books, Limited", "2013", 1, "", "As Consciousness is Harnessed to Flesh: Diaries 1964-1980" },
                    { "9780241982716", "Susan Sontag", "", "9780241982716", "inglês", 18.8f, "Penguin Books, Limited", "2018", 0, "", "Stories" },
                    { "9780241994573", "Angela Y. Davis", "", "9780241994573", "inglês", 16.5f, "Penguin Books, Limited", "2023", 0, "", "An Autobiography" },
                    { "9780241996843", "Susan Sontag", "", "9780241996843", "inglês", 16.25f, "Penguin Books, Limited", "2024", 0, "", "On Women" },
                    { "9780253222039", "", "https://covers.openlibrary.org/b/isbn/9780253354839-L.jpg", "9780253222039", "inglês", 43f, "Indiana University Press", "2010", 0, "", "Queer Ecologies: Sex, Nature, Politics, Desire" },
                    { "9780300061633", "", "", "9780300061633", "", 12f, "", "", 0, "", "The Lenses of Gender: Transforming the Debate on Sexual Inequality" },
                    { "9780300080889", "Gregory Woods", "https://covers.openlibrary.org/b/isbn/9780300080889-L.jpg", "9780300080889", "inglês", 15f, "Yale University Press", "November 10, 1999", 0, "", "A History of Gay Literature: The Male Tradition" },
                    { "9780300107890", "Richard Siken", "https://covers.openlibrary.org/b/isbn/9780300107890-L.jpg", "9780300107890", "inglês", 22.5f, "Yale University Press", "April 11, 2005", 0, "", "Crush" },
                    { "9780300246315", "Olga Broumas", "", "9780300246315", "inglês", 23.32f, "Yale University Press", "2019", 0, "", "Beginning with O" },
                    { "9780300265842", "Cicely Robinson", "", "9780300265842", "inglês", 28.25f, "Yale University Press", "2022", 1, "", "Henry Scott Tuke" },
                    { "9780307388902", "Thomas Mallon", "https://covers.openlibrary.org/b/isbn/9780307388902-L.jpg", "9780307388902", "inglês", 14f, "Vintage", "May 6, 2008", 0, "", "Fellow travelers" },
                    { "9780307473134", "Robert Beachy", "https://covers.openlibrary.org/b/isbn/9780307473134-L.jpg", "9780307473134", "inglês", 18.35f, "", "2015", 2, "", "Gay Berlin" },
                    { "9780312420307", "Byrne Fone", "https://covers.openlibrary.org/b/isbn/9780312420307-L.jpg", "9780312420307", "inglês", 26.75f, "Picador", "November 3, 2001", 0, "", "Homophobia" },
                    { "9780316264372", "Laura Jane Grace", "https://covers.openlibrary.org/b/isbn/9780316264372-L.jpg", "9780316264372", "inglês", 17.75f, "Little, Brown Book Group Limited", "2017", 0, "", "Tranny: Confessions of Punk Rock's Most Infamous Anarchist Sellout" },
                    { "9780316458733", "Jeremy Atherton Lin", "", "9780316458733", "inglês", 29.3f, "Little Brown & Company", "2021", 0, "", "Gay Bar: Why We Went Out" },
                    { "9780330483216", "", "https://covers.openlibrary.org/b/isbn/9780330483216-L.jpg", "9780330483216", "inglês", 14.5f, "Picador", "2005", 0, "", "The Line of Beauty" },
                    { "9780349013336", "Anne Lister", "https://covers.openlibrary.org/b/isbn/9780349013336-L.jpg", "9780349013336", "inglês", 15f, "Little, Brown Book Group Limited", "2020", 0, "", "The Secret Diaries of Miss Anne Lister: 2 – No Priest but Love (1824-1826)" },
                    { "9780349015682", "Jenn Shapland", "https://covers.openlibrary.org/b/isbn/9780349015682-L.jpg", "9780349015682", "inglês", 16.25f, "Little, Brown Book Group Limited, Virago", "2022", 0, "", "My Autobiography of Carson McCullers" },
                    { "9780349015897", "Fran Lebowitz", "", "9780349015897", "inglês", 22f, "Little, Brown Book Group Limited", "2021", 0, "", "The Fran Lebowitz Reader" },
                    { "9780349017419", "Angela Carter", "", "9780349017419", "inglês", 15.5f, "Little, Brown Book Group Limited", "2023", 1, "", "The Sadeian Woman: An Exercise in Cultural History" },
                    { "9780349018485", "Sarah Waters", "", "9780349018485", "inglês", 15f, "Little, Brown Book Group Limited", "2024", 0, "", "Tipping the Velvet" },
                    { "9780349103655", "Gore Vidal", "https://covers.openlibrary.org/b/isbn/9780349103655-L.jpg", "9780349103655", "", 18.8f, "Abacus", "April 22, 1993", 1, "", "Myra Breckinridge & Myron" },
                    { "9780349106571", "Gore Vidal", "https://covers.openlibrary.org/b/isbn/9780349106571-L.jpg", "9780349106571", "", 15f, "Abacus", "May 1, 1997", 1, "", "The City and the Pillar" },
                    { "9780349700588", "Paul Mendez", "", "9780349700588", "inglês", 13.8f, "Little, Brown Book Group Limited", "2021", 0, "", "Rainbow Milk" },
                    { "9780349701073", "Okechukwu Nzelu", "", "9780349701073", "inglês", 22f, "Dialogue Books", "2022", 0, "", "Here Again Now" },
                    { "9780356508191", "N. K. Jemisin", "https://covers.openlibrary.org/b/isbn/9780356508191-L.jpg", "9780356508191", "inglês", 13.8f, "Orbit", "2016", 0, "", "The Broken Earth: 1 – The Fifth Season" },
                    { "9780374304249", "Tami Lewis Brown", "https://covers.openlibrary.org/b/isbn/9780374304249-L.jpg", "9780374304249", "", 23.5f, "Farrar, Straus and Giroux (BYR)", "Dec 01, 2020", 1, "", "Art Is Life: The Life of Artist Keith Haring" },
                    { "9780374535957", "Durga Chew-Bose", "https://covers.openlibrary.org/b/isbn/9780374535957-L.jpg", "9780374535957", "inglês", 16.75f, "FSG Originals", "2017", 1, "", "Too Much and Not the Mood" },
                    { "9780374537692", "Frank Bidart", "https://covers.openlibrary.org/b/isbn/9780374537692-L.jpg", "9780374537692", "", 22.25f, "Farrar, Straus and Giroux", "Aug 21, 2018", 1, "", "Half-Light: Collected Poems 1965-2016" },
                    { "9780375711480", "Mark Ford", "", "9780375711480", "inglês", 24.44f, "Knopf Doubleday Publishing Group", "2010", 1, "", "Selected Poems" },
                    { "9780375715181", "Gengoroh Tagame", "https://covers.openlibrary.org/b/isbn/9780375715181-L.jpg", "9780375715181", "inglês", 31.3f, "Knopf Doubleday Publishing Group, Pantheon", "February 11, 2020", 1, "", "My Brother's Husband" },
                    { "9780385472043", "Drake, David", "", "9780385472043", "inglês", 14.6f, "Anchor Books", "1994", 0, "", "The Night Larry Kramer Kissed Me" },
                    { "9780385548410", "Hanya Yanagihara", "https://covers.openlibrary.org/b/isbn/9780385548410-L.jpg", "9780385548410", "", 19.5f, "RANDOM HOUSE US", "Jan 01, 2022", 0, "", "To Paradise" },
                    { "9780393319729", "Audre Lorde", "https://covers.openlibrary.org/b/isbn/9780393319729-L.jpg", "9780393319729", "inglês", 23.5f, "W. W. Norton & Company", "February 2000", 0, "", "The Collected Poems of Audre Lorde" },
                    { "9780393343144", "Maggie Nelson", "https://covers.openlibrary.org/b/isbn/9780393343144-L.jpg", "9780393343144", "", 19.25f, "W. W. Norton & Company, imusti", "Aug 13, 2012", 1, "", "The Art of Cruelty: A Reckoning" },
                    { "9780393346008", "Adrienne Rich", "", "9780393346008", "inglês", 17.35f, "Norton & Company, Incorporated, W. W.", "2013", 0, "", "The Dream of a Common Language: Poems 1974-1977" },
                    { "9780393355116", "Adrienne Rich", "https://covers.openlibrary.org/b/isbn/9780393355116-L.jpg", "9780393355116", "", 18.8f, "W. W. Norton & Company", "Sep 11, 2018", 0, "", "Selected Poems: 1950-2012" },
                    { "9780394738628", "Michel Foucault", "https://covers.openlibrary.org/b/isbn/9780394738628-L.jpg", "9780394738628", "inglês", 22f, "Pantheon", "June 12, 1980", 0, "", "Herculine Barbin" },
                    { "9780399579660", "Janet W. Hardy", "https://covers.openlibrary.org/b/isbn/9780399579660-L.jpg", "9780399579660", "inglês", 24f, "", "2017", 2, "", "The Ethical Slut" },
                    { "9780413316806", "Shelagh Delaney", "https://covers.openlibrary.org/b/isbn/9780413316806-L.jpg", "9780413316806", "", 15.9f, "Methuen Drama", "January 1, 1959", 1, "", "A Taste of Honey" },
                    { "9780413554802", "Caryl Churchill", "https://covers.openlibrary.org/b/isbn/9780413554802-L.jpg", "9780413554802", "inglês", 15.9f, "Methuen Publishing", "December 25, 2001", 0, "", "Top Girls" },
                    { "9780413712400", "MARK RAVENHILL", "", "9780413712400", "inglês", 14.5f, "Methuen Drama", "1997", 1, "", "Shopping & Fucking" },
                    { "9780413742605", "Sarah Kane", "", "9780413742605", "inglês", 26.05f, "Methuen Drama", "2001", 0, "", "Complete Plays: Blasted / Phaedra's Love / Cleansed / Crave / 4.48 Psychosis / Skin" },
                    { "9780465017522", "Dr. Andrea Sharon Dworkin", "https://covers.openlibrary.org/b/isbn/9780465017522-L.jpg", "9780465017522", "inglês", 19.54f, "Basic Books", "November 30, 2006", 0, "", "Intercourse" },
                    { "9780486818993", "Audre Lorde", "", "9780486818993", "inglês", 24.6f, "", "2017", 0, "", "A Burst of Light and Other Essays" },
                    { "9780500016565", "Derek Jarman", "", "9780500016565", "inglês", 26.5f, "Thames and Hudson", "1995", 1, "", "Derek Jarman's Garden" },
                    { "9780500021866", "Michael Peppiatt", "", "9780500021866", "inglês", 52f, "Thames & Hudson, Limited", "2024", 1, "", "Francis Bacon: A Self-Portrait in Words" },
                    { "9780500023846", "Linda Nochlin", "https://covers.openlibrary.org/b/isbn/9780500023846-L.jpg", "9780500023846", "inglês", 14.75f, "Thames & Hudson", "2021", 1, "", "Why Have There Been No Great Women Artists?" },
                    { "9780500027233", "", "", "9780500027233", "", 32.5f, "", "", 1, "", "Derek Jarman's House" },
                    { "9780500027257", "Linda Nochlin", "", "9780500027257", "inglês", 16.9f, "Thames & Hudson, Limited", "2024", 2, "", "The Body" },
                    { "9780500204498", "James Laver", "", "9780500204498", "inglês", 24.75f, "Thames & Hudson, Limited", "2020", 0, "", "Costume and Fashion (World of Art)" },
                    { "9780500204566", "Whitney Chadwick", "", "9780500204566", "inglês", 29.25f, "Thames & Hudson", "2020", 0, "", "Women, Art, and Society (World of Art)" },
                    { "9780500204825", "Anne Massey", "https://covers.openlibrary.org/b/isbn/9780500204825-L.jpg", "9780500204825", "inglês", 20f, "Thames & Hudson", "2022", 1, "", "Women in Design (World of Art)" },
                    { "9780500204863", "Colin Rhodes", "", "9780500204863", "inglês", 20f, "Thames & Hudson", "2022", 1, "", "Outsider Art: Art Brut and its Affinities (World of Art)" },
                    { "9780500239704", "Maura Reilly", "", "9780500239704", "inglês", 36.75f, "Thames & Hudson", "2018", 0, "", "Curatorial Activism: Toward an Ethics of Curating" },
                    { "9780500286715", "David Hockney", "https://covers.openlibrary.org/b/isbn/9780500286715-L.jpg", "9780500286715", "", 28.65f, "Thames & Hudson", "Jan 10, 2017", 1, "", "Hockney's Pictures" },
                    { "9780500292341", "Marco Livingstone", "https://covers.openlibrary.org/b/isbn/9780500292341-L.jpg", "9780500292341", "", 28.9f, "Thames & Hudson", "Aug 30, 2016", 1, "", "Hockney's Portraits and People" },
                    { "9780500292532", "David Sylvester", "https://covers.openlibrary.org/b/isbn/9780500292532-L.jpg", "9780500292532", "", 24.55f, "Thames & Hudson", "Nov 15, 2016", 0, "", "Interviews With Francis Bacon" },
                    { "9780500294024", "Frances Borzello", "", "9780500294024", "inglês", 27.6f, "Thames & Hudson, Limited", "2018", 0, "", "Seeing Ourselves: Women's Self-Portraits" },
                    { "9780500295557", "Linda Nochlin", "", "9780500295557", "inglês", 41f, "Thames & Hudson", "2020", 1, "", "Women Artists: The Linda Nochlin Reader" },
                    { "9780500296608", "GAYFORD MARTIN", "", "9780500296608", "", 22f, "THAMES HUDSON", "Mar 24, 2022", 0, "", "Spring Cannot Be Cancelled: David Hockney in Normandy" },
                    { "9780500297032", "Robert Aldrich", "", "9780500297032", "inglês", 18.5f, "Thames & Hudson, Limited", "2023", 1, "", "Gay Life Stories" },
                    { "9780500297285", "Jeffrey B. Russell", "", "9780500297285", "inglês", 17.5f, "Thames & Hudson, Limited", "2024", 0, "", "A History of Witchcraft: Sorcerers, Heretics & Pagans" },
                    { "9780500297490", "François Leperlier", "", "9780500297490", "inglês", 19.55f, "Thames & Hudson, Limited", "2023", 1, "", "Claude Cahun (Photofile)" },
                    { "9780500297902", "Isabelle Bonnet", "", "9780500297902", "inglês", 58.5f, "Thames & Hudson, Limited", "2024", 1, "", "Casa Susanna: The Story of the First Trans Network in the United States, 1959-1968" },
                    { "9780500411186", "Clara Bouveresse", "", "9780500411186", "inglês", 48.9f, "Thames & Hudson, Limited", "2020", 1, "", "Women Photographers (Slipcase) (Photofile)" },
                    { "9780500516942", "", "https://covers.openlibrary.org/b/isbn/9780500516942-L.jpg", "9780500516942", "", 41.88f, "Thames & Hudson Ltd", "2013", 1, "", "Derek Jarman's Sketchbooks" },
                    { "9780500517321", "James Mackay", "https://covers.openlibrary.org/b/isbn/9780500517321-L.jpg", "9780500517321", "", 27.85f, "Thames & Hudson", "Nov 11, 2014", 0, "", "Derek Jarman Super 8" },
                    { "9780520292697", "Jack Halberstam", "https://covers.openlibrary.org/b/isbn/9780520292697-L.jpg", "9780520292697", "inglês", 25f, "University of California Press", "Jan 24, 2018", 1, "", "Trans*: A Quick and Quirky Account of Gender Variability" },
                    { "9780525510307", "Ta-Nehisi Coates", "https://covers.openlibrary.org/b/isbn/9780525510307-L.jpg", "9780525510307", "", 11.5f, "Random House LCC US", "Sep 05, 2017", 0, "", "Between the World and Me" },
                    { "9780525560562", "Mikki Kendall", "https://covers.openlibrary.org/b/isbn/9780525560562-L.jpg", "9780525560562", "", 14.2f, "Penguin Books", "Feb 23, 2021", 0, "", "Hood Feminism: Notes from the Women That a Movement Forgot" },
                    { "9780525563433", "Carolina De Robertis", "https://covers.openlibrary.org/b/isbn/9780525563433-L.jpg", "9780525563433", "inglês", 17.75f, "Knopf Doubleday Publishing Group", "2020", 0, "", "Cantoras" },
                    { "9780525618645", "Harvey Fierstein", "https://covers.openlibrary.org/b/isbn/9780525618645-L.jpg", "9780525618645", "", 20.9f, "Ballantine Books", "Sep 25, 2018", 1, "", "Torch Song Trilogy" },
                    { "9780552778404", "Matthew Todd", "", "9780552778404", "inglês", 16f, "Transworld Publishers Limited", "2018", 1, "", "Straight Jacket: Overcoming Society's Legacy of Gay Shame" },
                    { "9780552998765", "Armistead Maupin", "", "9780552998765", "inglês", 13.8f, "Transworld Publishers Limited", "2000", 1, "", "Tales of the City" },
                    { "9780552998772", "Armistead Maupin", "https://covers.openlibrary.org/b/isbn/9780552998772-L.jpg", "9780552998772", "", 13.45f, "BLACK SWAN (TWLD)", "September 11, 2000", 1, "", "More Tales of the City" },
                    { "9780552998789", "Armistead Maupin", "https://covers.openlibrary.org/b/isbn/9780552998789-L.jpg", "9780552998789", "", 13.45f, "Black Swan", "June 19, 2007", 1, "", "Further Tales of the City" },
                    { "9780552998796", "Armistead Maupin", "https://covers.openlibrary.org/b/isbn/9780552998796-L.jpg", "9780552998796", "", 13.45f, "Black Swan", "June 19, 2007", 1, "", "Babycakes" },
                    { "9780571162574", "Thom Gunn", "https://covers.openlibrary.org/b/isbn/9780571162574-L.jpg", "9780571162574", "", 16.5f, "Faber and Faber", "March 4, 2002", 1, "", "The Man With Night Sweats" },
                    { "9780571192717", "Tom Stoppard", "", "9780571192717", "inglês", 14.5f, "Faber and Faber", "1997", 0, "", "The Invention of Love" },
                    { "9780571224371", "Taichi Yamada        ", "https://covers.openlibrary.org/b/isbn/9780571224371-L.jpg", "9780571224371", "", 11.5f, "Faber & Faber", "January 31, 2006", 0, "", "Strangers" },
                    { "9780571234134", "Jan Morris", "https://covers.openlibrary.org/b/isbn/9780571234134-L.jpg", "9780571234134", "inglês", 18.75f, "Faber & Faber, Limited", "2021", 0, "", "Allegorizings" },
                    { "9780571241538", "W. H. Auden", "", "9780571241538", "inglês", 24.6f, "Faber & Faber, Limited", "2010", 1, "", "Selected Poems" },
                    { "9780571244799", "", "https://covers.openlibrary.org/b/isbn/9780571244799-L.jpg", "9780571244799", "", 24.6f, "Faber & Faber", "2009", 1, "", "Selected Poems" },
                    { "9780571322862", "Djuna Barnes", "", "9780571322862", "inglês", 13.05f, "Faber & Faber, Limited", "2015", 1, "", "Nightwood" },
                    { "9780571338917", "Richard Scott", "https://covers.openlibrary.org/b/isbn/9780571338917-L.jpg", "9780571338917", "", 16.5f, "Faber & Faber", "Jul 03, 2018", 0, "", "Soho" },
                    { "9780571340811", "Jean Genet", "", "9780571340811", "inglês", 13.15f, "Faber & Faber, Limited", "2019", 1, "", "Querelle of Brest" },
                    { "9780571340828", "Jean Genet", "", "9780571340828", "inglês", 14.7f, "Faber & Faber, Limited", "2019", 1, "", "Our Lady of the Flowers" },
                    { "9780571340835", "Jean Genet", "https://covers.openlibrary.org/b/isbn/9780571340835-L.jpg", "9780571340835", "inglês", 14.7f, "Faber & Faber", "2019", 0, "", "The Thief's Journal" },
                    { "9780571340842", "Jean Genet", "", "9780571340842", "inglês", 14.7f, "Faber & Faber, Limited", "2019", 1, "", "Miracle of the Rose" },
                    { "9780571340859", "Jean Genet", "https://covers.openlibrary.org/b/isbn/9780571340859-L.jpg", "9780571340859", "inglês", 13.15f, "Faber & Faber, Limited, Faber & Faber", "2019", 1, "", "Funeral Rites" },
                    { "9780571345403", "Akwaeke Emezi", "", "9780571345403", "inglês", 13.15f, "Faber & Faber, Limited", "2019", 0, "", "Freshwater" },
                    { "9780571347681", "Graves, Robert, Jr.", "", "9780571347681", "inglês", 18.8f, "Faber & Faber, Limited", "2018", 1, "", "Selected Poems" },
                    { "9780571348046", "Mary Jean Chan", "", "9780571348046", "inglês", 16.5f, "Faber & Faber, Limited", "2019", 1, "", "Flèche" },
                    { "9780571351008", "Akwaeke Emezi", "https://covers.openlibrary.org/b/isbn/9780571351008-L.jpg", "9780571351008", "inglês", 12.75f, "Faber & Faber, Limited, FABER ET FABER", "2021", 0, "", "The Death of Vivek Oji" },
                    { "9780571351411", "Ilya Kaminsky", "", "9780571351411", "inglês", 7.5f, "Faber & Faber, Limited", "2019", 0, "", "Deaf Republic" },
                    { "9780571352470", "D. BARNES", "", "9780571352470", "inglês", 5.27f, "Faber & Faber, Limited", "2019", 0, "", "The Lydia Steptoe Stories" },
                    { "9780571354023", "Kate Tempest", "https://covers.openlibrary.org/b/isbn/9780571354023-L.jpg", "9780571354023", "inglês", 12.25f, "Faber & Faber, Incorporated", "2020", 0, "", "On Connection" },
                    { "9780571359868", "Natalie Diaz", "https://covers.openlibrary.org/b/isbn/9780571359868-L.jpg", "9780571359868", "inglês", 16.55f, "Faber & Faber, Limited", "2020", 1, "", "Postcolonial Love Poem" },
                    { "9780571361342", "Pajtim Statovci", "", "9780571361342", "inglês", 13.5f, "Faber & Faber, Limited", "2023", 2, "", "Bolla" },
                    { "9780571362264", "M. LOPEZ", "", "9780571362264", "inglês", 18.8f, "Faber & Faber, Limited", "2020", 1, "", "The Inheritance" },
                    { "9780571365081", "Thom Gunn", "", "9780571365081", "inglês", 21.7f, "Faber & Faber, Limited", "2021", 0, "", "Selected Poems" },
                    { "9780571366514", "Max Porter", "https://covers.openlibrary.org/b/isbn/9780571366514-L.jpg", "9780571366514", "", 10.5f, "Faber and Faber", "", 0, "", "The Death of Francis Bacon" },
                    { "9780571368860", "Natalie Diaz", "", "9780571368860", "inglês", 16f, "Faber & Faber, Limited", "2021", 2, "", "When My Brother Was an Aztec" },
                    { "9780571369188", "Ilya Kaminsky", "", "9780571369188", "inglês", 16.5f, "Faber & Faber, Limited", "2021", 0, "", "Dancing in Odessa" },
                    { "9780571370436", "Kae Tempest", "", "9780571370436", "inglês", 10.25f, "Faber & Faber, Limited", "2022", 0, "", "On Connection (Paperback)" },
                    { "9780571370863", "Kay Dick", "https://covers.openlibrary.org/b/isbn/9780571370863-L.jpg", "9780571370863", "inglês", 13.25f, "Faber & Faber, Limited", "2022", 0, "", "They" },
                    { "9780571378906", "Mary Jean Chan", "", "9780571378906", "inglês", 15.75f, "Faber & Faber, Limited", "2023", 1, "", "Bright Fear" },
                    { "9780571390403", "ODUBANJO G", "", "9780571390403", "inglês", 19.55f, "Faber & Faber, Limited", "2024", 1, "", "Adam" },
                    { "9780571392612", "", "", "9780571392612", "", 19.5f, "", "", 0, "", "The Man With Night Sweats (Hockney)" },
                    { "9780575094208", "Samuel R. Delany", "https://covers.openlibrary.org/b/isbn/9780575094208-L.jpg", "9780575094208", "", 14.5f, "Gollancz SF Masterworks", "Mar 14, 2010", 1, "", "Babel-17" },
                    { "9780575094994", "", "https://covers.openlibrary.org/b/isbn/9780575094994-L.jpg", "9780575094994", "inglês", 14.5f, "Gollancz", "2010", 0, "", "The Female Man" },
                    { "9780575118232", "Nicola Griffith", "https://covers.openlibrary.org/b/isbn/9780575118232-L.jpg", "9780575118232", "", 14.5f, "Gollancz", "Sep 01, 2012", 0, "", "Ammonite" },
                    { "9780575118256", "Nicola Griffith", "https://covers.openlibrary.org/b/isbn/9780575118256-L.jpg", "9780575118256", "", 14.5f, "Gollancz", "Feb 14, 2013", 1, "", "Slow River" },
                    { "9780578761800", "William E. Jones", "https://covers.openlibrary.org/b/isbn/9780578761800-L.jpg", "9780578761800", "inglês", 16.5f, "We Heard You Like Books", "2021", 0, "", "I Should Have Known Better" },
                    { "9780593093689", "Adam Eli", "https://covers.openlibrary.org/b/isbn/9780593093689-L.jpg", "9780593093689", "inglês", 10.8f, "Penguin Young Readers Group, Penguin Workshop", "2020", 0, "", "The New Queer Conscience" },
                    { "9780593094655", "Alok Vaid-Menon", "https://covers.openlibrary.org/b/isbn/9780593094655-L.jpg", "9780593094655", "", 10.8f, "Penguin Workshop", "Jun 02, 2020", 0, "", "Beyond the Gender Binary" },
                    { "9780593133385", "Torrey Peters", "", "9780593133385", "inglês", 19.4f, "Random House Publishing Group", "2021", 0, "", "Detransition, Baby" },
                    { "9780593223475", "Leo Baker", "https://covers.openlibrary.org/b/isbn/9780593223475-L.jpg", "9780593223475", "inglês", 10.8f, "Penguin Young Readers Group", "2021", 0, "", "Skate For Your Life" },
                    { "9780593223482", "Chella Man", "https://covers.openlibrary.org/b/isbn/9780593223482-L.jpg", "9780593223482", "", 10.8f, "Penguin Workshop", "Jun 01, 2021", 1, "", "Continuum" },
                    { "9780593242681", "Claude McKay", "https://covers.openlibrary.org/b/isbn/9780593242681-L.jpg", "9780593242681", "inglês", 16f, "Random House Publishing Group, Modern Library", "2022", 0, "", "Harlem Shadows: Poems" },
                    { "9780593330036", "Eloghosa Osunde", "", "9780593330036", "inglês", 12.75f, "Penguin Publishing Group", "2023", 0, "", "Vagabonds!: A Novel" },
                    { "9780593420201", "", "", "9780593420201", "", 13.45f, "", "", 0, "", "Filthy Animals" },
                    { "9780593447345", "K-Ming Chang", "", "9780593447345", "inglês", 18.5f, "Random House Publishing Group", "2023", 0, "", "Organ Meats" },
                    { "9780593469736", "Alice Wong", "", "9780593469736", "inglês", 18.75f, "Penguin Random House", "2024", 1, "", "Disability Intimacy: Essays on Love, Care, and Desire" },
                    { "9780593713037", "", "", "9780593713037", "", 15.25f, "", "", 0, "", "The Late Americans" },
                    { "9780593719695", "", "", "9780593719695", "", 21f, "", "", 0, "", "All Fours" },
                    { "9780615870861", "Jonathan Kemp", "https://covers.openlibrary.org/b/isbn/9780615870861-L.jpg", "9780615870861", "inglês", 26f, "punctum books, Punctum Books", "Sep 12, 2013", 1, "", "The Penetrated Male" },
                    { "9780679735793", "Camille Paglia", "", "9780679735793", "inglês", 23.65f, "Vintage Books", "1991", 0, "", "Sexual Personae: Art and Decadence from Nefertiti to Emily Dickinson" },
                    { "9780679754763", "Edmund White", "", "9780679754763", "inglês", 17.8f, "Vintage Books", "1998", 1, "", "The Farewell Symphony" },
                    { "9780679754794", "Edmund White", "https://covers.openlibrary.org/b/isbn/9780679754794-L.jpg", "9780679754794", "inglês", 23f, "Vintage", "October 4, 1994", 0, "", "Genet: A Biography" },
                    { "9780679755401", "Edmund White", "https://covers.openlibrary.org/b/isbn/9780679755401-L.jpg", "9780679755401", "inglês", 16.7f, "Vintage", "October 4, 1994", 0, "", "The Beautiful Room is Empty" },
                    { "9780691247939", "Anne Carson", "https://covers.openlibrary.org/b/isbn/9780691247939-L.jpg", "9780691247939", "inglês", 24.25f, "Princeton University Press", "2023", 1, "", "Eros the Bittersweet" },
                    { "9780691248615", "Sarah Nooter", "", "9780691248615", "inglês", 26f, "Princeton University Press", "2024", 0, "", "How to Be Queer: An Ancient Guide to Sexuality" },
                    { "9780711265868", "JOana Estrela", "", "9780711265868", "inglês", 18.75f, "Quarto Publishing Group UK", "2022", 0, "", "Menino, menina – My Own Way (ing)" },
                    { "9780711282674", "Gemma Rolls-Bentley", "https://covers.openlibrary.org/b/isbn/9780711282674-L.jpg", "9780711282674", "inglês", 36.75f, "Quarto Publishing Group UK", "2024", 1, "", "Queer Art" },
                    { "9780714503615", "Peter Weiss", "https://covers.openlibrary.org/b/isbn/9780714503615-L.jpg", "9780714503615", "", 15.37f, "Boyars, Marion", "October 1969", 1, "", "Marat/Sade" },
                    { "9780738215679", "Alan Downs", "", "9780738215679", "inglês", 15.9f, "Da Capo Lifelong", "2012", 0, "", "The Velvet Rage" },
                    { "9780743207140", "Jamie O'Neill", "https://covers.openlibrary.org/b/isbn/9780743207140-L.jpg", "9780743207140", "inglês", 14.7f, "Scribner, Gardners Books", "2002", 0, "", "At Swim, Two Boys" },
                    { "9780743456081", "Bell Hooks", "https://covers.openlibrary.org/b/isbn/9780743456081-L.jpg", "9780743456081", "inglês", 22f, "Washington Square Press", "2005", 0, "", "The Will to Change: Men, Masculinity, and Love" },
                    { "9780745337128", "Ciara Colin Cremin", "https://covers.openlibrary.org/b/isbn/9780745337128-L.jpg", "9780745337128", "inglês", 24.6f, "Pluto Press", "2017", 0, "", "Man-Made Woman: The Dialectics of Cross Dressing" },
                    { "9780745338743", "J. J. Bola", "https://covers.openlibrary.org/b/isbn/9780745338743-L.jpg", "9780745338743", "inglês", 14.5f, "Pluto Press", "2019", 0, "", "Mask Off: Masculinity Redefined" },
                    { "9780745339290", "Augusto Boal", "", "9780745339290", "inglês", 22f, "Pluto Press", "2019", 0, "", "Theatre of the Oppressed" },
                    { "9780745340067", "Lola Olufemi", "https://covers.openlibrary.org/b/isbn/9780745340067-L.jpg", "9780745340067", "inglês", 14.5f, "Pluto Press", "2020", 0, "", "Feminism, Interrupted: Disrupting Power" },
                    { "9780745341125", "Francoise Verges", "", "9780745341125", "inglês", 18.8f, "Pluto Press", "2021", 0, "", "A Decolonial Feminism" },
                    { "9780745341668", "Jules Joanne Gleeson", "https://covers.openlibrary.org/b/isbn/9780745341668-L.jpg", "9780745341668", "inglês", 24.6f, "Pluto Press", "2021", 1, "", "Transgender Marxism" },
                    { "9780745345673", "Françoise Vergès", "", "9780745345673", "inglês", 19.25f, "Pluto Press", "2022", 0, "", "A Feminist Theory of Violence" },
                    { "9780745349954", "Cindy Milstein", "https://covers.openlibrary.org/b/isbn/9780745349954-L.jpg", "9780745349954", "inglês", 28f, "Pluto Press", "2024", 1, "", "Constelations of Care: Anarcha-Feminism in Practice" },
                    { "9780745399515", "Mario Mieli", "https://covers.openlibrary.org/b/isbn/9780745399515-L.jpg", "9780745399515", "", 27.5f, "Pluto Press", "Jul 15, 2018", 0, "", "Towards a Gay Communism: Elements of a Homosexual Critique" },
                    { "9780746349114", "", "", "9780746349114", "", 29.5f, "", "", 1, "", "Become Ungovernable: An Abolition Feminist Ethic for Democractic Living" },
                    { "9780749397029", "Christopher Isherwood", "https://covers.openlibrary.org/b/isbn/9780749397029-L.jpg", "9780749397029", "inglês", 18.65f, "VINTAGE (RAND)", "January 14, 1993", 1, "", "Berlin Novels" },
                    { "9780751585469", "Ryan O'Connell", "https://covers.openlibrary.org/b/isbn/9780751585469-L.jpg", "9780751585469", "inglês", 13f, "Little, Brown Book Group Limited", "2023", 2, "", "Just By Looking At Him" },
                    { "9780755390977", "", "https://covers.openlibrary.org/b/isbn/9780755390977-L.jpg", "9780755390977", "", 11.55f, "Tinder Press", "", 0, "", "Tin Man" },
                    { "9780762467853", "Andy Campbell", "", "9780762467853", "inglês", 31.75f, "Running Press", "2019", 2, "", "Queer x Design" },
                    { "9780771003820", "Anthony Oliveira", "", "9780771003820", "inglês", 24.5f, "McClelland & Stewart", "2024", 0, "", "Dayspring" },
                    { "9780786716746", "Dennis Cooper", "https://covers.openlibrary.org/b/isbn/9780786716746-L.jpg", "9780786716746", "inglês", 22.5f, "Carroll & Graf", "September 28, 2005", 2, "", "The Sluts" },
                    { "9780802136916", "Larry Kramer", "", "9780802136916", "inglês", 20.75f, "Grove Press", "2000", 2, "", "Faggots" },
                    { "9780802157157", "Eileen Myles", "", "9780802157157", "inglês", 28f, "Grove/Atlantic, Incorporated", "2022", 0, "", "Pathetic Literature" },
                    { "9780803218871", "", "https://covers.openlibrary.org/b/isbn/9780803218871-L.jpg", "9780803218871", "", 28.15f, "University of Nebraska Press", "2009", 1, "", "The Hermaphrodite" },
                    { "9780807006535", "Colm Tóibín", "", "9780807006535", "inglês", 21.75f, "Beacon Press", "2022", 1, "", "Vinegar Hill" },
                    { "9780807014578", "Raquel Salas Rivera", "https://covers.openlibrary.org/b/isbn/9780807014578-L.jpg", "9780807014578", "inglês", 22.32f, "Beacon Press", "2022", 2, "", "Antes que isla es volcán / Before Island Is Volcano" },
                    { "9780807014738", "Angela Chen", "https://covers.openlibrary.org/b/isbn/9780807014738-L.jpg", "9780807014738", "", 22.55f, "Beacon Press", "Sep 14, 2021", 0, "", "Ace: What Asexuality Reveals About Desire, Society, and the Meaning of Sex" },
                    { "9780807079171", "Monique Wittig", "", "9780807079171", "inglês", 26f, "Beacon Press", "1992", 0, "", "The Straight Mind" },
                    { "9780811222099", "H. D. (Hilda Doolittle)", "", "9780811222099", "inglês", 22.5f, "Norton & Company Limited, W. W.", "2022", 2, "", "Hermione" },
                    { "9780811223171", "", "https://covers.openlibrary.org/b/isbn/9780811223171-L.jpg", "9780811223171", "", 12f, "New Directions Publishing Corporation", "2014", 0, "", "The Albertine Workout" },
                    { "9780814757130", "Robert McRuer", "https://covers.openlibrary.org/b/isbn/9780814757123-L.jpg", "9780814757130", "inglês", 43f, "New York University Press", "2006", 1, "", "Crip Theory: Cultural Signs of Queerness and Disability" },
                    { "9780814777268", "Leila J. Rupp", "", "9780814777268", "inglês", 31f, "New York University Press", "2011", 0, "", "Sapphistries: A Global History of Love Between Women" },
                    { "9780815371175", "Howard Chiang", "", "9780815371175", "inglês", 85f, "Taylor & Francis Group", "2017", 0, "", "QUEER SINOPHONE CULTURES – Howard Chiang, Ari Larissa Heinrich (ed.) [paperback]" },
                    { "9780822313847", "Guy Hocquenghem", "", "9780822313847", "inglês", 25f, "Duke University Press", "1993", 0, "", "Homosexual Desire" },
                    { "9780822316633", "Jack Halberstam", "", "9780822316633", "inglês", 38f, "Duke University Press", "1995", 0, "", "Skin Shows: Gothic Horror and the Technology of Monsters" },
                    { "9780822326120", "Esther Newton", "https://covers.openlibrary.org/b/isbn/9780822326120-L.jpg", "9780822326120", "inglês", 35.25f, "Duke University Press", "2000-11-22", 0, "", "Margaret Mead Made Me Gay: Personal Essays, Public Ideas" },
                    { "9780822347255", "Sara Ahmed", "https://covers.openlibrary.org/b/isbn/9780822346661-L.jpg", "9780822347255", "inglês", 31.85f, "Duke University Press", "2010", 0, "", "The Promise of Happiness" },
                    { "9780822348047", "Elizabeth Freeman", "https://covers.openlibrary.org/b/isbn/9780822347903-L.jpg", "9780822348047", "inglês", 38f, "Duke University Press", "2010", 0, "", "Time Binds: Queer Temporalities, Queer Histories" },
                    { "9780822354284", "B. Ruby Rich", "", "9780822354284", "inglês", 43f, "Duke University Press", "2013", 0, "", "New Queer Cinema: The Director's Cut" },
                    { "9780822362241", "Donna  J. Haraway", "https://covers.openlibrary.org/b/isbn/9780822362241-L.jpg", "9780822362241", "", 43f, "Duke University Press Books", "Sep 19, 2016", 1, "", "Staying with the Trouble: Making Kin in the Chthulucene" },
                    { "9780823277520", "Kent L. Brintnall", "", "9780823277520", "inglês", 57.97f, "Fordham University Press", "2017", 1, "", "Sexual Disorientations: Queer Temporalities, Affects, Theologies" },
                    { "9780824836849", "Song Hwee Lim", "", "9780824836849", "inglês", 100f, "", "2014", 0, "", "TSAI MING-LIANG AND A CINEMA OF SLOWNESS – Song Hwee Lim" },
                    { "9780847864065", "", "https://covers.openlibrary.org/b/isbn/9780847864065-L.jpg", "9780847864065", "", 60f, "Rizzoli Electa", "Apr 16, 2019", 0, "", "Art After Stonewall: 1969-1989" },
                    { "9780854882427", "GETBSY DAVID J", "", "9780854882427", "", 25.5f, "WHITECHAPEL GAL, imusti", "Feb 01, 2016", 1, "", "Queer" },
                    { "9780857529299", "Elliot Page", "", "9780857529299", "inglês", 20.75f, "Transworld Publishers Limited", "2023", 0, "", "Pageboy: A Memoir" },
                    { "9780861542840", "Kirsty Loehr", "https://covers.openlibrary.org/b/isbn/9780861542840-L.jpg", "9780861542840", "", 15f, "Oneworld Publications", "Nov 08, 2022", 1, "", "A Short History of Queer Women" },
                    { "9780861547425", "Sunny Singh", "", "9780861547425", "inglês", 14.75f, "Magpie Books Publishers Pty, Limited", "2024", 1, "", "Hotel Arcadia" },
                    { "9780863560927", "Marwan Kaabour", "", "9780863560927", "inglês", 22f, "Saqi Books", "2024", 1, "", "The Queer Arab Glossary" },
                    { "9780863564789", "Elias Jahshan", "https://covers.openlibrary.org/b/isbn/9780863564789-L.jpg", "9780863564789", "inglês", 22.5f, "Saqi Books", "2022", 0, "", "This Arab Is Queer: An Anthology by LGBTQ+ Arab Writers" },
                    { "9780872865280", "Kevin Killian", "", "9780872865280", "inglês", 19.85f, "City Lights Books", "2009", 0, "", "Impossible Princess" },
                    { "9780880103725", "Rudolf Steiner", "", "9780880103725", "inglês", 22.5f, "Anthroposophic Press", "1994", 0, "", "How to Know Higher Worlds" },
                    { "9780940322127", "J. R. Ackerley", "", "9780940322127", "inglês", 14f, "New York Review Books", "1999", 1, "", "My Father and Myself" },
                    { "9780956251534", "Jonathan Kemp", "https://covers.openlibrary.org/b/isbn/9780956251534-L.jpg", "9780956251534", "inglês", 12.55f, "Myriad Editions", "2010", 0, "", "London Triptych" },
                    { "9780982767177", "Hal Fischer", "", "9780982767177", "inglês", 50f, "Gallery 16 Editions", "2019", 1, "", "Hal Fischer: The Gay Seventies" },
                    { "9780993414916", "Maggie Nelson", "https://covers.openlibrary.org/b/isbn/9780993414916-L.jpg", "9780993414916", "", 15.5f, "Melville House UK", "2016", 1, "", "The Argonauts" },
                    { "9780993563348", "Kate Charlesworth", "https://covers.openlibrary.org/b/isbn/9780993563348-L.jpg", "9780993563348", "inglês", 26.25f, "Myriad Editions", "2019", 0, "", "Sensible Footwear: A Girl's Guide" },
                    { "9780995716209", "Carrington, Leonora; Heti, Sheila (Introduction by), and Warner, Marina (Afterwo", "", "9780995716209", "inglês", 17.74f, "Silver Press", "2021", 0, "", "The Debutante and Other Stories" },
                    { "9780995716216", "Nell Dunn", "", "9780995716216", "inglês", 16.25f, "Silver Press Company", "2018", 0, "", "Talking to Women" },
                    { "9780995716223", "Audre Lorde", "https://covers.openlibrary.org/b/isbn/9780995716223-L.jpg", "9780995716223", "", 21f, "Silver Press", "2017", 0, "", "Your Silence Will Not Protect You" },
                    { "9780995716230", "Chantal Akerman", "https://covers.openlibrary.org/b/isbn/9780995716230-L.jpg", "9780995716230", "inglês", 21f, "Silver Press Company", "2019", 1, "", "My Mother Laughs" },
                    { "9780995716261", "Diane di Prima", "", "9780995716261", "inglês", 21f, "Silver Press Company", "2021", 1, "", "Revolutionary Letters" },
                    { "9780995716278", "Ursula K. Le Guin", "https://covers.openlibrary.org/b/isbn/9780995716278-L.jpg", "9780995716278", "inglês", 21f, "Silver Press Company", "2023", 0, "", "Space Crone" },
                    { "9780995716292", "Edna Bonhomme", "", "9780995716292", "inglês", 21f, "Silver Press Company", "2023", 2, "", "After Sex" },
                    { "9780996421898", "William E. Jones", "https://covers.openlibrary.org/b/isbn/9780996421898-L.jpg", "9780996421898", "", 15.5f, "We Heard You Like Books", "Mar 14, 2019", 1, "", "I'm Open to Anything" },
                    { "9781035007752", "Henry Hoke", "", "9781035007752", "inglês", 21.25f, "Pan Macmillan", "2023", 0, "", "Open Throat" },
                    { "9781035017621", "Theo Parish", "", "9781035017621", "inglês", 22.25f, "Pan Macmillan", "2024", 0, "", "Homebody: An Ode to an Abode" },
                    { "9781035034277", "Charlie Castelletti", "", "9781035034277", "inglês", 22.25f, "Pan Macmillan", "2024", 0, "", "He She They Us: Queer Poems" },
                    { "9781101973240", "", "", "9781101973240", "", 13.6f, "", "", 1, "", "Gender Outlaw: On Men, Women, and the Rest of Us" },
                    { "9781250794642", "Gretchen Felker-Martin", "https://covers.openlibrary.org/b/isbn/9781250794642-L.jpg", "9781250794642", "", 20.9f, "Tor Nightfire", "Feb 22, 2022", 1, "", "Manhunt" },
                    { "9781250849120", "Sarah Schulman", "", "9781250849120", "inglês", 24.5f, "Picador", "2022", 0, "", "Let the Record Show: A Political History of ACT UP New York, 1987-1993" },
                    { "9781324075943", "Billy-Ray Belcourt", "", "9781324075943", "inglês", 19.25f, "Norton & Company Limited, W. W.", "2024", 2, "", "Coexistence: Stories" },
                    { "9781338540574", "Molly Knox Ostertag", "https://covers.openlibrary.org/b/isbn/9781338540574-L.jpg", "9781338540574", "", 17f, "Graphix, GRAPHIX", "Jun 01, 2021", 0, "", "The Girl from the Sea" },
                    { "9781350132290", "Rozsika Parker", "https://covers.openlibrary.org/b/isbn/9781350132290-L.jpg", "9781350132290", "", 25.5f, "Bloomsbury Visual Arts", "Jun 21, 2019", 0, "", "The Subversive Stitch: Embroidery and the Making of the Feminine" },
                    { "9781350149175", "Rozsika Parker", "", "9781350149175", "inglês", 32.25f, "Bloomsbury Academic & Professional", "2020", 1, "", "Old Mistresses: Women, Art and Ideology" },
                    { "9781350186842", "John Mercer", "", "9781350186842", "inglês", 27.5f, "Bloomsbury Publishing Plc", "2020", 0, "", "Gay Pornography: Representatioins of Sexuality and Masculinity" },
                    { "9781350230729", "Kevin Guyan", "", "9781350230729", "inglês", 33.1f, "Bloomsbury Publishing Plc", "2022", 0, "", "Queer Data" },
                    { "9781350336698", "Mike Bartlett", "", "9781350336698", "inglês", 16.5f, "Bloomsbury Publishing Plc", "2022", 0, "", "Cock" },
                    { "9781398503212", "R. O. Kwon", "", "9781398503212", "inglês", 15.75f, "Simon & Schuster, Limited", "2022", 0, "", "Kink: Stories (Red)" },
                    { "9781398505247", "Benjamin Alire Sáenz", "", "9781398505247", "inglês", 12.25f, "Simon & Schuster, Limited", "2021", 0, "", "Aristotle and Dante Discover the Secrets of the Universe" },
                    { "9781398505278", "Benjamin Alire Sáenz", "", "9781398505278", "inglês", 12.25f, "Simon & Schuster, Limited", "2021", 0, "", "Aristotle and Dante Dive into the Waters of the World" },
                    { "9781398716360", "Greg Marshall", "", "9781398716360", "inglês", 15f, "Orion Publishing Group, Limited", "2024", 2, "", "Leg: A Memoir" },
                    { "9781399713221", "Ralf Webb", "https://covers.openlibrary.org/b/isbn/9781399713221-L.jpg", "9781399713221", "inglês", 22.25f, "Hodder & Stoughton", "2024", 2, "", "Strange Relations: Masculinity, Sexuality and Art in Mid-Century America" },
                    { "9781399812184", "Madeline Docherty", "", "9781399812184", "inglês", 25.25f, "Hodder & Stoughton", "2024", 2, "", "Gender Theory" },
                    { "9781399911269", "", "", "9781399911269", "", 20f, "", "", 1, "", "Judy Blame's Obituary" },
                    { "9781408857335", "Kate Tempest", "https://covers.openlibrary.org/b/isbn/9781408857335-L.jpg", "9781408857335", "", 15f, "Bloomsbury Publishing PLC, Bloomsbury Publishing", "Apr 17, 2017", 0, "", "The Bricks That Built the Houses" },
                    { "9781408870587", "Reni Eddo-Lodge", "https://covers.openlibrary.org/b/isbn/9781408870587-L.jpg", "9781408870587", "", 14.75f, "Bloomsbury Publishing, Bloomsbury Publishing PLC", "Aug 19, 2018", 0, "", "Why I'm No Longer Talking to White People About Race" },
                    { "9781408891384", "Madeline Miller", "https://covers.openlibrary.org/b/isbn/9781408891384-L.jpg", "9781408891384", "", 15.2f, "Bloomsbury Publishing (NY), Bloomsbury Publishing PLC", "", 0, "", "The Song of Achilles" },
                    { "9781408891575", "Rachel Holmes", "", "9781408891575", "inglês", 15f, "Bloomsbury Publishing Plc", "2020", 1, "", "The Secret Life of Dr James Barry" },
                    { "9781419743863", "Genesis P-Orridge", "https://covers.openlibrary.org/b/isbn/9781419743863-L.jpg", "9781419743863", "inglês", 27.5f, "Abrams, Inc., Abrams Press, Harry N. Abrams", "2021", 0, "", "Nonbinary: A Memoir" },
                    { "9781419749773", "Genesis P-Orridge", "https://covers.openlibrary.org/b/isbn/9781419749773-L.jpg", "9781419749773", "inglês", 19.25f, "Abrams, Inc.", "2022", 0, "", "Nonbinary: A Memoir (Paperback)" },
                    { "9781419755606", "Maryann Cocca-Leffler", "", "9781419755606", "inglês", 20.75f, "Abrams, Inc.", "2022", 1, "", "Fighting for Yes!: The Story of Disability Rights Activist Judith Heumann" },
                    { "9781419766787", "Ryan Fitzgibbon", "", "9781419766787", "inglês", 50f, "Abrams, Inc.", "2024", 0, "", "A Great Gay Book: Stories of Growth, Belonging & Other Queer Possibilities" },
                    { "9781447241218", "", "", "9781447241218", "", 16.55f, "Picador", "October 9, 2014", 0, "", "Hold Your Own" },
                    { "9781447257684", "Kate Tempest", "", "9781447257684", "inglês", 14.5f, "Pan Macmillan", "2014", 0, "", "Brand New Ancients" },
                    { "9781447280521", "Garth Greenwell", "https://covers.openlibrary.org/b/isbn/9781447280521-L.jpg", "9781447280521", "", 14.5f, "PICADOR", "Mar 23, 2017", 0, "", "What Belongs to You" },
                    { "9781447294832", "", "https://covers.openlibrary.org/b/isbn/9781447294832-L.jpg", "9781447294832", "inglês", 14.75f, "Picador", "2016", 0, "", "A Little Life" },
                    { "9781472116154", "John Waters", "https://covers.openlibrary.org/b/isbn/9781472116154-L.jpg", "9781472116154", "inglês", 12.9f, "Little, Brown Book Group Limited", "2015", 0, "", "Role Models" },
                    { "9781472119971", "Torsten Højer", "https://covers.openlibrary.org/b/isbn/9781472119971-L.jpg", "9781472119971", "", 15.75f, "Constable & Robinson", "May 10, 2016", 0, "", "Speak My Language and Other Stories: An Anthology of Gay Fiction" },
                    { "9781472157577", "John Waters", "", "9781472157577", "inglês", 14.75f, "Little, Brown Book Group Limited", "2023", 0, "", "Liarmouth" },
                    { "9781472258229", "Octavia E. Butler", "https://covers.openlibrary.org/b/isbn/9781472258229-L.jpg", "9781472258229", "inglês", 14.5f, "Headline Publishing Group", "2018", 0, "", "Kindred" },
                    { "9781472263650", "Octavia E. Butler", "https://covers.openlibrary.org/b/isbn/9781472263650-L.jpg", "9781472263650", "", 14.7f, "Headline", "Aug 20, 2019", 0, "", "Parable of the Talents" },
                    { "9781472263667", "Octavia E. Butler", "https://covers.openlibrary.org/b/isbn/9781472263667-L.jpg", "9781472263667", "inglês", 14.7f, "Headline", "Aug 20, 2019", 0, "", "Parable of the Sower" },
                    { "9781472520524", "", "https://covers.openlibrary.org/b/isbn/9781472520524-L.jpg", "9781472520524", "", 14.5f, "Bloomsbury Publishing PLC", "2014", 0, "", "Edward II" },
                    { "9781472520814", "René Girard", "", "9781472520814", "inglês", 23.5f, "Bloomsbury Academic, an imprint of Bloomsbury Publishing Plc", "2013", 1, "", "Violence and the Sacred" },
                    { "9781473205789", "Howard Hughes", "https://covers.openlibrary.org/b/isbn/9781473205789-L.jpg", "9781473205789", "", 13.05f, "Gollancz", "Mar 15, 2001", 1, "", "The Word for World is Forest" },
                    { "9781473221628", "Ursula K. Le Guin", "https://covers.openlibrary.org/b/isbn/9781473221628-L.jpg", "9781473221628", "", 13.05f, "Gollancz", "Mar 20, 2017", 0, "", "The Left Hand of Darkness" },
                    { "9781473230989", "Ursula K. Le Guin", "", "9781473230989", "inglês", 14.25f, "Orion Publishing Group, Limited", "2020", 0, "", "Worlds of Exile and Illusion" },
                    { "9781473613157", "Sjón", "https://covers.openlibrary.org/b/isbn/9781473613157-L.jpg", "9781473613157", "inglês", 13.05f, "Hodder & Stoughton", "2017", 1, "", "Moonstone: The Boy Who Never Was" },
                    { "9781474620406", "Jane Bowles", "https://covers.openlibrary.org/b/isbn/9781474620406-L.jpg", "9781474620406", "inglês", 15f, "Orion Publishing Group, Limited", "2021", 0, "", "Two Serious Ladies" },
                    { "9781474620437", "Jane Bowles", "", "9781474620437", "inglês", 13.5f, "Orion Publishing Group, Limited", "2021", 1, "", "Plain Pleasures" },
                    { "9781476700403", "", "", "9781476700403", "", 19.65f, "", "", 0, "", "I'm Special and Other Lies We Tell Ourselves" },
                    { "9781478001621", "Jack Halberstam", "https://covers.openlibrary.org/b/isbn/9781478001621-L.jpg", "9781478001621", "inglês", 35f, "Duke University Press", "2019-01-09", 1, "", "Female Masculinity" },
                    { "9781478008330", "Esther Newton", "https://covers.openlibrary.org/b/isbn/9781478008330-L.jpg", "9781478008330", "", 28.25f, "Duke University Press Books", "Apr 10, 2020", 0, "", "My Butch Career: A Memoir" },
                    { "9781478011088", "Jack Halberstam", "https://covers.openlibrary.org/b/isbn/9781478011088-L.jpg", "9781478011088", "inglês", 38.25f, "Duke University Press Books", "2020-10-29", 0, "", "Wild Things: The Disorder of Desire" },
                    { "9781478019381", "McKenzie Wark", "", "9781478019381", "inglês", 24.95f, "Duke University Press", "2023", 0, "", "Raving" },
                    { "9781478030478", "Susan Stryker", "https://covers.openlibrary.org/b/isbn/9781478030478-L.jpg", "9781478030478", "inglês", 38.75f, "Duke University Press", "2024", 1, "", "When Monsters Speak: A Susan Stryker Reader" },
                    { "9781479827770", "Delany", "https://covers.openlibrary.org/b/isbn/9781479827770-L.jpg", "9781479827770", "", 36.4f, "NYU Press", "Apr 30, 2019", 0, "", "Times Square Red, Times Square Blue" },
                    { "9781479874569", "José Esteban Muñoz", "https://covers.openlibrary.org/b/isbn/9781479874569-L.jpg", "9781479874569", "", 28f, "NYU Press, New York University Press", "Apr 23, 2019", 2, "", "Cruising Utopia: The Then and There of Queer Futurity" },
                    { "9781487011789", "Marcus McCann", "https://covers.openlibrary.org/b/isbn/9781487011789-L.jpg", "9781487011789", "inglês", 18.5f, "House of Anansi Press", "2023", 0, "", "Park Cruising" },
                    { "9781501312830", "Carol J. Adams", "", "9781501312830", "inglês", 28.95f, "", "2015", 0, "", "The Sexual Politics of Meat: A Feminist-Vegetarian Critical Theory" },
                    { "9781501759505", "Greta LaFleur", "https://covers.openlibrary.org/b/isbn/9781501759505-L.jpg", "9781501759505", "", 49.7f, "Cornell University Press", "Oct 15, 2021", 1, "", "Trans Historical: Gender Plurality Before the Modern" },
                    { "9781503612396", "Sa'ed Atshan", "https://covers.openlibrary.org/b/isbn/9781503612396-L.jpg", "9781503612396", "inglês", 33.5f, "Stanford University Press", "2020", 1, "", "Queer Palestine and the Empire of Critique" },
                    { "9781509813865", "Edmund White", "https://covers.openlibrary.org/b/isbn/9781509813865-L.jpg", "9781509813865", "inglês", 14.5f, "Pan Macmillan", "2016", 1, "", "A Boy's Own Story" },
                    { "9781509830008", "Kate Tempest", "", "9781509830008", "inglês", 14.5f, "Pan Macmillan", "2016", 0, "", "Let Them Eat Chaos" },
                    { "9781509830022", "Kate Tempest", "", "9781509830022", "inglês", 14.5f, "Pan Macmillan", "2018", 0, "", "Running upon the Wires" },
                    { "9781509839407", "David France", "https://covers.openlibrary.org/b/isbn/9781509839407-L.jpg", "9781509839407", "inglês", 18.8f, "Pan Macmillan", "2017", 1, "", "How to Survive a Plague" },
                    { "9781509857128", "Olivia Laing", "", "9781509857128", "inglês", 16f, "Pan Macmillan", "2022", 0, "", "Everybody: A Book About Freedom" },
                    { "9781509866175", "Amelia Abraham", "", "9781509866175", "inglês", 16.25f, "Pan Macmillan", "2020", 0, "", "Queer Intentions: A (Personal) Journey Through LGBTQ+ Culture" },
                    { "9781509874675", "Garth Greenwell", "https://covers.openlibrary.org/b/isbn/9781509874675-L.jpg", "9781509874675", "", 13.8f, "Picador", "Jan 21, 2021", 1, "", "Cleanness" },
                    { "9781509874705", "Garth Greenwell", "", "9781509874705", "inglês", 22.25f, "Pan Macmillan", "2024", 0, "", "Small Rain" },
                    { "9781509885589", "Jericho Brown", "", "9781509885589", "inglês", 16.55f, "Pan Macmillan", "2018", 1, "", "The New Testament" },
                    { "9781517900199", "Annie Sprinkle", "", "9781517900199", "inglês", 46.12f, "University of Minnesota Press", "2021", 0, "", "Assuming the Ecosexual Position: The Earth as Lover" },
                    { "9781517911041", "Jack Parlett", "", "9781517911041", "inglês", 40.8f, "University of Minnesota Press", "2022", 0, "", "The Poetics of Cruising: Queer Visual Culture from Whitman to Grindr" },
                    { "9781517911188", "Hil Malatino", "https://covers.openlibrary.org/b/isbn/9781517911188-L.jpg", "9781517911188", "inglês", 17f, "University of Minnesota Press", "Sep 01, 2020", 1, "", "Trans Care" },
                    { "9781517913182", "Nicholas de Villiers", "", "9781517913182", "inglês", 50f, "University of Minnesota Press", "2022", 0, "", "CRUISY, SLEEPY, MELANCHOLY: Sexual Disorientation in the Films of Tsai Ming-Liang" },
                    { "9781524748562", "Gengoroh Tagame", "https://covers.openlibrary.org/b/isbn/9781524748562-L.jpg", "9781524748562", "inglês", 30.75f, "Knopf Doubleday Publishing Group, Pantheon", "2022", 1, "", "Out Colors" },
                    { "9781524854010", "Omar Sakr", "https://covers.openlibrary.org/b/isbn/9781524854010-L.jpg", "9781524854010", "", 17.75f, "Andrews McMeel Publishing", "Jan 14, 2020", 1, "", "The Lost Arabs" },
                    { "9781526142825", "Andy Campbell", "https://covers.openlibrary.org/b/isbn/9781526142825-L.jpg", "9781526142825", "inglês", 29.75f, "Manchester University Press", "2020", 1, "", "Bound Together: Leather, Sex, Archives, and Contemporary Art" },
                    { "9781526604989", "Tomasz Jedrowski", "https://covers.openlibrary.org/b/isbn/9781526604989-L.jpg", "9781526604989", "inglês", 13.8f, "Bloomsbury Publishing Plc", "2021", 0, "", "Swimming in the Dark" },
                    { "9781527294219", "", "", "9781527294219", "", 18f, "", "", 0, "", "The Sun Isn't Out Long Enough" },
                    { "9781529007671", "Andrea Lawlor", "https://covers.openlibrary.org/b/isbn/9781529007671-L.jpg", "9781529007671", "inglês", 13.4f, "Pan Macmillan, INTERART", "2020", 0, "", "Paul Takes the Form of a Mortal Girl" },
                    { "9781529012590", "Julia Armfield", "https://covers.openlibrary.org/b/isbn/9781529012590-L.jpg", "9781529012590", "", 13.05f, "Picador", "Mar 19, 2020", 0, "", "Salt Slow" },
                    { "9781529017250", "Julia Armfield", "", "9781529017250", "inglês", 13.5f, "Pan Macmillan", "2023", 0, "", "Our Wives Under The Sea" },
                    { "9781529020472", "Jericho Brown", "", "9781529020472", "inglês", 15.9f, "Pan Macmillan", "2019", 0, "", "The Tradition" },
                    { "9781529045260", "Kate Tempest", "", "9781529045260", "inglês", 15f, "Pan Macmillan", "2021", 0, "", "Paradise" },
                    { "9781529068788", "Douglas Stuart", "https://covers.openlibrary.org/b/isbn/9781529068788-L.jpg", "9781529068788", "inglês", 14.75f, "Pan Macmillan, PAN MACMILLAN", "2023", 0, "", "Young Mungo" },
                    { "9781529073119", "Kae Tempest", "", "9781529073119", "inglês", 15.5f, "Pan Macmillan", "2023", 0, "", "Divisible by Itself and One" },
                    { "9781529076783", "Jamaica Kincaid", "", "9781529076783", "inglês", 14.75f, "Pan Macmillan", "2022", 0, "", "At the Bottom of the River" },
                    { "9781529077124", "Jamaica Kincaid", "", "9781529077124", "inglês", 14.75f, "Pan Macmillan", "2022", 1, "", "Annie John" },
                    { "9781529092066", "Imogen Binnie", "", "9781529092066", "inglês", 14.75f, "Pan Macmillan", "2022", 0, "", "Nevada" },
                    { "9781529092660", "Simon Avery", "", "9781529092660", "inglês", 14.5f, "Pan Macmillan", "2023", 0, "", "Hand in Hand with Love: An Anthology of Queer Classic Poetry" },
                    { "9781529110760", "Andrew Holleran", "", "9781529110760", "inglês", 13.95f, "Penguin Random House", "2019", 0, "", "Dancer from the Dance" },
                    { "9781529111361", "Sarah Schulman", "", "9781529111361", "inglês", 13.6f, "Penguin Random House", "2019", 0, "", "People in Trouble" },
                    { "9781529111675", "Zahra Hankir", "", "9781529111675", "inglês", 15.8f, "Penguin Random House", "2020", 1, "", "Our Women on the Ground: Essays by Arab Women" },
                    { "9781529111705", "Pauline Delabroy-Allard", "", "9781529111705", "inglês", 13.4f, "Penguin Random House", "2021", 0, "", "All About Sarah" },
                    { "9781529111965", "K-Ming Chang", "", "9781529111965", "inglês", 13.25f, "Penguin Random House", "2022", 0, "", "Bestiary" },
                    { "9781529113341", "Maggie Nelson", "", "9781529113341", "inglês", 16.5f, "Penguin Random House", "2022", 0, "", "On Freedom: Four Songs of Care and Constraint" },
                    { "9781529114218", "K-Ming Chang", "", "9781529114218", "inglês", 15f, "Penguin Random House", "2023", 0, "", "Gods of Want: Stories" },
                    { "9781529114478", "Seán Hewitt", "", "9781529114478", "inglês", 16.25f, "Penguin Random House", "2023", 1, "", "All Down Darkness Wide (Paperback)" },
                    { "9781529115321", "Andrew McMillan", "", "9781529115321", "inglês", 16.25f, "Penguin Random House", "2022", 0, "", "100 Queer Poems" },
                    { "9781529115338", "Andrew McMillan", "", "9781529115338", "inglês", 16.25f, "Penguin Random House", "2023", 0, "", "100 Queer Poems (Paperback)" },
                    { "9781529151145", "Katy Hessel", "", "9781529151145", "inglês", 36.25f, "Cornerstone Publishing", "2022", 0, "", "The Story of Art Without Men" },
                    { "9781529156096", "Katy Hessel", "", "9781529156096", "inglês", 16.75f, "Penguin Books, Limited", "2024", 2, "", "The Story of Art Without Men (Paperback)" },
                    { "9781529328059", "Daisy Jones", "https://covers.openlibrary.org/b/isbn/9781529328059-L.jpg", "9781529328059", "inglês", 14.75f, "Hodder & Stoughton", "2022", 1, "", "All the Things She Said" },
                    { "9781529377750", "Kit Heyam", "https://covers.openlibrary.org/b/isbn/9781529377750-L.jpg", "9781529377750", "inglês", 25f, "Basic Books", "2022", 0, "", "Before We Were Trans: A New History of Gender" },
                    { "9781529377767", "Kit Heyam", "https://covers.openlibrary.org/b/isbn/9781529377767-L.jpg", "9781529377767", "inglês", 16.25f, "Murray Press, John", "2023", 1, "", "Before We Were Trans: A New History of Gender (Paperback)" },
                    { "9781529404869", "Samra Habib", "https://covers.openlibrary.org/b/isbn/9781529404869-L.jpg", "9781529404869", "inglês", 15f, "Quercus", "2019", 0, "", "We Have Always Been Here: A Queer Muslim Memoir" },
                    { "9781529920642", "Zahra Hankir", "", "9781529920642", "inglês", 16.25f, "Penguin Random House", "2024", 1, "", "Eyeliner: A Cultural History" },
                    { "9781529922554", "Lauren Elkin", "", "9781529922554", "inglês", 19.25f, "Penguin Random House", "2024", 2, "", "Art Monsters: Unruly Bodies in Feminist Art (Paperback)" },
                    { "9781541644373", "Ted Gioia", "https://covers.openlibrary.org/b/isbn/9781541644373-L.jpg", "9781541644373", "", 23.5f, "Basic Books", "Apr 20, 2021", 1, "", "Music" },
                    { "9781541699212", "George Chauncey", "https://covers.openlibrary.org/b/isbn/9781541699212-L.jpg", "9781541699212", "", 24.05f, "Basic Books", "Apr 09, 2019", 0, "", "Gay New York" },
                    { "9781549304002", "Maia Kobabe", "https://covers.openlibrary.org/b/isbn/9781549304002-L.jpg", "9781549304002", "inglês", 23.75f, "Lion Forge", "2019", 0, "", "Gender Queer: A Memoir" },
                    { "9781551527208", "Casey Plett", "https://covers.openlibrary.org/b/isbn/9781551527208-L.jpg", "9781551527208", "inglês", 22f, "Arsenal Pulp Press", "2018", 0, "", "Little Fish" },
                    { "9781551527819", "Amber Dawn", "https://covers.openlibrary.org/b/isbn/9781551527819-L.jpg", "9781551527819", "inglês", 23.5f, "Arsenal Pulp Press", "2019", 0, "", "Hustling Verse: An Anthology of Sex Workers' Poetry" },
                    { "9781551528113", "Joshua Whitehead", "https://covers.openlibrary.org/b/isbn/9781551528113-L.jpg", "9781551528113", "", 25.1f, "Arsenal Pulp Press", "Sep 22, 2020", 0, "", "Love After the End: An Anthology of Two-Spirit & Indigiqueer Speculative Fiction" },
                    { "9781551528564", "Casey Plett", "", "9781551528564", "inglês", 20.75f, "Arsenal Pulp Press", "2021", 1, "", "A Dream of a Woman" },
                    { "9781551528854", "Jason Purcell", "https://covers.openlibrary.org/b/isbn/9781551528854-L.jpg", "9781551528854", "inglês", 20.75f, "Arsenal Pulp Press", "2022", 2, "", "Swollening" },
                    { "9781551529011", "David Ly", "", "9781551529011", "inglês", 25.5f, "Arsenal Pulp Press", "2022", 0, "", "Queer Little Nightmares: An Anthology of Monstrous Fiction and Poetry" },
                    { "9781556520747", "Assata Shakur", "", "9781556520747", "inglês", 20f, "L. Hill Books", "2001", 0, "", "Assata: An Autobiography" },
                    { "9781556591044", "Timothy Liu", "https://covers.openlibrary.org/b/isbn/9781556591044-L.jpg", "9781556591044", "inglês", 21.5f, "Copper Canyon Press", "1995", 1, "", "Burnt Offerings" },
                    { "9781556596292", "Akwaeke Emezi", "https://covers.openlibrary.org/b/isbn/9781556596292-L.jpg", "9781556596292", "inglês", 18f, "Copper Canyon Press", "2022", 0, "", "Content Warning: Everything" },
                    { "9781556596346", "", "", "9781556596346", "", 19.25f, "", "", 1, "", "Diaries of a Terrorist" },
                    { "9781558612457", "Michael Silverstone", "", "9781558612457", "inglês", 30.5f, "Feminist Press", "1999", 2, "", "Queen Then and Now: The David R. Kessler Lectures 2002-2020" },
                    { "9781558618374", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9781558618374-L.jpg", "9781558618374", "", 30.4f, "The Feminist Press at CUNY", "Sep 17, 2013", 1, "", "Testo Junkie" },
                    { "9781566895477", "T Fleischmann", "https://covers.openlibrary.org/b/isbn/9781566895477-L.jpg", "9781566895477", "", 19.99f, "Coffee House Press", "Jun 04, 2019", 0, "", "Time Is the Thing a Body Moves Through: An Essay" },
                    { "9781580056892", "", "https://covers.openlibrary.org/b/isbn/9781580056892-L.jpg", "9781580056892", "", 22.9f, "Seal Press", "2017", 1, "", "Transgender History: The Roots of Today's Revolution" },
                    { "9781580469562", "Renée Levine Packer", "https://covers.openlibrary.org/b/isbn/9781580469562-L.jpg", "9781580469562", "", 29.21f, "University of Rochester Press", "Oct 22, 2018", 1, "", "Gay Guerrilla: Julius Eastman and His Music" },
                    { "9781580936286", "Jonathan D. Katz", "", "9781580936286", "inglês", 60f, "Monacelli Press, Incorporated", "2023", 0, "", "About Face: Stonewall, Revolt, and New Queer Art" },
                    { "9781583226988", "Octavia E. Butler", "https://covers.openlibrary.org/b/isbn/9781583226988-L.jpg", "9781583226988", "inglês", 16f, "Seven Stories Press", "2005", 0, "", "Bloodchild and Other Stories" },
                    { "9781584350774", "Tony Duvert", "https://covers.openlibrary.org/b/isbn/9781584350774-L.jpg", "9781584350774", "inglês", 18.75f, "Semiotext(e), Distributed by the MIT Press", "2010", 1, "", "Diary of An Innocent" },
                    { "9781584350811", "", "", "9781584350811", "", 14.6f, "Semiotext(e)", "2010", 0, "", "The Screwball Asses" },
                    { "9781584350989", "Chris Kraus", "https://covers.openlibrary.org/b/isbn/9781584350989-L.jpg", "9781584350989", "inglês", 15.65f, "Semiotext(e), Distributed by the MIT Press", "2011", 0, "", "Where Art Belongs" },
                    { "9781584351115", "", "", "9781584351115", "", 16.7f, "Semiotext(e)", "2012", 0, "", "An Arab Melancholia" },
                    { "9781584351122", "", "https://covers.openlibrary.org/b/isbn/9781584351122-L.jpg", "9781584351122", "inglês", 20f, "Semiotex(e)", "2012", 2, "", "The Uprising: On Poetry and Finance" },
                    { "9781584351641", "Kathy Acker", "", "9781584351641", "inglês", 15.65f, "Semiotexte/Smart Art", "2015", 0, "", "I'm Very Into You: Correspondence 1995-1996" },
                    { "9781584351719", "Boyd McDonald", "", "9781584351719", "inglês", 18.75f, "Semiotexte/Smart Art", "2015", 0, "", "Cruising the Movies: A Sexual Guide to Oldies on TV" },
                    { "9781584351740", "Derek Mccormack", "", "9781584351740", "inglês", 13.55f, "Semiotexte/Smart Art", "2015", 1, "", "The Well-Dressed Wound" },
                    { "9781584351757", "Robert Glück", "https://covers.openlibrary.org/b/isbn/9781584351757-L.jpg", "9781584351757", "", 19.8f, "Semiotext(e)", "May 13, 2016", 1, "", "Communal Nude: Collected Essays" },
                    { "9781584351948", "Abdellah Taïa", "https://covers.openlibrary.org/b/isbn/9781584351948-L.jpg", "9781584351948", "inglês", 15.65f, "Semiotext(e)", "2017", 0, "", "Another Morocco: Selected Stories" },
                    { "9781584351993", "Hervé Guibert", "", "9781584351993", "inglês", 17.85f, "", "2017", 0, "", "Crazy for Vincent" },
                    { "9781590170281", "Jean Genet", "", "9781590170281", "inglês", 23.5f, "New York Review Books", "2003", 0, "", "Prisoner of Love" },
                    { "9781590173787", "Tove Jansson", "", "9781590173787", "inglês", 8.75f, "New York Review Books", "2010", 0, "", "Fair Play" },
                    { "9781590173954", "J. R. Ackerley", "https://covers.openlibrary.org/b/isbn/9781590173954-L.jpg", "9781590173954", "inglês", 15.75f, "New York Review Books", "2000", 0, "", "We Think the World of You" },
                    { "9781590176016", "Dorothy Baker", "", "9781590176016", "inglês", 22.25f, "New York Review of Books, Incorporated, The", "2012", 0, "", "Cassandra at the Wedding" },
                    { "9781590176658", "Miron Bialoszewski", "", "9781590176658", "inglês", 19.4f, "New York Review of Books, Incorporated, The", "2014", 1, "", "A Memoir of the Warsaw Uprising" },
                    { "9781590177259", "", "https://covers.openlibrary.org/b/isbn/9781590177259-L.jpg", "9781590177259", "", 19.45f, "The New York Review of Books, Inc", "2014", 1, "", "Last Words From Montmartre" },
                    { "9781590178447", "Linda Rosenkrantz", "", "9781590178447", "inglês", 16.2f, "", "2015", 0, "", "Talk" },
                    { "9781592702671", "Matthew Burgess", "https://covers.openlibrary.org/b/isbn/9781592702671-L.jpg", "9781592702671", "", 23.15f, "Enchanted Lion Books", "May 19, 2020", 1, "", "Drawing On Walls: A Story of Keith Haring" },
                    { "9781593761950", "", "https://covers.openlibrary.org/b/isbn/9781593761950-L.jpg", "9781593761950", "inglês", 20.25f, "Soft Skull Press, Distributed by Publishers Group West", "2008", 1, "", "That's Revolting!: Queer Strategies for Resisting Assimilation" },
                    { "9781593767051", "", "https://covers.openlibrary.org/b/isbn/9781593767051-L.jpg", "9781593767051", "inglês", 18f, "Soft Skull Press", "2022", 0, "", "High-Risk Homosexual: A Memoir" },
                    { "9781595588166", "Sarah Schulman", "", "9781595588166", "inglês", 24.25f, "New Press, The", "2012", 1, "", "Ties That Bind: Familial Homophobia and Its Consequences" },
                    { "9781597112086", "Nan Goldin", "", "9781597112086", "inglês", 52.75f, "Aperture Foundation", "2012", 1, "", "The Ballad of Sexual Dependency" },
                    { "9781597114769", "", "https://covers.openlibrary.org/b/isbn/9781597114769-L.jpg", "9781597114769", "", 33.82f, "Aperture", "2019", 1, "", "Through Positive Eyes" },
                    { "9781597115285", "Sunil Gupta", "https://covers.openlibrary.org/b/isbn/9781597115285-L.jpg", "9781597115285", "inglês", 32.5f, "Aperture Foundation, Incorporated", "2022", 0, "", "We Were Here: Sexuality, Photography, and Cultural Difference" },
                    { "9781598532784", "Joe Brainard", "", "9781598532784", "inglês", 22.95f, "Library of America, The", "2013", 0, "", "The Collected Writings of Joe Brainard" },
                    { "9781606997185", "Various", "https://covers.openlibrary.org/b/isbn/9781606997185-L.jpg", "9781606997185", "", 45.5f, "Fantagraphics Books", "Aug 13, 2013", 0, "", "No Straight Lines: Four Decades of Queer Comics" },
                    { "9781611854381", "Anthony Veasna So", "", "9781611854381", "inglês", 13.25f, "Grove/Atlantic, Incorporated", "2022", 0, "", "Afterparties" },
                    { "9781611856569", "Frank O'Hara", "", "9781611856569", "inglês", 19.25f, "Grove/Atlantic, Incorporated", "2022", 0, "", "Meditations in an Emergency" },
                    { "9781612194004", "James Baldwin", "https://covers.openlibrary.org/b/isbn/9781612194004-L.jpg", "9781612194004", "inglês", 16.7f, "Melville House", "2014", 0, "", "James Baldwin: The Last Interview and Other Conversations" },
                    { "9781612196169", "Martin Luther King Jr.", "https://covers.openlibrary.org/b/isbn/9781612196169-L.jpg", "9781612196169", "inglês", 17.3f, "Melville House", "2017", 0, "", "Martin Luther King, Jr.: The Last Interview and Other Conversations" },
                    { "9781612197319", "Kathy Acker", "https://covers.openlibrary.org/b/isbn/9781612197319-L.jpg", "9781612197319", "", 17.7f, "Melville House", "Mar 01, 2019", 0, "", "Kathy Acker: The Last Interview and Other Conversations" },
                    { "9781612197791", "Ursula K. Le Guin", "https://covers.openlibrary.org/b/isbn/9781612197791-L.jpg", "9781612197791", "", 17.75f, "Melville House", "Feb 05, 2019", 0, "", "Ursula K. Le Guin: The Last Interview and Other Conversations" },
                    { "9781620975763", "", "https://covers.openlibrary.org/b/isbn/9781620975763-L.jpg", "9781620975763", "", 24.25f, "The New Press", "2021", 0, "", "Mouths of Rain: An Anthology of Black Lesbian Thought" },
                    { "9781629637969", "Lynn Breedlove", "https://covers.openlibrary.org/b/isbn/9781629637969-L.jpg", "9781629637969", "inglês", 23.7f, "PM Press", "2020", 0, "", "Queercore: How to Punk a Revolution" },
                    { "9781629639710", "Shuli Branson", "", "9781629639710", "inglês", 28f, "PM Press", "2022", 0, "", "Surviving the Future: Abolitionist Queer Strategies" },
                    { "9781632061683", "Rajiv Mohabir", "https://covers.openlibrary.org/b/isbn/9781632061683-L.jpg", "9781632061683", "", 20.75f, "Restless Books", "Aug 02, 2022", 0, "", "Antiman" },
                    { "9781635900170", "David Wojnarowicz", "https://covers.openlibrary.org/b/isbn/9781635900170-L.jpg", "9781635900170", "inglês", 17.75f, "MIT Press", "2018", 1, "", "Weight of the Earth: The Tape Journals of David Wojnarowicz" },
                    { "9781635900385", "Franco Bifo Berardi", "", "9781635900385", "inglês", 20f, "MIT Press", "2019", 2, "", "Breathing: Chaos and Poetry" },
                    { "9781635900408", "Kevin Killian", "https://covers.openlibrary.org/b/isbn/9781635900408-L.jpg", "9781635900408", "", 17.75f, "Semiotext(e)", "Dec 11, 2018", 0, "", "Fascination: Bedrooms Have Windows / Bachelors Get Lonely / Triangles in the Sand" },
                    { "9781635901184", "McKenzie Wark", "", "9781635901184", "inglês", 16.7f, "MIT Press, Semiotext(e)", "2020", 1, "", "Reverse Cowgirl" },
                    { "9781635901191", "Hervé Guibert", "https://covers.openlibrary.org/b/isbn/9781635901191-L.jpg", "9781635901191", "", 18.75f, "Semiotext(e)", "May 19, 2020", 1, "", "Written in Invisible Ink: Selected Stories" },
                    { "9781635901375", "Dennis Cooper", "", "9781635901375", "inglês", 16.7f, "semiotexte Limited", "2020", 1, "", "Castle Faggot" },
                    { "9781635901429", "Guillaume Dustan", "https://covers.openlibrary.org/b/isbn/9781635901429-L.jpg", "9781635901429", "", 23.32f, "Semiotext(e)", "May 18, 2021", 1, "", "Works: 1 – In My Room / I'm Going Out Tonight / Stronger Than Me" },
                    { "9781635901665", "Cookie Mueller", "https://covers.openlibrary.org/b/isbn/9781635901665-L.jpg", "9781635901665", "", 21.25f, "Semiotext(e)", "Apr 12, 2022", 0, "", "Walking Through Clear Water in a Pool Painted Black" },
                    { "9781635901764", "William E. Jones", "", "9781635901764", "inglês", 33f, "semiotexte Limited", "2022", 1, "", "Halsted Plays Himself" },
                    { "9781635901832", "Sean DeLear", "", "9781635901832", "inglês", 23.65f, "semiotexte Limited", "2023", 2, "", "I Could Not Believe It: The 1979 Teenage Diaries" },
                    { "9781635901924", "Jackie Wang", "", "9781635901924", "inglês", 25f, "semiotexte Limited", "2023", 0, "", "Alien Daughters Walk Into the Sun: An Almanac of Extreme Girlhood" },
                    { "9781635901948", "Guillaume Dustan", "", "9781635901948", "inglês", 25f, "semiotexte Limited", "2023", 1, "", "Nicolas Pages" },
                    { "9781635902068", "Wayne Koestenbaum", "", "9781635902068", "inglês", 22.15f, "semiotexte Limited", "2024", 1, "", "Stubble Archipelago" },
                    { "9781637150726", "Maia Kobabe", "https://covers.openlibrary.org/b/isbn/9781637150726-L.jpg", "9781637150726", "inglês", 27f, "Oni Press", "May 31, 2022", 0, "", "Gender Queer: A Memoir (Deluxe Edition)" },
                    { "9781637680384", "Michael Walsh", "", "9781637680384", "inglês", 29.5f, "Autumn House Press", "2022", 0, "", "Queer Nature: A Poetry Anthology" },
                    { "9781639442676", "Linda Rosenkrantz", "", "9781639442676", "inglês", 21.55f, "Primedia eLaunch LLC", "2021", 0, "", "Peter Hujar's Day" },
                    { "9781641293044", "Dennis Cooper", "https://covers.openlibrary.org/b/isbn/9781641293044-L.jpg", "9781641293044", "", 26f, "Soho Press", "Sep 14, 2021", 0, "", "I Wished: A Novel" },
                    { "9781641293754", "Dennis Cooper", "", "9781641293754", "inglês", 15f, "Soho Press, Incorporated", "2022", 1, "", "I Wished: A Novel (Paperback)" },
                    { "9781643620060", "Larry Mitchell", "https://covers.openlibrary.org/b/isbn/9781643620060-L.jpg", "9781643620060", "", 20f, "Nightboat Books", "Jul 02, 2019", 2, "", "The Faggots & Their Friends Between Revolutions" },
                    { "9781643620268", "Eduardo Kac", "https://covers.openlibrary.org/b/isbn/9781643620268-L.jpg", "9781643620268", "inglês", 22f, "Nightboat Books", "2021", 1, "", "Porneia: Movimento de Arte Pornô" },
                    { "9781643620336", "Andrea Abi-Karam", "https://covers.openlibrary.org/b/isbn/9781643620336-L.jpg", "9781643620336", "inglês", 26.15f, "Nightboat Books", "2020", 3, "", "We Want It All: An Anthology of Radical Trans Poetics" },
                    { "9781643620367", "Jackie Wang", "", "9781643620367", "inglês", 19.99f, "Nightboat Books", "2021", 1, "", "The Sunflower Cast a Spell to Save Us from the Void" },
                    { "9781643620749", "Camille Roy", "", "9781643620749", "inglês", 21.5f, "Nightboat Books", "2021", 0, "", "Honey Mine" },
                    { "9781643621104", "Andrea Abi-Karam", "", "9781643621104", "inglês", 20.06f, "Nightboat Books", "2021", 1, "", "Villainy" },
                    { "9781643621159", "Wayne Koestenbaum", "", "9781643621159", "inglês", 22f, "Nightboat Books", "2022", 0, "", "Ultramarine" },
                    { "9781643621487", "Aurora Mattia", "", "9781643621487", "inglês", 23.5f, "Nightboat Books", "2022", 1, "", "The Fifth Wound" },
                    { "9781643621524", "Hervé Guibert", "", "9781643621524", "inglês", 18.25f, "Nightboat Books", "2022", 1, "", "My Manservant and Me" },
                    { "9781643621562", "Assotto Saint", "", "9781643621562", "inglês", 25.5f, "Nightboat Books", "2023", 2, "", "Sacred Spells: Collected Works" },
                    { "9781643621760", "Eric Sneathen", "", "9781643621760", "inglês", 18.5f, "Nightboat Books", "2023", 1, "", "Don't Leave Me This Way" },
                    { "9781643621784", "Mark Hyatt", "", "9781643621784", "inglês", 21.25f, "Nightboat Books", "2023", 1, "", "So Much for Life: Selected Poems" },
                    { "9781643621791", "Kay Gabriel", "", "9781643621791", "inglês", 18.5f, "Nightboat Books", "2023", 0, "", "Kissing Other People or The House of Fame" },
                    { "9781643622347", "Julian Carter", "", "9781643622347", "inglês", 25f, "Nightboat Books", "2024", 1, "", "Dances of Time and Tenderness" },
                    { "9781644230244", "Michael Glover", "", "9781644230244", "inglês", 13.25f, "Zwirner Books, David", "2019", 1, "", "Thrust: A Spasmodic Pictorial History of the Codpiece in Art" },
                    { "9781644230695", "Phillipp Deines", "", "9781644230695", "inglês", 36.75f, "Zwirner Books, David", "2022", 1, "", "The Five Lives of Hilma af Klint" },
                    { "9781644230701", "John Ashbery", "https://covers.openlibrary.org/b/isbn/9781644230701-L.jpg", "9781644230701", "inglês", 13.25f, "Zwirner Books, David", "2022", 1, "", "Something Close to Music" },
                    { "9781644230886", "Derek Jarman", "", "9781644230886", "inglês", 15.5f, "Zwirner Books, David", "2023", 1, "", "Blue" },
                    { "9781644231203", "Larry Neal", "", "9781644231203", "inglês", 16.25f, "Zwirner Books, David", "2024", 1, "", "Any Day Now: Toward a Black Aesthetic" },
                    { "9781645036586", "Jack Lowery", "", "9781645036586", "inglês", 42.6f, "PublicAffairs", "2022", 0, "", "It Was Vulgar & It Was Beautiful: How AIDS Activists Used Art to Fight a Pandemic" },
                    { "9781645036661", "Hugh Ryan", "", "9781645036661", "inglês", 32.75f, "PublicAffairs", "2022", 0, "", "The Women's House of Detention: A Queer History of a Forgotten Prison" },
                    { "9781645679561", "Madeline Dyer", "https://covers.openlibrary.org/b/isbn/9781645679561-L.jpg", "9781645679561", "inglês", 22.5f, "Page Street Publishing Company", "2023", 1, "", "Being Ace" },
                    { "9781646142569", "Joana Estrela", "https://covers.openlibrary.org/b/isbn/9781646142569-L.jpg", "9781646142569", "inglês", 20f, "Levine Querido", "2023", 1, "", "Pardalita (English)" },
                    { "9781646222230", "Amelia Possanza", "", "9781646222230", "inglês", 19.5f, "Catapult", "2024", 1, "", "Lesbian Love Story: A Memoir in Archives" },
                    { "9781648230349", "Nicholas Blair", "https://covers.openlibrary.org/b/isbn/9781648230349-L.jpg", "9781648230349", "inglês", 56.25f, "powerHouse Books", "2023", 2, "", "Castro to Christopher: Gay Streets of America 1979-1986" },
                    { "9781648961571", "Ryan Pfluger", "https://covers.openlibrary.org/b/isbn/9781648961571-L.jpg", "9781648961571", "inglês", 31f, "Princeton Architectural Press", "2022", 1, "", "Holding Space: Life and Love Through a Queer Lens" },
                    { "978166801993", "", "", "978166801993", "", 19.5f, "", "", 2, "", "Pig" },
                    { "9781681370767", "Miaojin Qiu", "https://covers.openlibrary.org/b/isbn/9781681370767-L.jpg", "9781681370767", "inglês", 18.25f, "NYRB Classics", "2017", 1, "", "Notes of a Crocodile" },
                    { "9781681374314", "Robert Gluck", "", "9781681374314", "inglês", 17f, "New York Review of Books, Incorporated, The", "2020", 1, "", "Margery Kempe" },
                    { "9781681375410", "Jack Spicer", "", "9781681375410", "inglês", 16.1f, "New York Review of Books, Incorporated, The", "2021", 0, "", "After Lorca" },
                    { "9781681377629", "Pier Paolo Pasolini", "", "9781681377629", "inglês", 16.5f, "New York Review of Books, Incorporated, The", "2023", 0, "", "Boys Alive" },
                    { "9781681377643", "Pier Paolo Pasolini", "", "9781681377643", "inglês", 16.5f, "New York Review of Books, Incorporated, The", "2023", 1, "", "Theorem" },
                    { "9781681377766", "Robert Gluck", "", "9781681377766", "inglês", 22.5f, "New York Review of Books, Incorporated, The", "2023", 1, "", "About Ed" },
                    { "9781683964261", "Lee Lai", "https://covers.openlibrary.org/b/isbn/9781683964261-L.jpg", "9781683964261", "", 43.75f, "Fantagraphics, Fantagraphics Books", "May 11, 2021", 0, "", "Stone Fruit" },
                    { "9781683965275", "Gengoroh Tagame", "https://covers.openlibrary.org/b/isbn/9781683965275-L.jpg", "9781683965275", "inglês", 40.75f, "Fantagraphics Books, Fantagraphics", "2022", 0, "", "The Passion of Gengoroh Tagame: Volume 1" },
                    { "9781683965282", "Gengoroh Tagame", "", "9781683965282", "inglês", 46.75f, "Fantagraphics Books", "2022", 0, "", "The Passion of Gengoroh Tagame: Volume 2" },
                    { "9781685890797", "Bell Hooks", "https://covers.openlibrary.org/b/isbn/9781685890797-L.jpg", "9781685890797", "inglês", 20.25f, "Melville House Publishing, Melville House", "2023", 2, "", "bell hooks: The Last Interview and Other Conversations" },
                    { "9781685891053", "Melville House", "", "9781685891053", "inglês", 23.5f, "Melville House Publishing", "2023", 0, "", "Octavia E. Butler: The Last Interview and Other Conversations" },
                    { "9781728254326", "Juno Dawson", "https://covers.openlibrary.org/b/isbn/9781728254326-L.jpg", "9781728254326", "inglês", 15.5f, "TBS/GBS/Transworld", "2021", 0, "", "This Book is Gay" },
                    { "9781736863305", "Letterform Archive", "", "9781736863305", "inglês", 52.75f, "Letterform Archive", "2022", 1, "", "Strikethrough!: Typographic Messages of Protest" },
                    { "9781737797944", "Steve Lawrence", "", "9781737797944", "inglês", 59f, "Primary Information", "2023", 0, "", "Newspaper" },
                    { "9781737842828", "William E. Jones", "", "9781737842828", "inglês", 17.75f, "We Heard You Like Books", "2023", 1, "", "I Didn't See It Coming" },
                    { "9781739123826", "Golnoosh Nour", "", "9781739123826", "inglês", 15f, "Muswell Press, The", "2023", 1, "", "Queer Life, Queer Love: II" },
                    { "9781739169763", "Helen Bowell", "", "9781739169763", "inglês", 16.55f, "Fourteen Publishing", "2023", 0, "", "Bi+ Lines: An Anthology of Contemporary Bi+ Poets" },
                    { "9781739169770", "", "", "9781739169770", "", 14f, "", "", 1, "", "Two Dying Lovers Holding a Cat" },
                    { "9781739220723", "Alison Rumfitt", "https://covers.openlibrary.org/b/isbn/9781739220723-L.jpg", "9781739220723", "inglês", 16.5f, "Cipher Press", "October 5, 2023", 0, "", "Brainwyrms" },
                    { "9781739220747", "Emerson Whitney", "", "9781739220747", "inglês", 16.5f, "Cipher Press", "2023", 1, "", "Daddy Boy" },
                    { "9781739220761", "", "", "9781739220761", "", 16.25f, "", "", 2, "", "Ten Bridges I've Burnt" },
                    { "9781739220785", "Emerson Whitney", "", "9781739220785", "", 16.5f, "Cipher Press", "2024-03-21", 2, "", "Heaven" },
                    { "9781739364922", "Kevin Killian", "", "9781739364922", "inglês", 21.4f, "Antenne Books Limited", "2023", 1, "", "Argento Series" },
                    { "9781739364953", "", "", "9781739364953", "", 14.3f, "", "", 0, "", "Prayers Manifestos Bravery" },
                    { "9781739364984", "", "", "9781739364984", "", 25f, "", "", 1, "", "Disquiet Drive" },
                    { "9781739606763", "Sam Ashby", "", "9781739606763", "inglês", 52.25f, "Mackaware", "2024", 0, "", "Little Joe: A Book About Queers and Cinema, Mostly" },
                    { "9781739702908", "", "", "9781739702908", "", 20f, "", "", 0, "", "My Dead Book" },
                    { "9781739702948", "", "", "9781739702948", "", 16.63f, "", "", 0, "", "Truant" },
                    { "9781739702960", "assembled by Richard Porter", "", "9781739702960", "inglês", 24.85f, "Antenne Books Limited", "2022", 0, "", "Responses to Derek Jarman's Blue (1993)" },
                    { "9781739702977", "John Wieners", "", "9781739702977", "inglês", 19.9f, "Antenne Books Limited", "2023", 1, "", "Solitary Pleasure: Selected Poems, Journals and Ephemera" },
                    { "9781739784911", "Brontez Purnell", "", "9781739784911", "inglês", 17.75f, "Cipher Press", "2022", 1, "", "Johnny Would You Love Me If My Dick Were Bigger" },
                    { "9781739784980", "So Mayer", "", "9781739784980", "inglês", 16.25f, "Cipher Press", "2023", 0, "", "Truth & Dare" },
                    { "9781770461734", "Michael DeForge", "", "9781770461734", "inglês", 20f, "Drawn & Quarterly", "2014", 1, "", "First Year Healthy" },
                    { "9781770462243", "Michael DeForge", "", "9781770462243", "inglês", 21f, "Drawn & Quarterly Publications", "2016", 0, "", "Big Kids" },
                    { "9781780992266", "", "https://covers.openlibrary.org/b/isbn/9781780992266-L.jpg", "9781780992266", "", 19.25f, "Zero Books", "2014", 1, "", "Ghosts of My Life: Writings on Depression, Hauntology and Lost Futures" },
                    { "9781781256480", "Chris Kraus", "", "9781781256480", "inglês", 12.25f, "Serpent's Tail Limited", "2016", 0, "", "I Love Dick" },
                    { "9781781257807", "Mx Eileen Myles", "https://covers.openlibrary.org/b/isbn/9781781257807-L.jpg", "9781781257807", "", 13.05f, "Serpent's Tail, Serpent", "Aug 04, 2016", 0, "", "Chelsea Girls" },
                    { "9781781258682", "Reinaldo Arenas", "", "9781781258682", "inglês", 11.6f, "Serpent's Tail Limited", "2017", 1, "", "Before Night Falls" },
                    { "9781781259313", "Neil Bartlett", "", "9781781259313", "inglês", 11.6f, "Serpent's Tail Limited", "2017", 1, "", "Ready to Catch Him Should He Fall" },
                    { "9781781259535", "Carmen Maria Machado", "https://covers.openlibrary.org/b/isbn/9781781259535-L.jpg", "9781781259535", "", 13.8f, "GARDNER", "", 1, "", "Her Body & Other Parties" },
                    { "9781781578049", "Emma Lewis", "", "9781781578049", "inglês", 56.75f, "Octopus Publishing Group", "2021", 1, "", "Photography: A Feminist History" },
                    { "9781781578292", "Rachel Smith", "https://covers.openlibrary.org/b/isbn/9781781578292-L.jpg", "9781781578292", "inglês", 21.25f, "Octopus Publishing Group", "2022", 0, "", "The Love That Dares: Letters of LGBTQ+ Love & Friendship Through History" },
                    { "9781781578698", "Flora Dunster", "", "9781781578698", "inglês", 56.75f, "Octopus Publishing Group", "2023", 0, "", "Photography: A Queer History" },
                    { "9781781683231", "", "https://covers.openlibrary.org/b/isbn/9781781683231-L.jpg", "9781781683231", "", 14.76f, "Verso, Verso Books", "2014", 0, "", "Playing the Whore: The Work of Sex Work" },
                    { "9781782273608", "Pajtim Statovci", "https://covers.openlibrary.org/b/isbn/9781782273608-L.jpg", "9781782273608", "", 11.6f, "Pushkin Press", "Apr 19, 2018", 0, "", "My Cat Yugoslavia" },
                    { "9781782275121", "Pajtim Statovci", "", "9781782275121", "inglês", 14.45f, "Pushkin Press, Limited", "2020", 1, "", "Crossing" },
                    { "9781783601691", "Maria Mies", "", "9781783601691", "inglês", 20.75f, "Zed Books, Limited", "2014", 0, "", "Patriarchy and Accumulation on a World Scale" },
                    { "9781783785834", "Jeremy Atherton Lin", "https://covers.openlibrary.org/b/isbn/9781783785834-L.jpg", "9781783785834", "inglês", 16.25f, "Granta Books", "2022", 0, "", "Gay Bar: Why We Went Out (Paperback)" },
                    { "9781783787029", "Jack Parlett", "", "9781783787029", "inglês", 16.25f, "Granta Books", "2023", 1, "", "Fire Island: A Queer History" },
                    { "9781783789290", "Catherine Lacey", "", "9781783789290", "inglês", 14.75f, "Granta Books", "2024", 0, "", "Biography of X" },
                    { "9781784709952", "Jeanette Winterson", "", "9781784709952", "inglês", 13.95f, "Penguin Random House", "2020", 0, "", "FranKISSstein (Paperback)" },
                    { "9781784742041", "Danez Smith", "", "9781784742041", "inglês", 15.9f, "Penguin Random House", "2018", 0, "", "Don't Call Us Dead" },
                    { "9781784743055", "Danez Smith", "", "9781784743055", "inglês", 15f, "Penguin Random House", "2020", 3, "", "Homie" },
                    { "9781784743703", "Warsan Shire", "", "9781784743703", "inglês", 12.25f, "Penguin Random House", "2022", 0, "", "Bless the Daughter Raised by a Voice in Her Head" },
                    { "9781784744700", "Tom Crewe", "", "9781784744700", "inglês", 16.25f, "Penguin Random House", "2023", 1, "", "The New Life" },
                    { "9781784745738", "Danez Smith", "", "9781784745738", "inglês", 22.25f, "Penguin Random House", "2024", 3, "", "Bluff" },
                    { "9781784781675", "Juliet Jacques", "https://covers.openlibrary.org/b/isbn/9781784781675-L.jpg", "9781784781675", "", 16.25f, "Verso", "Nov 15, 2016", 0, "", "Trans: A Memoir" },
                    { "9781784784409", "Valerie Solanas", "", "9781784784409", "inglês", 10.15f, "Verso Books", "2016", 1, "", "Scum Manifesto" },
                    { "9781784787691", "Angela Y. Davis", "https://covers.openlibrary.org/b/isbn/9781784787691-L.jpg", "9781784787691", "inglês", 15.9f, "Verso", "2016", 0, "", "If They Come in the Morning...: Voices of Resistance" },
                    { "9781784870515", "Rita Mae Brown", "https://covers.openlibrary.org/b/isbn/9781784870515-L.jpg", "9781784870515", "inglês", 13.05f, "Vintage Books", "2015", 0, "", "Rubyfruit Jungle" },
                    { "9781784870546", "Vita Sackville-West", "", "9781784870546", "inglês", 15.75f, "Penguin Random House", "2016", 0, "", "The Edwardians" },
                    { "9781784870843", "Virginia Woolf", "https://covers.openlibrary.org/b/isbn/9781784870843-L.jpg", "9781784870843", "inglês", 13.5f, "Penguin Random House", "2016", 0, "", "The Waves (Vintage)" },
                    { "9781784870850", "Virginia Woolf", "", "9781784870850", "inglês", 12.35f, "Penguin Random House", "2016", 0, "", "Orlando (Vintage)" },
                    { "9781784870867", "Virginia Woolf", "", "9781784870867", "inglês", 13.5f, "Penguin Random House", "2016", 0, "", "Mrs. Dalloway (Vintage)" },
                    { "9781784870874", "Virginia Woolf", "", "9781784870874", "inglês", 13.5f, "Penguin Random House", "2016", 0, "", "A Room of One's Own (Vintage)" },
                    { "9781784873875", "Derek Jarman", "https://covers.openlibrary.org/b/isbn/9781784873875-L.jpg", "9781784873875", "inglês", 16.25f, "Penguin Random House", "2018", 1, "", "Modern Nature" },
                    { "9781784875169", "Derek Jarman", "", "9781784875169", "inglês", 14.5f, "Penguin Random House", "2019", 1, "", "Smiling in Slow Motion" },
                    { "9781784876128", "Richard Wright", "", "9781784876128", "inglês", 17.1f, "Penguin Random House", "2020", 1, "", "Native Son" },
                    { "9781784876135", "Richard Wright", "https://covers.openlibrary.org/b/isbn/9781784876135-L.jpg", "9781784876135", "inglês", 15.5f, "Penguin Random House", "2020", 0, "", "Black Boy" },
                    { "9781784876722", "Vita Sackville-West", "https://covers.openlibrary.org/b/isbn/9781784876722-L.jpg", "9781784876722", "", 15.5f, "Vintage Classics", "May 01, 2021", 1, "", "Love Letters" },
                    { "9781784877330", "Derek Jarman", "", "9781784877330", "inglês", 19.25f, "Penguin Random House", "2022", 0, "", "Pharmacopoeia" },
                    { "9781784877347", "Lou Sullivan", "", "9781784877347", "inglês", 15f, "Penguin Random House", "2021", 1, "", "Youngman: Selected Diaries of Lou Sullivan" },
                    { "9781784877392", "Langston Hughes", "", "9781784877392", "inglês", 14.75f, "Penguin Random House", "2022", 0, "", "Not Without Laughter" },
                    { "9781784877415", "Langston Hughes", "", "9781784877415", "inglês", 14.75f, "Penguin Random House", "2022", 0, "", "The Ways of White Folks" },
                    { "9781784877484", "Jeanette Winterson", "", "9781784877484", "inglês", 13.65f, "Penguin Random House", "2021", 1, "", "Oranges Are Not the Only Fruit" },
                    { "9781784877682", "Derek Jarman", "https://covers.openlibrary.org/b/isbn/9781784877682-L.jpg", "9781784877682", "inglês", 14.75f, "Penguin Random House", "2022", 1, "", "Dancing Ledge" },
                    { "9781784877781", "Manuel Puig", "", "9781784877781", "inglês", 15f, "Penguin Random House", "2022", 1, "", "Kiss of the Spider Woman" },
                    { "9781784878757", "Jack Hilton", "https://covers.openlibrary.org/b/isbn/9781784878757-L.jpg", "9781784878757", "inglês", 25f, "Penguin Random House", "2024", 1, "", "Caliban Shrieks" },
                    { "9781784879020", "Anne Carson", "https://covers.openlibrary.org/b/isbn/9781784879020-L.jpg", "9781784879020", "inglês", 15f, "Penguin Random House", "2024", 1, "", "Autobiography of Red" },
                    { "9781785780714", "Meg-John Barker", "https://covers.openlibrary.org/b/isbn/9781785780714-L.jpg", "9781785780714", "inglês", 23.75f, "Icon", "2016", 0, "", "Queer: A Graphic History" },
                    { "9781785784521", "Meg-John Barker", "https://covers.openlibrary.org/b/isbn/9781785784521-L.jpg", "9781785784521", "inglês", 23.75f, "Icon Books, Limited, Icon Books Ltd", "2019", 0, "", "Gender: A Graphic Guide" },
                    { "9781785784903", "Cathia Jenainati", "", "9781785784903", "inglês", 20.75f, "Icon Books, Limited", "2019", 0, "", "Feminism: A Graphic Guide" },
                    { "9781785786532", "Meg-John Barker", "https://covers.openlibrary.org/b/isbn/9781785786532-L.jpg", "9781785786532", "inglês", 23.75f, "Icon Books, Limited", "2021", 0, "", "Sexuality: A Graphic Guide" },
                    { "9781785786914", "Laura Harvey", "", "9781785786914", "inglês", 22f, "Icon Books, Limited", "2021", 0, "", "Class: A Graphic Guide" },
                    { "9781785786952", "Catherine McCormack", "https://covers.openlibrary.org/b/isbn/9781785786952-L.jpg", "9781785786952", "inglês", 15.5f, "Icon Books, Limited", "2021", 0, "", "Women in the Picture: Women, Art and the Power of Looking" },
                    { "9781785788512", "Lamya H", "", "9781785788512", "inglês", 16.5f, "Icon Books, Limited", "2024", 1, "", "Hijab Butch Blues: A Memoir" },
                    { "9781785927461", "Alex Iantaffi", "https://covers.openlibrary.org/b/isbn/9781785927461-L.jpg", "9781785927461", "inglês", 22.35f, "Jessica Kingsley Publishers", "2018", 1, "", "How to Understand Your Gender" },
                    { "9781786031617", "Maria Ana Peixe Dias", "https://covers.openlibrary.org/b/isbn/9781786031617-L.jpg", "9781786031617", "inglês", 13.5f, "Quarto Publishing Group UK, Frances Lincoln Children's Books", "2018", 1, "", "Outside" },
                    { "9781786074409", "Joseph Cassara", "https://covers.openlibrary.org/b/isbn/9781786074409-L.jpg", "9781786074409", "", 13.05f, "Oneworld, One World", "Sep 19, 2018", 0, "", "The House of Impossible Beauties" },
                    { "9781786079244", "", "https://covers.openlibrary.org/b/isbn/9781786079244-L.jpg", "9781786079244", "", 25.2f, "Oneworld Publications", "Apr 13, 2021", 0, "", "The Mysterious Correspondent: New Stories" },
                    { "9781786223937", "Jay Hulme", "https://covers.openlibrary.org/b/isbn/9781786223937-L.jpg", "9781786223937", "inglês", 16.9f, "Church House Publishing, Church House Pub", "2021", 1, "", "The Backwater Sermons" },
                    { "9781786225252", "Jay Hulme", "", "9781786225252", "inglês", 16.9f, "Hymns Ancient & Modern Ltd", "2023", 1, "", "The Vanishing Song" },
                    { "9781786495259", "André Aciman", "https://covers.openlibrary.org/b/isbn/9781786495259-L.jpg", "9781786495259", "", 12f, "atlantic books uk", "Jun 29, 2017", 0, "", "Call Me By Your Name" },
                    { "9781786496256", "Jordy Rosenberg", "", "9781786496256", "inglês", 13.45f, "Atlantic Books, Limited", "2019", 1, "", "Confessions of the Fox" },
                    { "9781786632630", "Aaron Bastani", "https://covers.openlibrary.org/b/isbn/9781786632630-L.jpg", "9781786632630", "inglês", 14.5f, "Verso", "2020-06-16", 0, "", "Fully Automated Luxury Communism" },
                    { "9781786632661", "Legacy Russell", "https://covers.openlibrary.org/b/isbn/9781786632661-L.jpg", "9781786632661", "", 14.5f, "Verso", "Sep 29, 2020", 1, "", "Glitch Feminism: A Manifesto" },
                    { "9781786633835", "Jenny Hval", "https://covers.openlibrary.org/b/isbn/9781786633835-L.jpg", "9781786633835", "inglês", 14.5f, "", "2018", 0, "", "Paradise Rot" },
                    { "9781786637307", "Sophie Lewis", "https://covers.openlibrary.org/b/isbn/9781786637307-L.jpg", "9781786637307", "", 14.5f, "Verso", "Aug 31, 2021", 0, "", "Full Surrogacy Now: Feminism Against Family" },
                    { "9781786690685", "Umberto Saba", "", "9781786690685", "inglês", 14.5f, "Head of Zeus", "2017", 1, "", "Ernesto" },
                    { "9781786694874", "Diana Souhami", "", "9781786694874", "inglês", 13.4f, "Head of Zeus", "2021", 1, "", "No Modernism Without Lesbians" },
                    { "9781786890276", "David Wojnarowicz", "", "9781786890276", "inglês", 15.9f, "Canongate Books", "2017", 1, "", "Close to The Knives: A Memoir of Disintegration" },
                    { "9781786890887", "Thomas Page McBee", "https://covers.openlibrary.org/b/isbn/9781786890887-L.jpg", "9781786890887", "inglês", 13.05f, "Canongate Books", "2017", 1, "", "Man Alive: A True Story of Violence, Forgiveness and Becoming a Man" },
                    { "9781786891006", "Thomas Page McBee", "", "9781786891006", "inglês", 14.7f, "Canongate Books", "2019", 0, "", "Amateur: A Reckoning with Gender, Identity and Masculinity" },
                    { "9781786892478", "Ali Smith", "", "9781786892478", "inglês", 13.45f, "Canongate Books", "2018", 0, "", "Girl Meets Boy" },
                    { "9781787332263", "Seán Hewitt", "https://covers.openlibrary.org/b/isbn/9781787332263-L.jpg", "9781787332263", "", 14.5f, "Jonathan Cape", "Aug 01, 2020", 1, "", "Tongues of Fire" },
                    { "9781787332355", "Anne Carson", "https://covers.openlibrary.org/b/isbn/9781787332355-L.jpg", "9781787332355", "inglês", 18.75f, "Penguin Random House", "2024", 0, "", "Wrong Norma" },
                    { "9781787333192", "Andrew McMillan", "https://covers.openlibrary.org/b/isbn/9781787333192-L.jpg", "9781787333192", "inglês", 12f, "Penguin Random House", "2021", 0, "", "Pandemonium" },
                    { "9781787333383", "Seán Hewitt", "", "9781787333383", "inglês", 18.25f, "Penguin Random House", "2022", 0, "", "All Down Darkness Wide" },
                    { "9781787333703", "Ocean Vuong", "", "9781787333703", "inglês", 16f, "Penguin Random House", "2022", 1, "", "Time is a Mother (Paperback)" },
                    { "9781787333840", "Ocean Vuong", "https://covers.openlibrary.org/b/isbn/9781787333840-L.jpg", "9781787333840", "inglês", 18.25f, "Penguin Random House", "2022", 0, "", "Time Is a Mother" },
                    { "9781787334045", "Andrew Holleran", "", "9781787334045", "inglês", 22f, "Penguin Random House", "2022", 0, "", "The Kingdom of Sand" },
                    { "9781787334182", "Jeanette Winterson", "", "9781787334182", "inglês", 17.25f, "Penguin Random House", "2023", 1, "", "Night Side of The River: Ghost Stories" },
                    { "9781787334274", "Seán Hewitt", "", "9781787334274", "inglês", 19.25f, "Penguin Random House", "2024", 1, "", "Rapture's Road" },
                    { "9781787334595", "Allen Bratton", "", "9781787334595", "inglês", 21.25f, "Penguin Random House", "2024", 0, "", "Henry Henry" },
                    { "9781787702059", "Saleem Haddad", "https://covers.openlibrary.org/b/isbn/9781787702059-L.jpg", "9781787702059", "", 13.25f, "Europa Editions (UK) Ltd", "Sep 19, 2019", 1, "", "Guapa" },
                    { "9781787704640", "Lillian Fishman", "https://covers.openlibrary.org/b/isbn/9781787704640-L.jpg", "9781787704640", "inglês", 14.75f, "Europa Editions, Incorporated", "2023", 0, "", "Acts of Service" },
                    { "9781787753396", "Jos Twist", "", "9781787753396", "inglês", 22f, "Kingsley Publishers, Jessica", "2020", 1, "", "Non-Binary Lives" },
                    { "9781787756182", "Meg-John Barker", "https://covers.openlibrary.org/b/isbn/9781787756182-L.jpg", "9781787756182", "inglês", 22f, "Kingsley Publishers, Jessica", "2022", 1, "", "How to Understand Your Sexuality" },
                    { "9781788162258", "Carmen Maria Machado", "https://covers.openlibrary.org/b/isbn/9781788162258-L.jpg", "9781788162258", "inglês", 15.2f, "Serpent's Tail Limited", "2020", 0, "", "In the Dream House" },
                    { "9781788163248", "Saidiya V. Hartman", "https://covers.openlibrary.org/b/isbn/9781788163248-L.jpg", "9781788163248", "", 16.8f, "Serpent's Tail", "Mar 04, 2021", 2, "", "Wayward Lives, Beautiful Experiments" },
                    { "9781788164504", "Robert Walser", "", "9781788164504", "inglês", 13.15f, "Serpent's Tail Limited", "2020", 1, "", "Jakob von Gunten (Paperback)" },
                    { "9781788164511", "Langston Hughes", "", "9781788164511", "inglês", 11.6f, "Serpent's Tail Limited", "2020", 0, "", "Selected Poems" },
                    { "9781788165150", "Mark Gevisser", "https://covers.openlibrary.org/b/isbn/9781788165150-L.jpg", "9781788165150", "inglês", 15.9f, "Profile Books Limited, Profile Books", "2021", 0, "", "The Pink Line: The World's Queer Frontiers" },
                    { "9781788166539", "Jayne County", "", "9781788166539", "inglês", 18.8f, "Serpent's Tail Limited", "2021", 0, "", "Man Enough To Be a Woman" },
                    { "9781788166713", "John Rechy", "https://covers.openlibrary.org/b/isbn/9781788166713-L.jpg", "9781788166713", "inglês", 15.9f, "Serpent's Tail Limited, Serpent's Tail", "2021", 1, "", "City of Night" },
                    { "9781788167734", "Randy Shilts", "https://covers.openlibrary.org/b/isbn/9781788167734-L.jpg", "9781788167734", "inglês", 19f, "TBS/GBS/Transworld", "2021", 0, "", "And The Band Played On" },
                    { "9781788168144", "Saidiya V. Hartman", "", "9781788168144", "inglês", 14.5f, "Serpent's Tail Limited", "2021", 1, "", "Lose Your Mother: A Journey Along the Atlantic Slave Route" },
                    { "9781788168397", "Hervé Guibert", "", "9781788168397", "inglês", 15.9f, "Serpent's Tail Limited", "2021", 1, "", "To the Friend Who Did Not Save My Life" },
                    { "9781788169912", "Esi Edugyan", "https://covers.openlibrary.org/b/isbn/9781788169912-L.jpg", "9781788169912", "inglês", 16.25f, "Serpent's Tail Limited", "2024", 1, "", "Out of The Sun: Essays at the Crossroads of Race" },
                    { "9781788731577", "Laboria Cuboniks", "https://covers.openlibrary.org/b/isbn/9781788731577-L.jpg", "9781788731577", "", 11.6f, "Verso", "Oct 02, 2018", 0, "", "The Xenofeminist Manifesto: A Politics for Alienation" },
                    { "9781788732345", "Pam Mitchell", "https://covers.openlibrary.org/b/isbn/9781788732345-L.jpg", "9781788732345", "", 19f, "Verso", "Oct 02, 2018", 0, "", "Pink Triangles: Radical Perspectives on Gay Liberation" },
                    { "9781788732376", "Aubrey Walter", "", "9781788732376", "inglês", 18.8f, "Verso Books, Verso", "2018", 0, "", "Come Together: The Years of Gay Liberation 1970-73" },
                    { "9781788735339", "McKenzie Wark", "", "9781788735339", "inglês", 16.55f, "Verso Books", "2021", 1, "", "Capital Is Dead: Is This Something Worse?" },
                    { "9781788735384", "Breanne Fahs", "https://covers.openlibrary.org/b/isbn/9781788735384-L.jpg", "9781788735384", "inglês", 29f, "Verso", "Mar 24, 2020", 0, "", "Burn It Down: Feminist Manifestos for the Revolution" },
                    { "9781788737371", "Andrea Long Chu", "https://covers.openlibrary.org/b/isbn/9781788737371-L.jpg", "9781788737371", "inglês", 11.6f, "Verso", "Oct 29, 2019", 0, "", "Females" },
                    { "9781788737838", "Richard Sennett", "https://covers.openlibrary.org/b/isbn/9781788737838-L.jpg", "9781788737838", "inglês", 14.75f, "Verso Books, Verso", "2022", 0, "", "Designing Disorder: Experiments and Disruptions in the City" },
                    { "9781788738620", "Jacqueline Rose", "https://covers.openlibrary.org/b/isbn/9781788738620-L.jpg", "9781788738620", "inglês", 14.76f, "Verso Books, Verso", "2020", 0, "", "Sexuality in the Field of Vision" },
                    { "9781788738958", "Jenny Hval", "https://covers.openlibrary.org/b/isbn/9781788738958-L.jpg", "9781788738958", "", 15.9f, "Verso Fiction", "Oct 06, 2020", 0, "", "Girls Against God" },
                    { "9781788739825", "Leslie Kern", "https://covers.openlibrary.org/b/isbn/9781788739825-L.jpg", "9781788739825", "", 14.75f, "Verso", "Sep 14, 2021", 0, "", "Feminist City" },
                    { "9781788739887", "Izumi Suzuki", "https://covers.openlibrary.org/b/isbn/9781788739887-L.jpg", "9781788739887", "", 16f, "Verso Fiction", "Apr 20, 2021", 0, "", "Terminal Boredom: Stories" },
                    { "9781797214856", "Billie Winter", "", "9781797214856", "inglês", 26.75f, "Chronicle Books LLC", "2024", 1, "", "Queer Power Couples: On Love and Possibility" },
                    { "9781800172791", "KINLOCH", "", "9781800172791", "inglês", 22.75f, "Carcanet Press, Limited", "2022", 0, "", "Greengown" },
                    { "9781800180567", "Laura Kate Dale", "https://covers.openlibrary.org/b/isbn/9781800180567-L.jpg", "9781800180567", "inglês", 16.25f, "Unbound", "2021", 0, "", "Gender Euphoria" },
                    { "9781800182851", "Michael Paramo", "", "9781800182851", "inglês", 14.75f, "Unbound", "2024", 0, "", "Ending the Pursuit: Asexuality, Aromanticism & Agender Identity" },
                    { "9781800183360", "", "", "9781800183360", "", 24.2f, "", "", 0, "", "Queer as Folklore: The Hidden Queer History of Myths and Monsters" },
                    { "9781800810129", "Paula Dalla Rosa", "https://covers.openlibrary.org/b/isbn/9781800810129-L.jpg", "9781800810129", "inglês", 19.25f, "Serpent's Tail Limited", "2022", 0, "", "An Exciting and Vivid Inner Life" },
                    { "9781800812895", "Dennis Cooper", "", "9781800812895", "inglês", 14.25f, "Serpent's Tail Limited", "2023", 1, "", "Closer" },
                    { "9781800814752", "Suzanne Heukensfeldt Jansen", "", "9781800814752", "inglês", 22f, "Serpent's Tail Limited", "2024", 1, "", "Confrontations" },
                    { "9781800814813", "June Jordan", "https://covers.openlibrary.org/b/isbn/9781800814813-L.jpg", "9781800814813", "inglês", 14.25f, "Serpent's Tail Limited", "2023", 0, "", "Haruko / Love Poems" },
                    { "9781800814844", "Constance Debré", "", "9781800814844", "inglês", 14.25f, "Profile Books Limited", "2023", 1, "", "Love Me Tender" },
                    { "9781800818613", "Heather Lewis", "", "9781800818613", "inglês", 14.75f, "Serpent's Tail Limited", "2024", 1, "", "Notice" },
                    { "9781800819849", "Constance Debré", "https://covers.openlibrary.org/b/isbn/9781800819849-L.jpg", "9781800819849", "inglês", 16.25f, "Profile Books Limited", "2024", 1, "", "Playboy (Paperback)" },
                    { "9781800819962", "", "", "9781800819962", "", 19.25f, "", "", 1, "", "Scenes of Subjection: Terror, Slavery and Self-Making in Nineteenth-Century America" },
                    { "9781802060065", "Paul Tran", "", "9781802060065", "inglês", 19.25f, "Penguin Books, Limited", "2022", 1, "", "All the Flowers Kneeling" },
                    { "9781802061147", "Charlie Porter", "", "9781802061147", "inglês", 19.65f, "Penguin Books, Limited", "2024", 1, "", "Bring No Clothes: Bloomsbury and the Philosophy of Fashion (Paperback)" },
                    { "9781802061895", "Sara Ahmed", "", "9781802061895", "inglês", 16.25f, "Penguin Books, Limited", "2024", 1, "", "The Feminist Killjoy Handbook (Paperback)" },
                    { "9781802062304", "CAConrad", "", "9781802062304", "inglês", 15.5f, "Penguin Books, Limited", "2023", 0, "", "The Book of Frank" },
                    { "9781802062458", "CAConrad", "", "9781802062458", "inglês", 18.25f, "Penguin Books, Limited", "2023", 1, "", "You Don't Have What It Takes to Be My Nemesis and Other (Soma)tics" },
                    { "9781802065411", "CAConrad", "", "9781802065411", "inglês", 16.25f, "Penguin Books, Limited", "2024", 1, "", "Listen to the Golden Boomerang Return" },
                    { "9781803287393", "Frank Wynne", "", "9781803287393", "inglês", 29.5f, "Head of Zeus", "2022", 0, "", "Queer: LGBTQ Writing from Ancient Times to Yesterday" },
                    { "9781803367569", "", "", "9781803367569", "", 14.75f, "", "", 1, "", "Cuckoo" },
                    { "9781803414300", "Mark Fisher", "https://covers.openlibrary.org/b/isbn/9781803414300-L.jpg", "9781803414300", "inglês", 15f, "Hunt Publishing Limited, John, Zero Books", "2022", 1, "", "Capitalist Realism: Is There No Alternative?" },
                    { "9781804190463", "Dan Jones - undifferentiated", "https://covers.openlibrary.org/b/isbn/9781804190463-L.jpg", "9781804190463", "inglês", 21f, "Octopus Publishing Group, Radar", "2023", 0, "", "Queer Heroes of Myth and Legend" },
                    { "9781804191354", "Dan Jones", "", "9781804191354", "inglês", 25.25f, "Octopus Publishing Group", "2024", 0, "", "Queer Villains of Myth and Legend" },
                    { "9781804270400", "Polly Barton", "https://covers.openlibrary.org/b/isbn/9781804270400-L.jpg", "9781804270400", "", 20.75f, "Fitzcarraldo Editions", "Mar 16, 2023", 0, "", "Porn: An Oral History" },
                    { "9781804270424", "Ian Penman", "https://covers.openlibrary.org/b/isbn/9781804270424-L.jpg", "9781804270424", "", 18.25f, "Fitzcarraldo Editions", "Apr 19, 2023", 0, "", "Fassbinder Thousand of Mirrors" },
                    { "9781804270776", "Sheila Heti", "", "9781804270776", "inglês", 16.25f, "Fitzcarraldo Editions", "2024", 0, "", "Alphabetical Diaries" },
                    { "9781804291283", "Alessandro Giammei", "", "9781804291283", "inglês", 24.25f, "Verso Books", "2023", 1, "", "Heretical Aesthetics: Pasolini on Painting" },
                    { "9781804291566", "Jules Gill-Peterson", "https://covers.openlibrary.org/b/isbn/9781804291566-L.jpg", "9781804291566", "inglês", 18.75f, "Verso Books", "2024", 1, "", "A Short History of Trans Misogyny" },
                    { "9781804292617", "McKenzie Wark", "https://covers.openlibrary.org/b/isbn/9781804292617-L.jpg", "9781804292617", "inglês", 22f, "Verso Books", "2023", 1, "", "Love and Money, Sex and Death: A Memoir" },
                    { "9781804292945", "Lynne Segal", "", "9781804292945", "inglês", 26.5f, "Verso Books", "2023", 0, "", "Lean On Me: A Politics of Radical Care" },
                    { "9781804440162", "Soula Emmanuel", "", "9781804440162", "inglês", 14.75f, "Footnote Press Ltd", "2024", 1, "", "Wild Geese" },
                    { "9781804440322", "Paul Baker", "https://covers.openlibrary.org/b/isbn/9781804440322-L.jpg", "9781804440322", "inglês", 24.75f, "Footnote Press Ltd", "2023", 0, "", "Camp!: The Story of the Attitude That Conquered the World" },
                    { "9781804470411", "Dvijka", "", "9781804470411", "inglês", 12.3f, "Renard Press Ltd.", "2023", 0, "", "Queer Ukraine: An Anthology of LGBTQI+ Ukrainian Voices During Wartime" },
                    { "9781804991237", "Nicola Dinan", "https://covers.openlibrary.org/b/isbn/9781804991237-L.jpg", "9781804991237", "inglês", 14.75f, "Penguin Books, Limited", "2024", 0, "", "Bellies" },
                    { "9781805300878", "Annabelle Hirsch", "https://covers.openlibrary.org/b/isbn/9781805300878-L.jpg", "9781805300878", "inglês", 35.5f, "Canongate Books", "2023", 0, "", "A History of Women in 101 Objects" },
                    { "9781838110161", "Matt Bates", "", "9781838110161", "inglês", 15f, "Muswell Press, The", "2021", 0, "", "Queer Life, Queer Love: I" },
                    { "9781838171629", "Mónica Ojeda", "", "9781838171629", "inglês", 14f, "Dead Ink", "2022", 0, "", "Jawbone" },
                    { "9781838390006", "Brontez Purnell", "", "9781838390006", "inglês", 15f, "Cipher Press", "2021", 0, "", "Since I Laid My Burden Down" },
                    { "9781838390020", "Alison Rumfitt", "https://covers.openlibrary.org/b/isbn/9781838390020-L.jpg", "9781838390020", "inglês", 16.5f, "Cipher Press", "2021", 1, "", "Tell Me I'm Worthless" },
                    { "9781838390044", "Peter Scalpello", "https://covers.openlibrary.org/b/isbn/9781838390044-L.jpg", "9781838390044", "inglês", 16.25f, "Cipher Press", "2022", 0, "", "Limbic" },
                    { "9781838390082", "Juliet Jacques", "", "9781838390082", "inglês", 18f, "Cipher Press", "2022", 1, "", "Front Lines: Trans Journalism 2007-2021" },
                    { "9781838664206", "Immy Humes", "", "9781838664206", "inglês", 29.75f, "Phaidon Press Limited", "2022", 0, "", "The Only Woman" },
                    { "9781838854317", "Travis Alabanza", "", "9781838854317", "inglês", 24.6f, "Canongate Books", "2022", 0, "", "None of the Above: Reflections on Life Beyond the Binary" },
                    { "9781838854331", "Travis Alabanza", "", "9781838854331", "inglês", 16f, "Canongate Books", "2023", 0, "", "None of the Above (Paperback)" },
                    { "9781838858957", "Andrew McMillan", "https://covers.openlibrary.org/b/isbn/9781838858957-L.jpg", "9781838858957", "inglês", 22f, "Canongate Books", "2024", 0, "", "pity" },
                    { "9781838950101", "Bryan Washington", "https://covers.openlibrary.org/b/isbn/9781838950101-L.jpg", "9781838950101", "inglês", 14.25f, "Atlantic Books, Limited", "2021", 0, "", "Memorial" },
                    { "9781838956585", "Randy Shilts", "", "9781838956585", "inglês", 14.76f, "Atlantic Books, Limited", "2022", 1, "", "The Mayor of Castro Street: The Life and Times of Harvey Milk" },
                    { "9781838957223", "Tony Santorella", "", "9781838957223", "inglês", 19.25f, "Atlantic Books, Limited", "2024", 1, "", "Bored Gay Werewolf" },
                    { "9781838958848", "Damon Galgut", "", "9781838958848", "inglês", 14.75f, "Atlantic Books, Limited", "2022", 0, "", "In a Strange Room" },
                    { "9781839040351", "Larry Kramer", "", "9781839040351", "inglês", 16.5f, "Hern Books, Limited, Nick", "2021", 2, "", "The Normal Heart" },
                    { "9781839760693", "Mark Steven", "https://covers.openlibrary.org/b/isbn/9781839760693-L.jpg", "9781839760693", "inglês", 27f, "Verso Books, Verso", "2023", 1, "", "Class War: A Literary History" },
                    { "9781839760969", "The Care The Care Collective", "https://covers.openlibrary.org/b/isbn/9781839760969-L.jpg", "9781839760969", "inglês", 13.25f, "Verso Books", "2020", 0, "", "The Care Manifesto: The Politics of Independence" },
                    { "9781839762123", "Dean Spade", "https://covers.openlibrary.org/b/isbn/9781839762123-L.jpg", "9781839762123", "", 13.25f, "Verso", "Oct 27, 2020", 1, "", "Mutual Aid: Building Solidarity During This Crisis (and the Next)" },
                    { "9781839762802", "Legacy Russell", "", "9781839762802", "inglês", 22f, "Verso Books", "2024", 1, "", "Black Meme: A History of the Images That Make Us" },
                    { "9781839763274", "Huw Lemmey", "https://covers.openlibrary.org/b/isbn/9781839763274-L.jpg", "9781839763274", "", 29.75f, "Verso", "May 31, 2022", 0, "", "Bad Gays: A Homosexual History" },
                    { "9781839763281", "Huw Lemmey", "https://covers.openlibrary.org/b/isbn/9781839763281-L.jpg", "9781839763281", "inglês", 15.75f, "Verso Books, Verso", "2023", 0, "", "Bad Gays: A Homosexual History (Paperback)" },
                    { "9781839763342", "Miss Major", "https://covers.openlibrary.org/b/isbn/9781839763342-L.jpg", "9781839763342", "inglês", 14.75f, "Verso Books", "2022", 0, "", "Miss Major Speaks: Conversations with a Black Trans Revolutionary" },
                    { "9781839764080", "Richard Sennett", "", "9781839764080", "inglês", 14.75f, "Verso Books", "2021", 0, "", "The Uses of Disorder: Personal Identity and City Life" },
                    { "9781839764110", "Walter Rodney", "https://covers.openlibrary.org/b/isbn/9781839764110-L.jpg", "9781839764110", "inglês", 25.5f, "Verso", "Feb 01, 2022", 0, "", "Decolonial Marxism: Essays From the Pan-African Revolution" },
                    { "9781839765711", "Matrix", "", "9781839765711", "inglês", 22f, "Verso Books", "2022", 0, "", "Making Space: Women and the Man-Made Environment" },
                    { "9781839767197", "Sophie Lewis", "https://covers.openlibrary.org/b/isbn/9781839767197-L.jpg", "9781839767197", "inglês", 13.5f, "Verso Books, Verso", "2022", 1, "", "Abolish the Family: A Manifesto for Care and Liberation" },
                    { "9781839767333", "Isabell Lorey", "", "9781839767333", "inglês", 25.5f, "Verso Books", "2022", 0, "", "Democracy in the Political Present: A Queer-Feminist Theory" },
                    { "9781839767951", "Richard Sennett", "", "9781839767951", "inglês", 22.5f, "Verso Books", "2023", 1, "", "The Hidden Injuries of Class" },
                    { "9781839768491", "Izumi Suzuki", "https://covers.openlibrary.org/b/isbn/9781839768491-L.jpg", "9781839768491", "inglês", 17f, "Verso Books", "2023", 0, "", "Hit Parade of Tears: Stories" },
                    { "9781839768859", "Chantal Jaquet", "https://covers.openlibrary.org/b/isbn/9781839768859-L.jpg", "9781839768859", "inglês", 24.25f, "Verso Books", "2023", 1, "", "Transclasses: A Theory of Social Non-Reproduction" },
                    { "9781839970436", "Kelvin Sparks", "", "9781839970436", "inglês", 21.25f, "Kingsley Publishers, Jessica", "2022", 1, "", "Trans Sex: A Guide for Adults" },
                    { "9781839971839", "Harry Nicholas", "", "9781839971839", "inglês", 19.25f, "Kingsley Publishers, Jessica", "2023", 0, "", "A Trans Man Walks Into a Gay Bar" },
                    { "9781839971952", "Lois Shearing", "", "9781839971952", "inglês", 22.25f, "Kingsley Publishers, Jessica", "2024", 1, "", "It Ain't Over til the Bisexual Speaks: An Anthology of Bisexual Voices" },
                    { "9781840226997", "", "https://covers.openlibrary.org/b/isbn/9781840226997-L.jpg", "9781840226997", "", 7.25f, "Wordsworth Editions Ltd", "2013", 0, "", "Capital: Volume 1 and 2" },
                    { "9781841150352", "Michael Cunningham", "", "9781841150352", "inglês", 10.5f, "HarperCollins Publishers Limited", "1999", 1, "", "The Hours" },
                    { "9781843914310", "Mikhail Alekseevich Kuzmin", "https://covers.openlibrary.org/b/isbn/9781843914310-L.jpg", "9781843914310", "inglês", 12.25f, "Hesperus Press", "September 28, 2007", 1, "", "Wings" },
                    { "9781843916543", "Friedo Lampe", "https://covers.openlibrary.org/b/isbn/9781843916543-L.jpg", "9781843916543", "", 15f, "Hesperus Classics", "May 01, 2019", 1, "", "At the Edge of the Night" },
                    { "9781844080816", "Anne Carson", "https://covers.openlibrary.org/b/isbn/9781844080816-L.jpg", "9781844080816", "", 19.75f, "Virago Press Ltd", "November 6, 2003", 1, "", "If Not Winter: Fragments of Sappho" },
                    { "9781844087198", "", "https://covers.openlibrary.org/b/isbn/9781844087198-L.jpg", "9781844087198", "", 16.5f, "Little, Brown UK", "2012", 0, "", "The Secret Diaries of Miss Anne Lister: 1 – I Know My Own Heart (1816-1824)" },
                    { "9781846143496", "", "https://covers.openlibrary.org/b/isbn/9781846143496-L.jpg", "9781846143496", "inglês", 20.95f, "Penguin Books Ltd.", "2012", 0, "", "Pocket Atlas of Remote Islands" },
                    { "9781846687853", "Nella Larsen", "https://covers.openlibrary.org/b/isbn/9781846687853-L.jpg", "9781846687853", "", 12.11f, "Profile Books Ltd, Serpent's Tail", "May 22, 2014", 0, "", "Quicksand & Passing" },
                    { "9781847083982", "Justin Torres", "", "9781847083982", "inglês", 14.75f, "Granta Books", "2024", 1, "", "Blackouts" },
                    { "9781847088383", "Chinelo Okparanta", "", "9781847088383", "inglês", 11.95f, "Granta Books", "2017", 0, "", "Under the Udala Trees" },
                    { "9781847771032", "", "", "9781847771032", "", 14f, "Carcanet", "2010", 0, "", "A Light Song of Light" },
                    { "9781848426313", "Tony Kushner", "https://covers.openlibrary.org/b/isbn/9781848426313-L.jpg", "9781848426313", "", 18.8f, "Nick Hern Books", "Apr 13, 2017", 2, "", "Angels in America" },
                    { "9781849765039", "Alex Pilcher", "https://covers.openlibrary.org/b/isbn/9781849765039-L.jpg", "9781849765039", "inglês", 21f, "Tate Publishing, Limited", "2017", 0, "", "A Queer Little History of Art" },
                    { "9781849766562", "Charlotte Mullins", "https://covers.openlibrary.org/b/isbn/9781849766562-L.jpg", "9781849766562", "inglês", 14.25f, "Tate Publishing, Limited, Tate Publishing(UK), Tate", "2019", 0, "", "A Little Feminist History of Art" },
                    { "9781849767156", "Travis Alabanza", "", "9781849767156", "inglês", 14.76f, "Tate Publishing, Limited", "2021", 1, "", "Gender" },
                    { "9781849767163", "Bernardine Evaristo", "https://covers.openlibrary.org/b/isbn/9781849767163-L.jpg", "9781849767163", "inglês", 14.76f, "Tate Publishing, Limited", "2021", 0, "", "Feminism" },
                    { "9781849767750", "Nathalie Olah", "", "9781849767750", "inglês", 14.76f, "Tate Publishing, Limited", "2021", 0, "", "Class" },
                    { "9781849767774", "Afua Hirsch", "", "9781849767774", "inglês", 14.76f, "Tate Publishing, Limited", "2021", 0, "", "Empire" },
                    { "9781849767842", "Rosie Haine", "https://covers.openlibrary.org/b/isbn/9781849767842-L.jpg", "9781849767842", "inglês", 12f, "Tate Publishing, Limited, TATE", "2022", 0, "", "It Isn't Rude to Be Nude" },
                    { "9781854590909", "Caryl Churchill", "https://covers.openlibrary.org/b/isbn/9781854590909-L.jpg", "9781854590909", "", 13.15f, "HERN NICK", "April 27, 1989", 1, "", "Cloud 9" },
                    { "9781857549478", "Sylvia Townsend Warner", "", "9781857549478", "inglês", 25.5f, "Fyfield Books", "2008", 0, "", "New Collected Poems" },
                    { "9781857988826", "Ursula K. Le Guin", "", "9781857988826", "inglês", 13.8f, "Millennium", "1999", 0, "", "The Dispossessed" },
                    { "9781860490026", "Simone de Beauvoir", "https://covers.openlibrary.org/b/isbn/9781860490026-L.jpg", "9781860490026", "inglês", 13.3f, "Virago Press, Limited", "1995", 0, "", "All Men Are Mortal" },
                    { "9781890159352", "", "", "9781890159352", "", 22.5f, "", "", 1, "", "The New Bottoming Book" },
                    { "9781890159360", "", "", "9781890159360", "", 22.5f, "", "", 1, "", "The New Topping Book" },
                    { "9781907112560", "", "", "9781907112560", "", 46f, "", "", 1, "", "The Ward" },
                    { "9781908745934", "Tove Jansson", "https://covers.openlibrary.org/b/isbn/9781908745934-L.jpg", "9781908745934", "inglês", 18.8f, "Sort of Books", "2021", 0, "", "Notes From an Island" },
                    { "9781908906489", "Joelle Taylor", "https://covers.openlibrary.org/b/isbn/9781908906489-L.jpg", "9781908906489", "", 15.9f, "The Westbourne Press", "Oct 05, 2021", 1, "", "C+nto & Othered Poems" },
                    { "9781910312773", "Juliet Jacques", "", "9781910312773", "inglês", 14.75f, "Influx Press", "2021", 1, "", "Variations" },
                    { "9781910695043", "Dan Fox", "https://covers.openlibrary.org/b/isbn/9781910695043-L.jpg", "9781910695043", "inglês", 19.25f, "Fitzcarraldo Editions", "2016", 0, "", "Pretentiousness: Why It Matters" },
                    { "9781910695357", "", "", "9781910695357", "", 20.9f, "Tall tall", "2017", 0, "", "This Young Monster" },
                    { "9781910924389", "", "https://covers.openlibrary.org/b/isbn/9781910924389-L.jpg", "9781910924389", "inglês", 15.65f, "Repeater Books", "2017", 0, "", "The Weird and The Eerie" },
                    { "9781911214373", "Andrew McMillan", "", "9781911214373", "inglês", 15f, "Penguin Random House", "2018", 0, "", "Playtime" },
                    { "9781911214519", "Ocean Vuong", "https://covers.openlibrary.org/b/isbn/9781911214519-L.jpg", "9781911214519", "inglês", 15.8f, "Penguin Random House, PENGUIN UK", "2017", 1, "", "Night Sky with Exit Wounds" },
                    { "9781911214526", "Maggie Nelson", "", "9781911214526", "inglês", 14.95f, "Penguin Random House", "2017", 1, "", "Bluets" },
                    { "9781911284635", "PASARIBU", "", "9781911284635", "inglês", 15f, "Tilted Axis Press", "2021", 1, "", "Happy Stories, Mostly" },
                    { "9781911343479", "RAHA", "", "9781911343479", "inglês", 16.75f, "Egg Box Publishing", "2018", 0, "", "Of Sires, Body & Faultines" },
                    { "9781911547747", "", "https://covers.openlibrary.org/b/isbn/9781911547747-L.jpg", "9781911547747", "", 15.5f, "", "", 0, "", "Real Life" },
                    { "9781911717027", "Maggie Nelson", "", "9781911717027", "inglês", 24.75f, "Vintage Publishing", "2024", 0, "", "Like Love: Essays and Conversations" },
                    { "9781912339730", "Mayumi Hosokura", "", "9781912339730", "inglês", 40f, "Mack", "2020", 1, "", "New Skin" },
                    { "9781912489404", "Liam Konemann", "", "9781912489404", "inglês", 11.3f, "Focus on the Family Publishing", "2021", 1, "", "The Appendix: Transmasculine Joy in a Transphobic Culture" },
                    { "9781912489602", "Thom James Carter", "", "9781912489602", "inglês", 11.3f, "Focus on the Family Publishing", "2022", 1, "", "They Came to Slay: The Queer Culture of D&D" },
                    { "9781912489725", "Anahit Behrooz", "", "9781912489725", "inglês", 11.3f, "Focus on the Family Publishing", "2023", 0, "", "BFFs: The Radical Potential of Female Friendship" },
                    { "9781912489848", "Jean Menzies", "", "9781912489848", "inglês", 11.3f, "Focus on the Family Publishing", "2024", 1, "", "All the Violet Tiaras: Queering the Greek Myths" },
                    { "9781913010799", "", "", "9781913010799", "", 15f, "", "", 8, "", "Fox, Closet & Fist" },
                    { "9781913090111", "", "https://covers.openlibrary.org/b/isbn/9781913090111-L.jpg", "9781913090111", "", 13.65f, "", "", 1, "", "Lote" },
                    { "9781913097073", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9781913097073-L.jpg", "9781913097073", "inglês", 19.25f, "Fitzcarraldo Editions", "2020", 0, "", "An Apartment on Uranus" },
                    { "9781913097172", "عدنية شبلي", "https://covers.openlibrary.org/b/isbn/9781913097172-L.jpg", "9781913097172", "", 16.25f, "Fitzcarraldo Editions", "", 0, "", "Minor Detail" },
                    { "9781913097233", "", "", "9781913097233", "", 14.75f, "", "", 0, "", "Box Hill" },
                    { "9781913097349", "Virginie Despentes", "https://covers.openlibrary.org/b/isbn/9781913097349-L.jpg", "9781913097349", "inglês", 16f, "Fitzcarraldo Editions", "2020", 0, "", "King Kong Theory" },
                    { "9781913097585", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9781913097585-L.jpg", "9781913097585", "inglês", 15f, "Fitzcarraldo Editions", "2021", 1, "", "Can the Monster Speak?" },
                    { "9781913111397", "Selby Wynn Schwartz", "", "9781913111397", "inglês", 15f, "Galley Beggar Press", "2023", 1, "", "After Sappho" },
                    { "9781913123031", "Joris Bas Backer", "https://covers.openlibrary.org/b/isbn/9781913123031-L.jpg", "9781913123031", "inglês", 22.25f, "Nobrow Ltd.", "2022", 0, "", "Kisses for Jet: A Coming-of-Gender Story" },
                    { "9781913437701", "MCDERMOTT", "", "9781913437701", "inglês", 16.5f, "Nine Arches Press", "2023", 1, "", "Wild Life" },
                    { "9781913462420", "Adam Zmith", "https://covers.openlibrary.org/b/isbn/9781913462420-L.jpg", "9781913462420", "inglês", 16.25f, "Watkins Media Limited", "2021", 0, "", "Deep Sniff: A History of Poppers and Queer Futures" },
                    { "9781913462482", "Mark Fisher", "https://covers.openlibrary.org/b/isbn/9781913462482-L.jpg", "9781913462482", "", 19.55f, "Repeater", "Jan 12, 2021", 1, "", "Postcapitalist Desire: The Final Lectures" },
                    { "9781913512217", "Mark Hayatt", "", "9781913512217", "inglês", 15.75f, "Peninsula Press", "2023", 1, "", "Love, Leda" },
                    { "9781913513320", "Derek Jarman", "", "9781913513320", "inglês", 15f, "House Sparrow Press", "2022", 1, "", "Through the Billboard Promised Land Without Ever Stopping" },
                    { "9781913620493", "Marvel Harris", "https://covers.openlibrary.org/b/isbn/9781913620493-L.jpg", "9781913620493", "inglês", 35f, "MACK, MACK BOOKS", "2021", 0, "", "MARVEL" },
                    { "9781913875398", "Aimee Ng", "", "9781913875398", "inglês", 44f, "Giles Limited, D.", "2023", 1, "", "Living Histories: Queer Views and Old Masters" },
                    { "9781914124211", "Adam Nathaniel Furman", "https://covers.openlibrary.org/b/isbn/9781914124211-L.jpg", "9781914124211", "", 60f, "Riba Publishing", "2022", 1, "", "Queer Spaces: An Atlas of LGBTQIA+ Places & Stories" },
                    { "9781914198144", "Christina Elizabeth Sharpe", "", "9781914198144", "inglês", 21.25f, "Daunt Books", "2023", 0, "", "Ordinary Notes" },
                    { "9781914198489", "Grace Lavery", "", "9781914198489", "inglês", 14.25f, "Daunt Books", "2023", 1, "", "Please Miss: A Heartbreaking Work of Staggering Penis" },
                    { "9781914198861", "Sam Sax", "", "9781914198861", "inglês", 14.75f, "Daunt Books", "2024", 1, "", "Yr Dead" },
                    { "9781914420580", "Willow Maclay", "", "9781914420580", "inglês", 18.2f, "Watkins Media Limited", "2023", 2, "", "Corpses, Fools and Monsters: The History and Future of Transness in Cinema" },
                    { "9781914484957", "Jessica Fern", "", "9781914484957", "inglês", 25f, "Scribe Publications", "2022", 1, "", "Polysecure: Attachment, Trauma and Consensual Nonmonogamy" },
                    { "9781914502071", "Shehan Karunatilaka", "https://covers.openlibrary.org/b/isbn/9781914502071-L.jpg", "9781914502071", "inglês", 14.75f, "Sort of Books, FABER ET FABER", "2023", 0, "", "The Seven Moons of Maali Almeida" },
                    { "9781915368645", "Gerardo Sámano Cordova", "", "9781915368645", "inglês", 16.5f, "Dead Ink", "2024", 0, "", "Monstrilio" },
                    { "9781915590602", "Jessica Fern", "", "9781915590602", "inglês", 25f, "Scribe Publications", "2023", 0, "", "Polywise: A Deeper Dive Into Navigating Open Relationships" },
                    { "9781916355361", "So Mayer", "https://covers.openlibrary.org/b/isbn/9781916355361-L.jpg", "9781916355361", "inglês", 14.75f, "Cipher Press", "2021", 0, "", "Unreal Sex: An Anthology of Queer Erotic Sci-Fi, Fantasy, and Horror" },
                    { "9781916355378", "Purnell", "", "9781916355378", "", 15f, "Cipher Press", "May 06, 2021", 0, "", "100 Boyfriends" },
                    { "9781917008006", "Michelle Tea", "", "9781917008006", "inglês", 22.5f, "Cipher Press", "2024", 1, "", "Sluts" },
                    { "9781917008020", "Juliet Jacques", "", "9781917008020", "inglês", 18.05f, "Cipher Press", "2024", 0, "", "The Woman in the Portrait: Collected Short Stories 2008-2024" },
                    { "9781922754295", "Kyle Turner", "", "9781922754295", "inglês", 25f, "Smith Street Books", "2023", 1, "", "The Queer Film Guide" },
                    { "9781933227962", "Inocência Mata", "https://covers.openlibrary.org/b/isbn/9781933227962-L.jpg", "9781933227962", "inglês", 23f, "Tagus Press", "2021", 1, "", "The Open Veils of the Postcolonial: Afrodescendants and Racisms" },
                    { "9781937658786", "Christopher Soto", "", "9781937658786", "inglês", 19f, "Nightboat", "2018", 1, "", "Nepantla: An Anthology for Queer Poets of Color" },
                    { "9781941360385", "Joseph Sheridan Lefanu", "https://covers.openlibrary.org/b/isbn/9781941360385-L.jpg", "9781941360385", "", 15.75f, "Lanternfish Press", "Nov 26, 2019", 0, "", "Carmilla" },
                    { "9781941701546", "Jean-Claude Lebensztejn", "https://covers.openlibrary.org/b/isbn/9781941701546-L.jpg", "9781941701546", "", 13.25f, "David Zwirner Books", "Aug 22, 2017", 0, "", "Pissing Figures 1280-2014" },
                    { "9781943735457", "Porsha Olayiwola", "https://covers.openlibrary.org/b/isbn/9781943735457-L.jpg", "9781943735457", "inglês", 22.3f, "Button Poetry", "2019", 1, "", "I Shimmer Sometimes, Too" },
                    { "9781943977444", "Joseph Osmundson", "", "9781943977444", "inglês", 19.5f, "Sibling Rivalry Press, LLC", "2018", 0, "", "Inside/Out" },
                    { "9781944700829", "Alex Espinoza", "https://covers.openlibrary.org/b/isbn/9781944700829-L.jpg", "9781944700829", "", 26.15f, "The Unnamed Press", "Jun 04, 2019", 0, "", "Cruising: An Intimate History of a Radical Pastime" },
                    { "9781944860370", "", "https://covers.openlibrary.org/b/isbn/9781944860370-L.jpg", "9781944860370", "", 36.5f, "Anthology Editions", "2021", 0, "", "Eye to Eye: Portraits of Lesbians" },
                    { "9781944860530", "ANOHNI", "https://covers.openlibrary.org/b/isbn/9781944860530-L.jpg", "9781944860530", "inglês", 99.25f, "Anthology Editions, LLC", "2023", 1, "", "Blacklips: Her Life and Her Many, Many Deaths" },
                    { "9781945509629", "Brontez Purnell", "https://covers.openlibrary.org/b/isbn/9781945509629-L.jpg", "9781945509629", "", 20.92f, "Silver Sprocket", "Dec 07, 2020", 1, "", "The Cruising Diaries" },
                    { "9781946022660", "Edmund White", "", "9781946022660", "inglês", 24.05f, "McNally Jackson Books", "2024", 0, "", "Nocturnes for the King of Naples" },
                    { "9781952177798", "Joe Vallese", "", "9781952177798", "inglês", 19f, "Feminist Press at The City University of New York", "2022", 0, "", "It Came from the Closet: Queer Reflections on Horror" },
                    { "9781953861207", "Caio Abreu", "", "9781953861207", "inglês", 20.92f, "Steerforth Press", "2022", 1, "", "Moldy Strawberries" },
                    { "9781978820531", "Baker A. Rogers", "", "9781978820531", "inglês", 27.25f, "Rutgers University Press", "2021", 0, "", "King of Hearts: Drag Kings in the American South" },
                    { "9781982106225", "Howard S. Becker", "", "9781982106225", "inglês", 18.8f, "Simon & Schuster, Limited, Free Press, an imprint of Simon & Schuster, Inc.", "2018", 1, "", "Outsiders: Studies in the Sociology of Deviance" },
                    { "9781982110215", "Garth Greenwell", "https://covers.openlibrary.org/b/isbn/9781982110215-L.jpg", "9781982110215", "", 23.25f, "Simon & Schuster", "Feb 09, 2021", 0, "", "Kink: Stories" },
                    { "9781984899422", "Alice Wong", "https://covers.openlibrary.org/b/isbn/9781984899422-L.jpg", "9781984899422", "", 16.75f, "Vintage", "Jun 30, 2020", 1, "", "Disability Visibility: First-Person Stories from the Twenty-First Century" },
                    { "9781999675998", "Ursula K. Le Guin", "https://covers.openlibrary.org/b/isbn/9781999675998-L.jpg", "9781999675998", "inglês", 12f, "Lawson Publishing Ltd., Ignota Books", "2019", 1, "", "The Carrier Bag Theory of Fiction" },
                    { "9781999922313", "David Wojnarowicz", "", "9781999922313", "inglês", 14.75f, "Peninsula Press", "2018", 1, "", "The Waterfront Journals" },
                    { "9782020094535", "R Barthes", "https://covers.openlibrary.org/b/isbn/9782020094535-L.jpg", "9782020094535", "francês", 13.1f, "Editions du Seuil", "December 31, 1998", 0, "", "Incidents" },
                    { "9782021312546", "Édouard Louis", "https://covers.openlibrary.org/b/isbn/9782021312546-L.jpg", "9782021312546", "", 14f, "SEUIL", "Apr 01, 2021", 0, "", "Combats et métamorphoses d'une femme" },
                    { "9782021483048", "Édouard Louis", "https://covers.openlibrary.org/b/isbn/9782021483048-L.jpg", "9782021483048", "francês", 20f, "SEUIL", "Sep 16, 2021", 0, "", "Changer : méthode" },
                    { "9782070132553", "Hervé Guibert", "", "9782070132553", "francês", 35f, "Gallimard", "2011", 0, "", "Hervé Guibert, photographe" },
                    { "9782070143986", "Arthur Dreyfus", "https://covers.openlibrary.org/b/isbn/9782070143986-L.jpg", "9782070143986", "francês", 21f, "Gallimard", "2014", 0, "", "Histoire de ma sexualité" },
                    { "9782070263295", "Jean Genet", "https://covers.openlibrary.org/b/isbn/9782070263295-L.jpg", "9782070263295", "inglês", 8.5f, "Distribooks Inc", "May 1999", 0, "", "Querelle de Brest" },
                    { "9782070336371", "", "https://covers.openlibrary.org/b/isbn/9782070336371-L.jpg", "9782070336371", "francês", 8.6f, "Gallimard", "2006", 0, "", "Mes mauvaises pensées" },
                    { "9782070343591", "Renée Vivien", "", "9782070343591", "francês", 2f, "Gallimard", "2007", 0, "", "La dame à la louve" },
                    { "9782070361175", "André Gide", "https://covers.openlibrary.org/b/isbn/9782070361175-L.jpg", "9782070361175", "inglês", 7.5f, "Folio", "October 1998", 1, "", "Les nourritures terrestres" },
                    { "9782070366569", "Michel Tournier", "https://covers.openlibrary.org/b/isbn/9782070366569-L.jpg", "9782070366569", "francês", 9.8f, "Folio", "October 1998", 1, "", "Le roi des aulnes" },
                    { "9782070367689", "Simone de Beauvoir", "", "9782070367689", "francês", 9.4f, "Gallimard, Gallimard Education", "1989", 0, "", "L'invitée" },
                    { "9782070368006", "Marquis de Sade", "https://covers.openlibrary.org/b/isbn/9782070368006-L.jpg", "9782070368006", "francês", 8.7f, "Folio", "1976", 1, "", "La philosophie dans le boudoir ou Les instituteurs immoraux" },
                    { "9782070368600", "Jean Genet", "https://covers.openlibrary.org/b/isbn/9782070368600-L.jpg", "9782070368600", "francês", 9.2f, "Folio", "", 0, "", "Notre-Dame-des-Fleurs" },
                    { "9782070368754", "André Gide", "https://covers.openlibrary.org/b/isbn/9782070368754-L.jpg", "9782070368754", "inglês", 9.2f, "Gallimard", "June 1966", 0, "", "Si le grain ne meurt" },
                    { "9782070370412", "Marguerite Yourcenar", "https://covers.openlibrary.org/b/isbn/9782070370412-L.jpg", "9782070370412", "francês", 7.6f, "Editions Gallimard", "June 1978", 1, "", "Alexis ou Le traité du vain combat / Le coup de grâce" },
                    { "9782070383351", "André Gide", "https://covers.openlibrary.org/b/isbn/9782070383351-L.jpg", "9782070383351", "francês", 7f, "Gallimard French", "December 31, 1998", 0, "", "Corydon" },
                    { "9782070387175", "Marguerite Duras", "", "9782070387175", "francês", 7.5f, "Gallimard", "2001", 0, "", "La vie matérielle" },
                    { "9782070387199", "Marguerite Yourcenar", "https://covers.openlibrary.org/b/isbn/9782070387199-L.jpg", "9782070387199", "francês", 7.5f, "Gallimard", "June 3, 1993", 0, "", "Mishima ou La vision du vide" },
                    { "9782070387311", "Hervé Guibert", "https://covers.openlibrary.org/b/isbn/9782070387311-L.jpg", "9782070387311", "francês", 9.2f, "Editions Flammarion", "October 14, 1993", 1, "", "Le protocole compassionnel" },
                    { "9782070389568", "Guibert", "https://covers.openlibrary.org/b/isbn/9782070389568-L.jpg", "9782070389568", "francês", 7.5f, "Editions Flammarion", "November 15, 1994", 0, "", "L'homme au chapeau rouge" },
                    { "9782070402670", "", "https://covers.openlibrary.org/b/isbn/9782070402670-L.jpg", "9782070402670", "francês", 7.8f, "Gallimard, Folio", "2019", 1, "", "Mémoires d'Hadrien" },
                    { "9782070407873", "Jean Genet", "https://covers.openlibrary.org/b/isbn/9782070407873-L.jpg", "9782070407873", "francês", 6.5f, "Gallimard", "March 12, 1999", 0, "", "Le condamné à mort et autres poèmes / Le funambule" },
                    { "9782070416264", "Marguerite Duras", "https://covers.openlibrary.org/b/isbn/9782070416264-L.jpg", "9782070416264", "francês", 3.5f, "Gallimard", "April 4, 2001", 0, "", "Yann Andréa Steiner" },
                    { "9782070427574", "Hervé Guibert", "https://covers.openlibrary.org/b/isbn/9782070427574-L.jpg", "9782070427574", "francês", 10.2f, "Gallimard", "February 27, 2003", 1, "", "Le mausolée des amants: journal (1976-1991)" },
                    { "9782070444342", "André Gide", "", "9782070444342", "francês", 9.8f, "Gallimard", "2012", 1, "", "Journal: une anthologie (1889-1949)" },
                    { "9782070454334", "Violette Leduc", "", "9782070454334", "", 6.5f, "FOLIO", "2013-10-17", 1, "", "Thérèse et Isabelle" },
                    { "9782070466115", "", "", "9782070466115", "", 8.9f, "", "", 0, "", "Histoire de ma sexualité" },
                    { "9782072843037", "", "", "9782072843037", "", 20f, "", "", 1, "", "Suzanne et Louise (Roman-photo)" },
                    { "9782072850981", "", "", "9782072850981", "", 9.2f, "", "", 1, "", "À l'ami qui ne m'a pas sauvé la vie" },
                    { "9782072918049", "", "https://covers.openlibrary.org/b/isbn/9782072918049-L.jpg", "9782072918049", "", 11.5f, "", "", 0, "", "Herculine Barbin dite Alexina B." },
                    { "9782072968082", "", "", "9782072968082", "", 11f, "", "", 0, "", "Monsieur Vénus" },
                    { "9782073014870", "", "", "9782073014870", "", 8f, "", "", 0, "", "Je me souviens..." },
                    { "9782080420015", "", "https://covers.openlibrary.org/b/isbn/9782080420015-L.jpg", "9782080420015", "", 21f, "Flammarion, FLAMMARION", "2023-03-08", 1, "", "3: Une aspiration au dehors - Éloge de l'amitié" },
                    { "9782081218000", "Didier Eribon", "", "9782081218000", "francês", 11f, "Flammarion", "2011", 1, "", "Michel Foucault" },
                    { "9782081231627", "Didier Eribon", "https://covers.openlibrary.org/b/isbn/9782081231627-L.jpg", "9782081231627", "", 11f, "FLAMMARION", "Dec 01, 2012", 0, "", "Réflexions sur la question gay" },
                    { "9782081270848", "", "", "9782081270848", "", 10f, "", "", 1, "", "Une morale du minoritaire" },
                    { "9782081515932", "Constance Debré", "https://covers.openlibrary.org/b/isbn/9782081515932-L.jpg", "9782081515932", "francês", 19f, "Flammarion, FLAMMARION", "2022", 0, "", "Nom" },
                    { "9782207161814", "", "", "9782207161814", "", 23.5f, "", "", 0, "", "Lecture facile" },
                    { "9782213701479", "", "", "9782213701479", "", 30f, "", "", 0, "", "MUNKEY DIARIES: Le journal intime de Jane Birkin (1957-1982)" },
                    { "9782213711997", "", "", "9782213711997", "", 30f, "", "", 0, "", "POST-SCRIPTUM: Le journal intime de Jane Birkin (1982-2013)" },
                    { "9782213721590", "", "", "9782213721590", "", 14f, "", "", 1, "", "Mon corps, ce désir, cette loi: réflexions sur la politique de la sexualité" },
                    { "9782226471055", "", "", "9782226471055", "", 52f, "", "", 0, "", "SERGE GAINSBOURG & JANE BIRKIN: L’album de famille intime" },
                    { "9782246194828", "", "", "9782246194828", "", 8.75f, "", "", 0, "", "Brouillon pour un dictionnaire des amantes" },
                    { "9782246826514", "Virginie Despentes", "https://covers.openlibrary.org/b/isbn/9782246826514-L.jpg", "9782246826514", "francês", 22f, "Bernard Grasset, GRASSET", "2022", 0, "", "Cher connard" },
                    { "9782253087557", "Virginie Despentes", "https://covers.openlibrary.org/b/isbn/9782253087557-L.jpg", "9782253087557", "", 7.7f, "LGF", "Mar 02, 2016", 0, "", "Baise-moi" },
                    { "9782253159711", "", "", "9782253159711", "", 7.9f, "", "", 0, "", "Apocalypse bébé" },
                    { "9782253237563", "", "", "9782253237563", "", 7.4f, "", "", 0, "", "Tous les hommes désirent naturellement savoir" },
                    { "9782264073730", "", "", "9782264073730", "", 6.9f, "", "", 1, "", "Play Boy" },
                    { "9782266144322", "Philippe Besson", "", "9782266144322", "francês", 7.3f, "Julliard", "2003", 0, "", "En l'absence des hommes" },
                    { "9782267030808", "", "", "9782267030808", "", 20f, "", "", 1, "", "Théâtre" },
                    { "9782267030815", "", "", "9782267030815", "", 15f, "", "", 1, "", "Romans" },
                    { "9782290235850", "", "", "9782290235850", "", 7f, "", "", 0, "", "Love Me Tender (Poche)" },
                    { "9782290385524", "", "", "9782290385524", "", 7.6f, "", "", 1, "", "Les nuits fauves" },
                    { "9782352702245", "", "", "9782352702245", "", 20f, "", "", 1, "", "Inversions dans l'art, la littérature, l'histoire, la philosophie et la science / L'amitié" },
                    { "9782354801755", "", "", "9782354801755", "", 13f, "", "", 0, "", "La pensée straight" },
                    { "9782355220869", "", "", "9782355220869", "", 15f, "", "", 0, "", "Fist" },
                    { "9782355221101", "Elsa Dorlin", "https://covers.openlibrary.org/b/isbn/9782355221101-L.jpg", "9782355221101", "", 18f, "ZONES", "Oct 12, 2017", 0, "", "Se défendre: Une philosophie de la violence" },
                    { "9782355221521", "Daisy Letourneur", "", "9782355221521", "francês", 18f, "Zones", "2022", 1, "", "On ne naît pas mec" },
                    { "9782355221743", "", "https://covers.openlibrary.org/b/isbn/9782355221743-L.jpg", "9782355221743", "", 19f, "Zones", "2021", 1, "", "Réinventer l'amour" },
                    { "9782366247022", "", "", "9782366247022", "", 12.5f, "", "", 0, "", "Écologies déviantes: Voyage en terres queers" },
                    { "9782371001114", "", "", "9782371001114", "", 18f, "", "", 0, "", "Tu aimeras ce que tu as tué" },
                    { "9782377390533", "", "", "9782377390533", "", 15f, "", "", 0, "", "The Moon Sets A Knife" },
                    { "9782377390687", "", "", "9782377390687", "", 29f, "", "", 0, "", "Conversation" },
                    { "9782379165580", "", "", "9782379165580", "", 19f, "", "", 0, "", "Tuer le bon gay" },
                    { "978241464137", "", "", "978241464137", "", 13.8f, "", "", 0, "", "In Youth Is Pleasure" },
                    { "9782707300973", "Monique Wittig", "", "9782707300973", "francês", 18.5f, "Les Éditions de Minuit, MINUIT", "1973", 0, "", "Le corps lesbien" },
                    { "9782707306111", "Marguerite Duras", "", "9782707306111", "francês", 7f, "Editions de Minuit", "1982", 1, "", "L'homme atlantique" },
                    { "9782707306395", "Marguerite Duras", "", "9782707306395", "francês", 8f, "Editions de Minuit,France", "December 31, 1998", 1, "", "La maladie de la mort" },
                    { "9782707306432", "Patrice Chéreau", "", "9782707306432", "francês", 18f, "Editions de Minuit", "1983", 1, "", "L'homme blessé" },
                    { "9782707311030", "Bernard-Marie Koltès", "", "9782707311030", "francês", 7.5f, "Editions de Minuit", "1986", 0, "", "Dans la solitude des champs de coton" },
                    { "9782707320223", "", "", "9782707320223", "", 7.9f, "", "", 1, "", "L'été 80" },
                    { "9782707345707", "", "", "9782707345707", "", 9f, "", "", 1, "", "Les guérrillères" },
                    { "9782707348296", "", "", "9782707348296", "", 9f, "", "", 1, "", "Le corps lesbien (Poche)" },
                    { "9782708704206", "Aime . Ce saire", "", "9782708704206", "francês", 5f, "Pre sence africaine, Presence Africaine", "1983", 0, "", "Cahier d'un retour au pays natal" },
                    { "9782755507751", "", "https://covers.openlibrary.org/b/isbn/9782755507751-L.jpg", "9782755507751", "", 4f, "", "", 0, "", "Ballades en argot homosexuel" },
                    { "9782757821060", "", "", "9782757821060", "", 7.7f, "", "", 0, "", "Une mélancolie arabe" },
                    { "9782757896549", "", "", "9782757896549", "", 8f, "", "", 1, "", "Changer: méthode (Poche)" },
                    { "9782809849219", "", "", "9782809849219", "", 28f, "", "", 0, "", "JANE BIRKIN: À fleur de peau" },
                    { "9782818014660", "", "", "9782818014660", "", 20f, "", "", 0, "", "Oeuvres: 1" },
                    { "9782818021309", "Alain Guiraudie", "", "9782818021309", "francês", 19f, "POL", "2014", 1, "", "Ici commence la nuit" },
                    { "9782842304782", "", "", "9782842304782", "", 26f, "", "", 1, "", "Les invisibles" },
                    { "9782842712419", "", "", "9782842712419", "", 8.95f, "", "", 0, "", "Le fils de Loth" },
                    { "9782906571907", "Tsai Ming-Liang", "https://covers.openlibrary.org/b/isbn/9782906571907-L.jpg", "9782906571907", "inglês", 45f, "Dis Voir", "October 2, 1999", 0, "", "TSAI MING-LIANG – Jean-Pierre Rehm, Olivier Joyard, Danièle Rivière [versão inglesa]" },
                    { "9782908050837", "FHAR", "https://covers.openlibrary.org/b/isbn/9782908050837-L.jpg", "9782908050837", "", 15f, "GKC", "May 16, 2013", 0, "", "Rapport contre la normalité" },
                    { "9782912464880", "Jean-Luc Lagarce", "https://covers.openlibrary.org/b/isbn/9782912464880-L.jpg", "9782912464880", "francês", 10f, "les Solitaires intempestifs", "January 1, 2000", 1, "", "Juste la fin du monde" },
                    { "9782919289424", "", "", "9782919289424", "", 15f, "", "", 1, "", "Hula hoop 2" },
                    { "9782919289516", "", "", "9782919289516", "", 15f, "", "", 0, "", "Hula hoop 3" },
                    { "9782919289578", "", "", "9782919289578", "", 15f, "", "", 0, "", "Un long sommeil" },
                    { "9782956766261", "", "https://covers.openlibrary.org/b/isbn/9782956766261-L.jpg", "9782956766261", "", 18f, "", "", 1, "", "Mes cahiers bleus" },
                    { "9783038601890", "Tadeás Ríha", "", "9783038601890", "inglês", 35f, "Park Books", "2021", 0, "", "Steel Cities" },
                    { "9783777439921", "Mirjam Zadoff", "https://covers.openlibrary.org/b/isbn/9783777439921-L.jpg", "9783777439921", "inglês", 35f, "Hirmer Verlag GmbH", "2022", 0, "", "To Be Seen: Queer Lives 1900-1950" },
                    { "9783777441085", "David Evans Frantz", "", "9783777441085", "inglês", 25f, "Hirmer Verlag GmbH", "2023", 1, "", "Trans Hirstory in 99 Objects" },
                    { "9783836547925", "", "https://covers.openlibrary.org/b/isbn/9783836547925-L.jpg", "9783836547925", "", 50f, "TASCHEN", "Nov 13, 2017", 0, "", "The Pedro Almodóvar Archives" },
                    { "9783836550512", "Dian Hanson", "", "9783836550512", "francês", 16f, "TASCHEN", "2015", 0, "", "Tom of Finland: The Complete Kake Comics" },
                    { "9783836555814", "Sebastian Schütze", "", "9783836555814", "inglês", 50f, "TASCHEN", "2015", 0, "", "Caravaggio: The Complete Works" },
                    { "9783836570695", "", "", "9783836570695", "", 16f, "", "", 0, "", "Miguel Ângelo: A obra integral de pintura, escultura e arquitectura" },
                    { "9783836574471", "Drew Zeiba", "", "9783836574471", "inglês", 75f, "TASCHEN", "2020", 0, "", "Andy Warhol: Love, Sex & Desire" },
                    { "9783836580922", "Eleanor Nairne", "https://covers.openlibrary.org/b/isbn/9783836580922-L.jpg", "9783836580922", "inglês", 20f, "TASCHEN", "2020", 0, "", "Basquiat" },
                    { "9783836581257", "TASCHEN", "", "9783836581257", "inglês", 20f, "TASCHEN", "2020", 0, "", "Egon Schiele: The Paintings" },
                    { "9783836582490", "TASCHEN", "", "9783836582490", "inglês", 20f, "TASCHEN", "2020", 0, "", "Hockney" },
                    { "9783954765997", "", "", "9783954765997", "", 40f, "", "", 4, "", "João Gabriel: A Selection of Works" },
                    { "9783956796050", "Valerie Solanas", "https://covers.openlibrary.org/b/isbn/9783956796050-L.jpg", "9783956796050", "inglês", 21.15f, "Sternberg Press", "2022", 1, "", "Up Your Ass" },
                    { "9783982389400", "William J. Simmons", "", "9783982389400", "inglês", 21.52f, "Floating Opera Press", "2022", 0, "", "Queer Formalism: The Return" },
                    { "9786077985341", "Salvador Novo", "", "9786077985341", "espanhol", 10f, "Alias", "2020", 1, "", "Sátira" },
                    { "9786120006658", "", "", "9786120006658", "", 9f, "", "", 0, "", "Spinalonga" },
                    { "9786120009178", "", "", "9786120009178", "", 9f, "", "", 0, "", "Clavicórdio" },
                    { "9786120009604", "", "", "9786120009604", "", 8f, "", "", 0, "", "Indulgência plenária" },
                    { "9786120010532", "", "", "9786120010532", "", 9f, "", "", 2, "", "Pterodáctilo" },
                    { "9786120010761", "", "", "9786120010761", "", 15f, "", "", 2, "", "O sagrado / Notas sobre o pensamento e a visão" },
                    { "9786120010785", "", "", "9786120010785", "", 12f, "", "", 1, "", "Lâmpadas acesas para aumentar o dia" },
                    { "9786120011225", "", "", "9786120011225", "", 12f, "", "", 1, "", "Desvios" },
                    { "9786120011300", "", "", "9786120011300", "", 25f, "", "", 0, "", "Bestiário: 2 – Monstro" },
                    { "9786120011379", "José Américo Olivares Esquivel", "", "9786120011379", "espanhol", 11f, "[José Américo Olivares Esquivel]", "2013", 0, "", "Ocnos" },
                    { "9786120011768", "", "", "9786120011768", "", 15f, "", "", 0, "", "Dias da noite" },
                    { "9786120012116", "", "", "9786120012116", "", 19f, "", "", 0, "", "O país das minhas vísceras" },
                    { "9786120012154", "", "", "9786120012154", "", 10f, "", "", 2, "", "A charca" },
                    { "9786120013212", "", "", "9786120013212", "", 12f, "", "", 1, "", "Em baixo" },
                    { "9786120013632", "", "", "9786120013632", "", 9f, "", "", 3, "", "Antilha" },
                    { "9786120014240", "", "", "9786120014240", "", 12f, "", "", 1, "", "Os mamíferos, as aves e os peixes" },
                    { "9786120014738", "", "", "9786120014738", "", 13f, "", "", 1, "", "Demasiado estreita, esta morte" },
                    { "9786120014813", "", "", "9786120014813", "", 14f, "", "", 0, "", "A anomalia poética" },
                    { "9786120016886", "", "", "9786120016886", "", 12f, "", "", 0, "", "Dançar em Odessa" },
                    { "9786120017289", "", "", "9786120017289", "", 16f, "", "", 0, "", "Diário selvagem" },
                    { "9786120017340", "", "", "9786120017340", "", 25.01f, "", "", 1, "", "Sala de sujos" },
                    { "9786120017784", "", "", "9786120017784", "", 11f, "", "", 1, "", "Convocação" },
                    { "9786550940478", "", "", "9786550940478", "", 12.72f, "", "", 1, "", "Lesbiandade (Feminismos plurais)" },
                    { "9786555320367", "Clarice Lispector", "https://covers.openlibrary.org/b/isbn/9786555320367-L.jpg", "9786555320367", "", 16.96f, "Rocco", "Nov 11, 2019", 0, "", "A via crucis do corpo" },
                    { "9786555530773", "", "", "9786555530773", "", 27.56f, "", "", 0, "", "Amora" },
                    { "9786555875621", "", "", "9786555875621", "", 25.44f, "", "", 1, "", "Vagas notícias de Melinha Marchiotti" },
                    { "9786556910260", "Jota Mombaça", "", "9786556910260", "português", 24.38f, "Cobogó", "2021", 1, "", "Ñ vão nos matar agora" },
                    { "9786557172476", "", "", "9786557172476", "", 36f, "", "", 0, "", "Por um comunismo transexual" },
                    { "9786557173343", "", "", "9786557173343", "", 31f, "", "", 1, "", "Quem tem medo do gênero? (Edição brasileira)" },
                    { "9786558020745", "Maria Clara Araújo dos Passos", "", "9786558020745", "português", 20f, "Civilização Brasileira", "2022", 1, "", "Pedagogia das travestilidades" },
                    { "9786559000319", "", "", "9786559000319", "", 14f, "", "", 1, "", "Volta para tua terra: Volume I – Poesia" },
                    { "9786559001828", "", "", "9786559001828", "", 14f, "", "", 1, "", "A lista da mercearia" },
                    { "9786559002634", "", "", "9786559002634", "", 13f, "", "", 7, "", "Erosão" },
                    { "9786559003181", "", "", "9786559003181", "", 14f, "", "", 1, "", "Volta para tua terra: Volume II – Prosa" },
                    { "9786559004201", "", "", "9786559004201", "", 13f, "", "", 1, "", "Memórias do corpo e seus ismos" },
                    { "9786559004560", "", "https://covers.openlibrary.org/b/isbn/9786559004560-L.jpg", "9786559004560", "português", 13.5f, "Editora Urutau", "2023", 6, "", "Giz" },
                    { "9786559004843", "", "", "9786559004843", "", 13f, "", "", 2, "", "Carta de amor ao pesadelo" },
                    { "9786559005031", "", "", "9786559005031", "", 16f, "", "", 1, "", "Macunaíma" },
                    { "9786559006717", "", "", "9786559006717", "", 13f, "", "", 0, "", "Um dia serei humano" },
                    { "9786559007585", "", "", "9786559007585", "", 13.5f, "", "", 16, "", "Livro do Daniel e Outros textos" },
                    { "9786559007707", "", "", "9786559007707", "", 14f, "", "", 2, "", "Volta para tua terra: Volume III - Não há abril sem imigrantes" },
                    { "9786559052851", "", "", "9786559052851", "", 20f, "", "", 2, "", "Adão e horas" },
                    { "9786559210312", "Lucio Cardoso", "", "9786559210312", "", 42.4f, "Companhia das Letras", "Sep 27, 2019", 0, "", "Crônica da casa assassinada" },
                    { "9786559210381", "", "", "9786559210381", "", 42f, "", "", 0, "", "Manual do Minotauro" },
                    { "9786559210558", "", "", "9786559210558", "", 20f, "", "", 1, "", "O caderno rosa de Lori Lamby" },
                    { "9786559211548", "", "", "9786559211548", "", 15.9f, "", "", 0, "", "Futuro ancestral" },
                    { "9786559211647", "", "", "9786559211647", "", 34.98f, "", "", 1, "", "Morda meu coração na esquina: Poesia reunida" },
                    { "9786559212262", "", "", "9786559212262", "", 34.98f, "", "", 0, "", "Limite branco" },
                    { "9786559213498", "", "", "9786559213498", "", 28f, "", "", 0, "", "Vida desinteressante: Fragmentos de memórias" },
                    { "9786559280148", "", "", "9786559280148", "", 21.2f, "", "", 0, "", "O pensamento hétero e outros ensaios" },
                    { "9786559281688", "", "", "9786559281688", "", 19.61f, "", "", 1, "", "Movimento LGBTI+: Uma breve história do século XIX aos nossos dias" },
                    { "9786559790685", "", "", "9786559790685", "", 21.2f, "", "", 1, "", "Eu sou o monstro que vos fala: Relatório para uma academia de especialistas" },
                    { "9786559791125", "", "", "9786559791125", "", 39.22f, "", "", 0, "", "Poco hombre: Escritos de uma bicha terceiro-mundista" },
                    { "9786559791309", "", "", "9786559791309", "", 19.08f, "", "", 0, "", "Manifesto antimaternalista: Psicanálise e políticas da reprodução" },
                    { "9786559791415", "", "", "9786559791415", "", 41.9f, "", "", 0, "", "Dysphoria mundi: O som do mundo desmoronando" },
                    { "9786560080010", "", "", "9786560080010", "", 26.5f, "", "", 0, "", "Cinema vivido: raça, classe e sexo nas telas" },
                    { "9786560080270", "", "", "9786560080270", "", 23.32f, "", "", 2, "", "Salvação: Pessoas negras e o amor" },
                    { "9786560080317", "", "", "9786560080317", "", 23.32f, "", "", 1, "", "Comunhão: A busca das mulheres pelo amor" },
                    { "9786586279146", "", "", "9786586279146", "", 29.68f, "", "", 0, "", "A unicórnia preta" },
                    { "9786586790122", "", "", "9786586790122", "", 15f, "", "", 0, "", "As abelhas não dançam bachatas" },
                    { "9786587076799", "", "", "9786587076799", "português", 13f, "Urutau", "2020", 1, "", "Quem dera o sangue fosse só o da menstruação: Volume II" },
                    { "9786587113364", "invalid author ID", "https://covers.openlibrary.org/b/isbn/9786587113364-L.jpg", "9786587113364", "português", 12.72f, "Editora Jandaíra", "Dec 04, 2019", 2, "", "Transfeminismo (Feminismos plurais)" },
                    { "9786587235127", "", "", "9786587235127", "", 23.32f, "", "", 0, "", "Ensinando pensamento crítico: Sabedoria prática" },
                    { "9786587235240", "", "", "9786587235240", "", 23.32f, "", "", 0, "", "Tudo sobre o amor: Novas perspectivas" },
                    { "9786587235417", "", "", "9786587235417", "", 26.5f, "", "", 0, "", "Ensinando comunidade: Uma pedagogia da esperança" },
                    { "9786587235776", "", "", "9786587235776", "", 25.44f, "", "", 1, "", "O desafio poliamoroso: Por uma nova política dos afetos" },
                    { "9786587235844", "", "", "9786587235844", "", 25.44f, "", "", 1, "", "A gente é da hora: Homens negros e masculinidade" },
                    { "9786587529295", "", "", "9786587529295", "", 10f, "", "", 1, "", "Coleção de eus" },
                    { "9786587814117", "Leíner Hoki", "", "9786587814117", "português", 18f, "Urutau", "2021", 2, "", "Tríbades, safistas, sapatonas do mundo, uni-vos!: Investigações sobre a poética das lesbianidades" },
                    { "9786587938226", "", "", "9786587938226", "", 13f, "", "", 1, "", "Esse sangue não é de menstruação, mas de transfobia" },
                    { "9786587938585", "", "", "9786587938585", "", 13f, "", "", 1, "", "Errando" },
                    { "9788409296163", "", "", "9788409296163", "espanhol", 12f, "Antipersona", "2021", 1, "", "Stone Butch Blues" },
                    { "9788410288041", "", "", "9788410288041", "", 15.95f, "", "", 1, "", "Yo soy esa: La performance travesti como evento cinematográfico" },
                    { "9788411070898", "Camila Sosa Villada", "https://covers.openlibrary.org/b/isbn/9788411070898-L.jpg", "9788411070898", "", 18f, "Tusquets Editores S.A.", "Mar 09, 2022", 0, "", "Soy una tonta por quererte" },
                    { "9788411073325", "", "", "9788411073325", "", 19.9f, "", "", 1, "", "Yo soy mi propia mujer" },
                    { "9788411073646", "", "", "9788411073646", "", 19.9f, "", "", 0, "", "Tesis sobre una domesticación" },
                    { "9788411101202", "Daniela Ferrández Pérez", "https://covers.openlibrary.org/b/isbn/9788411101202-L.jpg", "9788411101202", "", 18.5f, "Edicións Xerais, Xerais", "May 12, 2022", 1, "", "A defunción dos sexos: Disidentes sexuais na Galiza conteporánea" },
                    { "9788411102575", "Ismael Ramos", "https://covers.openlibrary.org/b/isbn/9788411102575-L.jpg", "9788411102575", "", 17.5f, "Edicións Xerais", "Feb 16, 2023", 0, "", "A parte fácil" },
                    { "9788411102889", "Andrea Nunes Brións", "https://covers.openlibrary.org/b/isbn/9788411102889-L.jpg", "9788411102889", "", 19.95f, "Edicións Xerais", "Apr 20, 2023", 0, "", "O cento voando: Amores, alianzas e non-monogamias" },
                    { "9788412028355", "Gregory Woods", "https://covers.openlibrary.org/b/isbn/9788412028355-L.jpg", "9788412028355", "", 21.95f, "Editorial Dos Bigotes", "Oct 28, 2019", 1, "", "Homintern: Cómo la cultura LGTB liberó al mundo moderno" },
                    { "9788412028393", "Rubén Serrano", "", "9788412028393", "espanhol", 19.95f, "Dos Bigotes", "2019", 1, "", "Asalto a Oz: Antología de relatos de la nueva narrativa queer" },
                    { "9788412047523", "Ismael Ramos", "https://covers.openlibrary.org/b/isbn/9788412047523-L.jpg", "9788412047523", "", 10.9f, "Bella Varsovia", "Mar 19, 2019", 0, "", "Fuegos" },
                    { "9788412047554", "Carmen Jodra Davó", "", "9788412047554", "espanhol", 12f, "La Bella Varsovia", "2020", 1, "", "Las moras agraces" },
                    { "9788412083385", "Rodrigo Muñoz Ballester", "https://covers.openlibrary.org/b/isbn/9788412083385-L.jpg", "9788412083385", "", 39.5f, "Cielo Eléctrico", "Nov 01, 2021", 1, "", "Manuel" },
                    { "9788412106503", "", "", "9788412106503", "", 15f, "", "", 1, "", "Dédé" },
                    { "9788412106572", "", "", "9788412106572", "", 17f, "", "", 1, "", "Narkiss" },
                    { "9788412106596", "", "", "9788412106596", "", 17f, "", "", 1, "", "Joseph y su amigo" },
                    { "9788412109153", "Sergio Bero", "", "9788412109153", "espanhol", 16.95f, "Dos Bigotes", "2020", 1, "", "La calma luchada" },
                    { "9788412109160", "Cachorro Lozano", "", "9788412109160", "espanhol", 17.95f, "Dosbigotes", "2020", 1, "", "Dilemas y cowboys" },
                    { "9788412142877", "", "https://covers.openlibrary.org/b/isbn/9788412142877-L.jpg", "9788412142877", "", 20.95f, "", "", 1, "", "“Amigas”: Relatos de amor entre mujeres, del siglo XVIII al XX" },
                    { "9788412142884", "", "https://covers.openlibrary.org/b/isbn/9788412142884-L.jpg", "9788412142884", "", 21.95f, "Dos Bigotes", "2021", 1, "", "Libérate: La cultura LGTBQ que abrió camino en España" },
                    { "9788412152616", "Elizabeth Duval", "https://covers.openlibrary.org/b/isbn/9788412152616-L.jpg", "9788412152616", "", 11.9f, "Letraversal, LETRAVERSAL", "Feb 19, 2020", 1, "", "Excepción" },
                    { "9788412152678", "Elvis Guerra", "", "9788412152678", "", 12.9f, "Letraversal", "Sep 30, 2020", 1, "", "Ramonera" },
                    { "9788412166095", "", "https://covers.openlibrary.org/b/isbn/9788412166095-L.jpg", "9788412166095", "", 21.5f, "Wunderkammer", "2021", 1, "", "Confesiones inconfesas" },
                    { "9788412169348", "Mario Obrero", "https://covers.openlibrary.org/b/isbn/9788412169348-L.jpg", "9788412169348", "", 10.9f, "LA BELLA VARSOVIA", "Feb 01, 2022", 1, "", "Cerezas sobre la muerte" },
                    { "9788412169386", "", "https://covers.openlibrary.org/b/isbn/9788412169386-L.jpg", "9788412169386", "", 10f, "FisicalBook", "", 1, "", "Ligero" },
                    { "9788412175301", "", "https://covers.openlibrary.org/b/isbn/9788412175301-L.jpg", "9788412175301", "", 19.95f, "CABARET VOLTAIRE", "2020", 0, "", "La vida lenta" },
                    { "9788412185652", "Jeremy Bentham", "https://covers.openlibrary.org/b/isbn/9788412185652-L.jpg", "9788412185652", "", 18f, "Laetoli", "Oct 05, 2020", 1, "", "Sobre el homoerotismo" },
                    { "9788412185812", "Hélène Bessette", "", "9788412185812", "", 18.9f, "Editorial Dosmanos", "May 01, 2020", 1, "", "Ida" },
                    { "9788412185843", "Hélène Bessette", "https://covers.openlibrary.org/b/isbn/9788412185843-L.jpg", "9788412185843", "", 18.9f, "Editorial Dosmanos", "Oct 28, 2020", 1, "", "Veinte minutos de silencio" },
                    { "9788412212907", "Donna Haraway", "", "9788412212907", "", 12f, "Kaótica Libros", "Jun 24, 2020", 0, "", "Manifiesto cíborg" },
                    { "9788412212938", "", "https://covers.openlibrary.org/b/isbn/9788412212938-L.jpg", "9788412212938", "", 14f, "Kaótica", "2020", 1, "", "Zezé" },
                    { "9788412212990", "", "https://covers.openlibrary.org/b/isbn/9788412212990-L.jpg", "9788412212990", "", 23f, "FisicalBook", "", 0, "", "Teoría crip" },
                    { "9788412218022", "Lili Ilse Elvenes.", "https://covers.openlibrary.org/b/isbn/9788412218022-L.jpg", "9788412218022", "", 23.9f, "Uve Books", "Apr 18, 2022", 1, "", "Lili: Relato de la primera transición de género – 1931" },
                    { "9788412224306", "Violeta C. Rangel", "https://covers.openlibrary.org/b/isbn/9788412224306-L.jpg", "9788412224306", "", 14.85f, "Editorial Ultramarina C&D", "Oct 01, 2020", 1, "", "Nada como un corazón para la cena" },
                    { "9788412244090", "", "https://covers.openlibrary.org/b/isbn/9788412244090-L.jpg", "9788412244090", "", 17.95f, "", "", 1, "", "Tengo miedo torero" },
                    { "9788412260205", "Maria-Mercé Marçal", "", "9788412260205", "espanhol", 17f, "Ultramarinos Editorial", "2020", 0, "", "Diré tu cuerpo" },
                    { "9788412260274", "", "https://covers.openlibrary.org/b/isbn/9788412260274-L.jpg", "9788412260274", "", 14.99f, "", "", 1, "", "La parte del fuego" },
                    { "9788412276626", "Cristian Alcaraz", "https://covers.openlibrary.org/b/isbn/9788412276626-L.jpg", "9788412276626", "", 12.9f, "Letraversal", "Feb 10, 2021", 0, "", "Individuo armado" },
                    { "9788412276640", "Abel Azcona", "", "9788412276640", "espanhol", 14.9f, "Letraversal", "2021", 0, "", "Las crías cantaron al hambre" },
                    { "9788412276657", "Juanpe Sánchez López", "https://covers.openlibrary.org/b/isbn/9788412276657-L.jpg", "9788412276657", "", 14.9f, "Letraversal, LETRAVERSAL", "Sep 15, 2021", 1, "", "Desde las gradas" },
                    { "9788412276688", "", "", "9788412276688", "", 15.9f, "", "", 1, "", "Poserótica" },
                    { "9788412292503", "", "", "9788412292503", "", 19.95f, "", "", 1, "", "Scream Queer: La representación LGTBIQ+ em el cine de terror" },
                    { "9788412321227", "", "", "9788412321227", "", 15f, "", "", 0, "", "Fuckboys" },
                    { "9788412321289", "", "", "9788412321289", "", 16.5f, "", "", 1, "", "Un paraíso portátil" },
                    { "9788412330748", "Antonio de Hoyos y Vinent", "", "9788412330748", "espanhol", 16f, "Amistades Particulares", "2021", 1, "", "El martirio de San Sebastián" },
                    { "9788412330786", "Renato Pellegrini", "", "9788412330786", "", 17f, "Asociación Cultural Amistades Particulares, Libros Libres", "Apr 01, 2022", 1, "", "Asfalto" },
                    { "9788412330793", "", "https://covers.openlibrary.org/b/isbn/9788412330793-L.jpg", "9788412330793", "espanhol", 16f, "Asociación Cultural Amistades Particulares", "3 May 2022", 1, "", "El tercer sexo de Berlín" },
                    { "9788412349894", "", "", "9788412349894", "", 21f, "", "", 1, "", "Solo los valientes" },
                    { "9788412405583", "Ira Hybris", "https://covers.openlibrary.org/b/isbn/9788412405583-L.jpg", "9788412405583", "", 20f, "Kaótica Libros", "Mar 31, 2022", 0, "", "Las degeneradas trans acaban com la familia" },
                    { "9788412434514", "Abel Azcona", "", "9788412434514", "espanhol", 19.5f, "Los Aciertos", "2022", 1, "", "Volver al padre" },
                    { "9788412441659", "Roberta Marrero", "", "9788412441659", "espanhol", 13.95f, "Continta Me Tienes", "2022", 1, "", "Todo era por ser fuego: poemas de chulos, trans y travestis" },
                    { "9788412466539", "Adam Zmith", "https://covers.openlibrary.org/b/isbn/9788412466539-L.jpg", "9788412466539", "", 19.95f, "Editorial Dos Bigotes, DOS BIGOTES", "Mar 21, 2022", 1, "", "Inhalación profunda: Historia del popper y futuros queer" },
                    { "9788412466577", "Popy Blasco", "", "9788412466577", "espanhol", 19.95f, "Dos Bigotes", "2022", 1, "", "Cine Crush: El cine homoerótico involuntario en nuestro despertar sexual" },
                    { "9788412466584", "Xavi Reyes", "", "9788412466584", "espanhol", 22.95f, "Dso Bigotes", "2022", 0, "", "Otras flores: Álbum fotográfico de infancias queer" },
                    { "9788412480276", "", "https://covers.openlibrary.org/b/isbn/9788412480276-L.jpg", "9788412480276", "", 22.95f, "", "", 1, "", "Poco hombre" },
                    { "9788412511949", "Pablo Fidalgo Lareo", "", "9788412511949", "espanhol", 13.9f, "Letraversal", "2022", 1, "", "La dejadez" },
                    { "9788412511963", "Billy Ray Belcourt", "https://covers.openlibrary.org/b/isbn/9788412511963-L.jpg", "9788412511963", "", 14.9f, "Letraversal, LETRAVERSAL", "Oct 26, 2022", 1, "", "Esta herida es un mundo" },
                    { "9788412512366", "Francina Ribes Pericàs", "https://covers.openlibrary.org/b/isbn/9788412512366-L.jpg", "9788412512366", "", 19.95f, "Editorial Dos Bigotes", "Oct 24, 2022", 1, "", "Ausencia y exceso: Lesbianas y bisexuales asesinas en el cine de Hollywood" },
                    { "9788412520439", "Ulises Rojas", "https://covers.openlibrary.org/b/isbn/9788412520439-L.jpg", "9788412520439", "", 15f, "Levanta Fuego", "Sep 01, 2022", 1, "", "Manifiesto marica visible" },
                    { "9788412520460", "Leslie Feinberg", "https://covers.openlibrary.org/b/isbn/9788412520460-L.jpg", "9788412520460", "", 13f, "Levanta Fuego", "Dec 28, 2022", 2, "", "Drag King Dreams" },
                    { "9788412520477", "Levanta Fuego Editorial", "https://covers.openlibrary.org/b/isbn/9788412520477-L.jpg", "9788412520477", "", 12f, "Levanta Fuego Editorial", "Jan 01, 1900", 0, "", "El comunismo destruye la familia" },
                    { "9788412524215", "", "https://covers.openlibrary.org/b/isbn/9788412524215-L.jpg", "9788412524215", "", 32.99f, "FisicalBook", "", 1, "", "This Is A Gay Book" },
                    { "9788412526141", "", "", "9788412526141", "", 17f, "", "", 1, "", "El matrimonio secreto de Fridolin" },
                    { "9788412526165", "", "", "9788412526165", "", 17f, "", "", 1, "", "Así nací, así moriré: Confesiones íntimas de un homosexual" },
                    { "9788412549294", "Manuela Trasobares Haro", "https://covers.openlibrary.org/b/isbn/9788412549294-L.jpg", "9788412549294", "", 18.9f, "Ediciones Hidroavión", "Nov 18, 2022", 1, "", "Voluntad de poder" },
                    { "9788412584035", "", "", "9788412584035", "", 14f, "", "", 1, "", "Los reales sitios" },
                    { "9788412584080", "", "", "9788412584080", "", 19.99f, "", "", 2, "", "Crush (castelhano)" },
                    { "9788412597585", "", "", "9788412597585", "", 21.95f, "", "", 0, "", "El látigo y la pluma: Homosexuales en la España de Franco" },
                    { "9788412628234", "", "", "9788412628234", "", 13f, "", "", 3, "", "A música está na minha cabeça" },
                    { "9788412640069", "Juan Gallego Benot", "https://covers.openlibrary.org/b/isbn/9788412640069-L.jpg", "9788412640069", "", 14.9f, "Letraversal", "Feb 22, 2023", 2, "", "Las cañadas oscuras" },
                    { "9788412640076", "Rodrigo García Marina", "https://covers.openlibrary.org/b/isbn/9788412640076-L.jpg", "9788412640076", "", 15.9f, "Letraversal", "Mar 01, 2023", 2, "", "Los prodigiosos gatos monteses" },
                    { "9788412640083", "Manuel Mata", "https://covers.openlibrary.org/b/isbn/9788412640083-L.jpg", "9788412640083", "", 14.9f, "Letraversal", "Mar 22, 2023", 1, "", "Pan manchado" },
                    { "9788412640090", "Pink Chadora", "", "9788412640090", "espanhol", 14.9f, "Letraversal", "2023", 1, "", "Todo era campo" },
                    { "9788412641042", "", "", "9788412641042", "", 16f, "", "", 1, "", "Yolao: Antología de la amistad" },
                    { "9788412652154", "", "", "9788412652154", "", 17f, "", "", 1, "", "El sexo intermedio: 1908" },
                    { "9788412653526", "", "", "9788412653526", "", 20.95f, "", "", 1, "", "¡Larga vida al trash!" },
                    { "9788412653571", "", "", "9788412653571", "", 20.95f, "", "", 1, "", "Ocaña: El eterno brillo del Sol de Cantillana" },
                    { "9788412653595", "", "", "9788412653595", "", 15.95f, "", "", 1, "", "En mitad de tanto fuego" },
                    { "9788412656114", "", "", "9788412656114", "", 16.9f, "", "", 1, "", "Mis recuerdos" },
                    { "9788412699005", "", "", "9788412699005", "", 15.9f, "", "", 2, "", "Arturo, la estrella más brillante" },
                    { "9788412710748", "", "", "9788412710748", "", 23f, "", "", 1, "", "Marxismo trans" },
                    { "9788412710762", "", "", "9788412710762", "", 18f, "", "", 0, "", "El círculo sáfico: Lesbianismo y bisexualidad en el Madrid" },
                    { "9788412713718", "", "", "9788412713718", "", 14.9f, "", "", 1, "", "El hermoso país donde los hombres desean a los hombres" },
                    { "9788412713756", "", "", "9788412713756", "", 14.9f, "", "", 2, "", "Romero recién cortao'" },
                    { "9788412713770", "", "", "9788412713770", "", 12.9f, "", "", 2, "", "Nombre muerto" },
                    { "9788412716832", "", "", "9788412716832", "", 19f, "", "", 1, "", "Un amor extramuros" },
                    { "9788412716856", "", "", "9788412716856", "", 18f, "", "", 1, "", "Autobiografía de un andrógino" },
                    { "9788412716870", "", "", "9788412716870", "", 18f, "", "", 1, "", "Abandonados a su suerte" },
                    { "9788412765724", "", "", "9788412765724", "", 19.95f, "", "", 1, "", "Scream Queer 2: La venganza" },
                    { "9788412765731", "", "", "9788412765731", "", 17.95f, "", "", 1, "", "La noche en que Larry Kramer me besó" },
                    { "9788412765748", "", "", "9788412765748", "", 18.95f, "", "", 0, "", "Las «locas» de postín y El fuego de Lesbos" },
                    { "9788412844207", "", "", "9788412844207", "", 15f, "", "", 1, "", "Arremangadas 6" },
                    { "9788413524030", "Itxaso Domínguez", "https://covers.openlibrary.org/b/isbn/9788413524030-L.jpg", "9788413524030", "", 17.5f, "Los Libros de la Catarata", "Feb 08, 2022", 2, "", "Palestina: Ocupación, colonización, segregación" },
                    { "9788413525464", "Francisco Vázquez García", "https://covers.openlibrary.org/b/isbn/9788413525464-L.jpg", "9788413525464", "", 20f, "Los Libros de la Catarata", "Sep 05, 2022", 1, "", "Historia de la homosexualidad masculina en Occidente" },
                    { "9788413526058", "Ricard Huerta", "https://covers.openlibrary.org/b/isbn/9788413526058-L.jpg", "9788413526058", "", 16.5f, "Los Libros de la Catarata", "Dec 20, 2022", 0, "", "El holocausto rosa" },
                    { "9788413528359", "", "", "9788413528359", "", 20f, "", "", 0, "", "Historia de la homosexualidad femenina en Occidente" },
                    { "9788413629155", "Ihara Saikaku", "https://covers.openlibrary.org/b/isbn/9788413629155-L.jpg", "9788413629155", "", 16.95f, "Alianza Editorial", "Sep 22, 2022", 0, "", "El gran espejo del amor entre hombres" },
                    { "9788415305859", "", "https://covers.openlibrary.org/b/isbn/9788415305859-L.jpg", "9788415305859", "", 14f, "Comité Español de Representantes de Personas con Discapacidad (CERMI)", "2015", 0, "", "¿Qué hacen los hombres juntos?" },
                    { "9788415373216", "Jean-François Monet", "https://covers.openlibrary.org/b/isbn/9788415373216-L.jpg", "9788415373216", "", 10f, "Editorial Melusina", "Jun 01, 2015", 0, "", "Sobre el derecho de los hermafroditas" },
                    { "9788415373360", "Daniel J. García López", "", "9788415373360", "espanhol", 15.9f, "Editorial Melusina", "2016", 0, "", "Rara avis: Una teoría queer impolítica" },
                    { "9788416205769", "Larry Mitchell", "https://covers.openlibrary.org/b/isbn/9788416205769-L.jpg", "9788416205769", "", 18.9f, "Consonni", "Jul 19, 2021", 1, "", "Maricas y sus amigas entre revoluciones" },
                    { "9788416217601", "Arturo Infante", "", "9788416217601", "espanhol", 13.95f, "Diábolo Ediciones", "2016", 0, "", "Bim Bom: Historias de lucha" },
                    { "9788416227242", "", "", "9788416227242", "", 17f, "", "", 1, "", "Pensamiento monógamo, terror poliamoroso" },
                    { "9788416227334", "Juan Carlos Perez", "https://covers.openlibrary.org/b/isbn/9788416227334-L.jpg", "9788416227334", "espanhol", 20f, "La Oveja Roja", "Aug 20, 2020", 1, "", "Anarquía relacional: La revolución desde los vínculos" },
                    { "9788416489695", "Ricardo Cavolo", "https://covers.openlibrary.org/b/isbn/9788416489695-L.jpg", "9788416489695", "", 24.5f, "Lunwerg Editores", "Jan 24, 2017", 1, "", "Periferias" },
                    { "9788416491995", "", "https://covers.openlibrary.org/b/isbn/9788416491995-L.jpg", "9788416491995", "espanhol", 20f, "Egales", "February 26th 2018", 0, "", "El arte queer del fracaso" },
                    { "9788416529421", "", "https://covers.openlibrary.org/b/isbn/9788416529421-L.jpg", "9788416529421", "", 19f, "Gallo Nero", "2017", 1, "", "Diario de Sintra" },
                    { "9788416545452", "", "", "9788416545452", "", 18f, "", "", 2, "", "Nos, xs inadaptadxs: Representações, desejos e histórias LGBTIQ" },
                    { "9788417417772", "", "", "9788417417772", "", 15.9f, "", "", 0, "", "El vampiro de la colonia Roma" },
                    { "9788417442859", "Ralf König", "https://covers.openlibrary.org/b/isbn/9788417442859-L.jpg", "9788417442859", "espanhol", 14.5f, "Ediciones La Cúpula, S.L.", "Apr 08, 2021", 1, "", "Roy & Al: Muy Machos!" },
                    { "9788417496524", "Elizabeth Duval", "https://covers.openlibrary.org/b/isbn/9788417496524-L.jpg", "9788417496524", "", 18f, "Caja baja", "Mar 26, 2021", 0, "", "Después de lo trans: Sexo y género entre la izquierda y lo identitario" },
                    { "9788417496777", "", "", "9788417496777", "", 10.9f, "", "", 0, "", "La ciudad sin imágenes" },
                    { "9788417560751", "Ricardo Cavolo", "https://covers.openlibrary.org/b/isbn/9788417560751-L.jpg", "9788417560751", "", 24.5f, "Lunwerg Editores", "Feb 19, 2019", 1, "", "Jamfry: Autobiografía" },
                    { "9788417858407", "Ricardo Cavolo", "https://covers.openlibrary.org/b/isbn/9788417858407-L.jpg", "9788417858407", "", 24f, "Lunwerg Editores", "Jun 23, 2020", 1, "", "Romancero gitano" },
                    { "9788418100994", "", "https://covers.openlibrary.org/b/isbn/9788418100994-L.jpg", "9788418100994", "", 18.95f, "larousse", "2021", 1, "", "Lenguaje inclusivo y exclusión de clase" },
                    { "9788418178559", "Monique Wittig", "", "9788418178559", "", 15f, "Editorial Pre-Textos", "Mar 10, 2021", 0, "", "El cuerpo lesbiano" },
                    { "9788418252006", "Augusto DHalmar", "https://covers.openlibrary.org/b/isbn/9788418252006-L.jpg", "9788418252006", "", 16.25f, "Txalaparta, S.L.", "Mar 02, 2020", 1, "", "Pasión y muerte del cura Deusto" },
                    { "9788418283369", "Arthur Evans", "", "9788418283369", "", 12f, "Descontrol Editorial i Impremta", "Mar 15, 2022", 1, "", "Brujería y contracultura gay" },
                    { "9788418481147", "", "", "9788418481147", "", 17.21f, "", "", 0, "", "Cartilla de redención" },
                    { "9788418481406", "", "", "9788418481406", "", 18.9f, "", "", 1, "", "Teorema" },
                    { "9788418501050", "", "", "9788418501050", "", 19f, "", "", 0, "", "El genio lésbico:" },
                    { "9788418501142", "", "https://covers.openlibrary.org/b/isbn/9788418501142-L.jpg", "9788418501142", "espanhol", 20f, "Egales", "2020-11-16", 0, "", "Criaturas salvages: El desorden del deseo" },
                    { "9788418501180", "", "https://covers.openlibrary.org/b/isbn/9788418501180-L.jpg", "9788418501180", "", 14.96f, "Egales", "2021", 1, "", "Y Leo Classen habló: Primer testimonio de un triángulo rosa" },
                    { "9788418501517", "Celia Gutiérrez", "", "9788418501517", "espanhol", 16.95f, "Editorial Egales", "2022", 0, "", "La revolucíon (a)sexual" },
                    { "9788418501777", "María Mínguez Arias", "", "9788418501777", "espanhol", 18.95f, "Egales", "2022", 0, "", "Nombrar el cuerpo: La fortuna de ser una mujer queer a los 50" },
                    { "9788418501876", "Sergio Téllez-Pon", "", "9788418501876", "espanhol", 19.95f, "Egales Editorial", "2022", 0, "", "Un árbol se expande en el cielo: Antología de cuento gay mexicano" },
                    { "9788418639340", "Rodrigo García Marina", "https://covers.openlibrary.org/b/isbn/9788418639340-L.jpg", "9788418639340", "", 13f, "Editorial Cántico", "Nov 04, 2021", 1, "", "Desear la casa" },
                    { "9788418684814", "Oscar Guasch Andreu", "https://covers.openlibrary.org/b/isbn/9788418684814-L.jpg", "9788418684814", "", 16f, "Bellaterra Edicions", "May 25, 2022", 0, "", "La sociedad rosa: 30 años después" },
                    { "9788418690495", "", "", "9788418690495", "", 17.9f, "", "", 0, "", "Cuerpos para odiar" },
                    { "9788418752704", "", "", "9788418752704", "", 35f, "", "", 0, "", "Las locas en el archivo: Disidencia sexual bajo el franquismo" },
                    { "9788418782008", "Camila Sosa Villada", "https://covers.openlibrary.org/b/isbn/9788418782008-L.jpg", "9788418782008", "", 12f, "Ediciones La Uña Rota", "May 17, 2021", 0, "", "El viaje inútil: trans/escritura" },
                    { "9788418809736", "", "", "9788418809736", "", 8.5f, "", "", 1, "", "Elisa y Marcela" },
                    { "9788418821240", "", "", "9788418821240", "", 14f, "", "", 0, "", "Menino, menina – Niño, niña (esp)" },
                    { "9788419047267", "", "", "9788419047267", "", 18.95f, "", "", 1, "", "Un país para morir" },
                    { "9788419160270", "Ediciones Bellaterra", "https://covers.openlibrary.org/b/isbn/9788419160270-L.jpg", "9788419160270", "", 19f, "Bellaterra, Ediciones", "Jan 01, 1900", 1, "", "Psicoterapia queer: Una introducción" },
                    { "9788419231703", "Jean-Louis Guereña", "https://covers.openlibrary.org/b/isbn/9788419231703-L.jpg", "9788419231703", "", 39.9f, "Editorial Renacimiento", "Oct 03, 2022", 0, "", "Eros de papel: Un infierno español (siglos XIX-XX)" },
                    { "9788419323118", "", "", "9788419323118", "", 23f, "", "", 1, "", "Borrador para un diccionario de las amantes" },
                    { "9788419323170", "", "", "9788419323170", "", 15f, "", "", 1, "", "Pictura Fulgens" },
                    { "9788419323200", "", "", "9788419323200", "", 16f, "", "", 2, "", "Derecho a cita" },
                    { "9788419323217", "", "", "9788419323217", "", 16f, "", "", 1, "", "El viaje sin fin" },
                    { "9788419323224", "", "", "9788419323224", "", 20.95f, "", "", 1, "", "Nadie miraba hacia aquí: Un ensayo sobre arte y VIH/sida" },
                    { "9788419387394", "", "", "9788419387394", "", 19.95f, "", "", 1, "", "50 canciones de amor y droga" },
                    { "9788419387615", "", "", "9788419387615", "", 15.95f, "", "", 0, "", "El ojo torcido: La mirada disidente del feminismo queer" },
                    { "9788419387639", "", "", "9788419387639", "", 15.95f, "", "", 0, "", "Territorios queer: Localizar las sexo-disidencias" },
                    { "9788419387905", "", "", "9788419387905", "", 14.95f, "", "", 0, "", "Contra la cultura" },
                    { "9788419437365", "Pedro Almodóvar", "", "9788419437365", "", 19.9f, "RESERVOIR BOOKS, Penguin Random House Grupo Editorial", "Apr 13, 2023", 0, "", "El último sueño" },
                    { "9788419466242", "Ricardo Cavolo", "https://covers.openlibrary.org/b/isbn/9788419466242-L.jpg", "9788419466242", "", 24f, "Lunwerg Editores", "Feb 01, 2023", 1, "", "Poeta en Nueva York" },
                    { "9788419558268", "", "", "9788419558268", "", 29.9f, "", "", 1, "", "Enciclopedia crítica del género" },
                    { "9788419633378", "", "", "9788419633378", "", 16f, "", "", 1, "", "Estar con. otro" },
                    { "9788419728043", "", "", "9788419728043", "", 21.95f, "", "", 1, "", "Entre la cámara y la carne: El cine homoerótico en 25 películas" },
                    { "9788419990341", "", "", "9788419990341", "", 12.9f, "", "", 1, "", "La lengua en disputa: Un debate sobre el lenguaje inclusivo" },
                    { "9788420431444", "Mario Bellatín", "https://covers.openlibrary.org/b/isbn/9788420431444-L.jpg", "9788420431444", "", 13.9f, "ALFAGUARA", "Apr 02, 2017", 1, "", "Salón de belleza" },
                    { "9788420432595", "", "https://covers.openlibrary.org/b/isbn/9788420432595-L.jpg", "9788420432595", "", 16.9f, "Alfaguara", "2017", 0, "", "Desastres naturales" },
                    { "9788420461106", "Pablo Simonetti", "", "9788420461106", "espanhol", 17.9f, "Penguin Random House Grupo Editorial", "2022", 1, "", "Los hombres que no fui" },
                    { "9788420664439", "Yukio Mishima", "https://covers.openlibrary.org/b/isbn/9788420664439-L.jpg", "9788420664439", "", 12.5f, "Alianza Editorial", "Oct 11, 2010", 1, "", "El sol y el acero" },
                    { "9788420697970", "", "https://covers.openlibrary.org/b/isbn/9788420697970-L.jpg", "9788420697970", "", 10.3f, "ALIANZA EDITORIAL", "2015", 1, "", "Antología poética" },
                    { "9788423363629", "", "", "9788423363629", "", 13.5f, "", "", 0, "", "Una homosexualidad propia" },
                    { "9788426409676", "Cristina DAURA", "https://covers.openlibrary.org/b/isbn/9788426409676-L.jpg", "9788426409676", "espanhol", 24.9f, "Penguin Random House Grupo Editorial", "2022", 1, "", "Sexbook: Una historia ilustrada de la sexualidad" },
                    { "9788426420176", "José Agustín Goytisolo", "https://covers.openlibrary.org/b/isbn/9788426420176-L.jpg", "9788426420176", "", 30.9f, "LUMEN", "Mar 17, 2022", 1, "", "Poesía completa" },
                    { "9788432242120", "Alana S. Portero", "https://covers.openlibrary.org/b/isbn/9788432242120-L.jpg", "9788432242120", "", 19f, "Seix Barral", "May 03, 2023", 1, "", "La mala costumbre" },
                    { "9788433916228", "", "https://covers.openlibrary.org/b/isbn/9788433916228-L.jpg", "9788433916228", "", 8.9f, "Anagrama", "2020", 0, "", "Monstruas y centauras" },
                    { "9788433916242", "Manuel Arias Maldonado", "", "9788433916242", "espanhol", 8.9f, "Editorial Anagrama S.A.", "2019", 0, "", "(Fe)Male Gaze" },
                    { "9788433916433", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9788433916433-L.jpg", "9788433916433", "", 10.9f, "Editorial Anagrama", "Dec 10, 2020", 1, "", "Yo soy el monstruo que os habla" },
                    { "9788433916594", "Luisgé Martín", "https://covers.openlibrary.org/b/isbn/9788433916594-L.jpg", "9788433916594", "", 9.9f, "Editorial Anagrama", "Feb 09, 2022", 0, "", "¿Soy yo normal?: Filias y parafilias sexuales" },
                    { "9788433921079", "Pedro Almodóvar", "https://covers.openlibrary.org/b/isbn/9788433921079-L.jpg", "9788433921079", "", 9.9f, "Editorial Anagrama S.A., Anagrama", "May 14, 2014", 0, "", "Patty Diphusa" },
                    { "9788433924384", "", "", "9788433924384", "", 17.9f, "", "", 0, "", "En las manos, el paraíso quema" },
                    { "9788433964533", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9788433964533-L.jpg", "9788433964533", "", 19.9f, "Editorial Anagrama", "Mar 04, 2020", 1, "", "Testo yonqui" },
                    { "9788433964540", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9788433964540-L.jpg", "9788433964540", "", 18.9f, "Editorial Anagrama", "Dec 30, 2020", 0, "", "Pornotopía" },
                    { "9788433964557", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9788433964557-L.jpg", "9788433964557", "espanhol", 18.9f, "Editorial Anagrama", "2020-03-04", 1, "", "Manifiesto contrasexual" },
                    { "9788433998644", "", "https://covers.openlibrary.org/b/isbn/9788433998644-L.jpg", "9788433998644", "", 19.9f, "Anagrama", "2020", 0, "", "Lectura fácil" },
                    { "9788433998767", "", "https://covers.openlibrary.org/b/isbn/9788433998767-L.jpg", "9788433998767", "", 19.9f, "Anagrama, Editorial Anagrama", "2019", 1, "", "Un apartamento en Urano: Crónicas del cruce" },
                    { "9788433999351", "Pol Guasch", "", "9788433999351", "espanhol", 18.9f, "Editorial Anagrama", "2021", 0, "", "Napalm en el corazón" },
                    { "9788433999481", "", "", "9788433999481", "", 21.9f, "", "", 2, "", "Dysphoria mundi: El sonido del mundo derrumbándose" },
                    { "9788437602202", "Jose Lezama Lima", "https://covers.openlibrary.org/b/isbn/9788437602202-L.jpg", "9788437602202", "espanhol", 14.1f, "Catedra 'General Casta~nos' Region Militar Su", "June 30, 2003", 1, "", "Paradiso" },
                    { "9788437608082", "José Lezama Lima", "", "9788437608082", "espanhol", 13.5f, "Cátedra", "1989", 1, "", "Oppiano Licario" },
                    { "9788437617763", "José Donoso", "https://covers.openlibrary.org/b/isbn/9788437617763-L.jpg", "9788437617763", "espanhol", 13.5f, "Ediciones Catedra S.A., Cátedra", "June 30, 2004", 1, "", "El lugar sin límites" },
                    { "9788437624433", "Reinaldo Arenas", "https://covers.openlibrary.org/b/isbn/9788437624433-L.jpg", "9788437624433", "espanhol", 13.5f, "Cátedra, Ediciones Cátedra, Brand: Catedra", "2008", 1, "", "El mundo alucinante" },
                    { "9788439737612", "Gabriela Wiener", "https://covers.openlibrary.org/b/isbn/9788439737612-L.jpg", "9788439737612", "", 17.9f, "Literatura Random House", "Mar 21, 2023", 1, "", "Sexografías" },
                    { "9788439738909", "Selva Almada", "https://covers.openlibrary.org/b/isbn/9788439738909-L.jpg", "9788439738909", "espanhol", 15.9f, "Penguin Random House Grupo Editorial", "2021", 0, "", "No es un río" },
                    { "9788439739173", "Selva Almada", "", "9788439739173", "espanhol", 16.9f, "Penguin Random House Grupo Editorial", "2022", 0, "", "El viento que arrasa" },
                    { "9788439739180", "Selva Almada", "", "9788439739180", "espanhol", 17.9f, "Penguin Random House Grupo Editorial", "2021", 1, "", "Ladrilleros" },
                    { "9788439742883", "Eva Baltasar", "https://covers.openlibrary.org/b/isbn/9788439742883-L.jpg", "9788439742883", "", 24.9f, "Random House", "Nov 02, 2023", 1, "", "Tres cuerpos salvajes: Permafrost / Boulder / Mamut" },
                    { "9788446011964", "", "", "9788446011964", "", 8f, "", "", 0, "", "Historia de la Literatura Gay" },
                    { "9788446049029", "", "https://covers.openlibrary.org/b/isbn/9788446049029-L.jpg", "9788446049029", "", 12.5f, "Akal", "2020", 1, "", "Treinta y tres monstruos ¡No!" },
                    { "9788446050780", "Eva Cantarella", "https://covers.openlibrary.org/b/isbn/9788446050780-L.jpg", "9788446050780", "", 22f, "Ediciones Akal", "Oct 05, 2021", 0, "", "Según natura: La bisexualidad en el mundo antiguo" },
                    { "9788448028916", "Aitor Saraiba", "", "9788448028916", "espanhol", 23.95f, "Libros Cúpula", "2022", 0, "", "El libro de la crisálida" },
                    { "9788449337918", "", "https://covers.openlibrary.org/b/isbn/9788449337918-L.jpg", "9788449337918", "", 19.9f, "Paidós, Ediciones Paidós", "2021", 0, "", "Todo sobre el amor" },
                    { "9788449339776", "Judith Butler", "https://covers.openlibrary.org/b/isbn/9788449339776-L.jpg", "9788449339776", "", 21.9f, "Ediciones Paidós", "Sep 21, 2022", 1, "", "Cuerpos que importan: Sobre los límites discursivos del “sexo”" },
                    { "9788449341403", "", "", "9788449341403", "", 18.9f, "", "", 1, "", "Maricas malas" },
                    { "9788466333665", "Ian Gibson", "https://covers.openlibrary.org/b/isbn/9788466333665-L.jpg", "9788466333665", "", 10.95f, "Debolsillo, DEBOLSILLO", "Jun 02, 2016", 0, "", "Lorca-Dalí: El amor que no pudo ser" },
                    { "9788466333887", "Ian Gibson", "https://covers.openlibrary.org/b/isbn/9788466333887-L.jpg", "9788466333887", "", 15f, "DEBOLSILLO, Debolsillo", "Aug 01, 2020", 1, "", "Vida, pasión y muerte de Federico García Lorca: 1898-1936" },
                    { "9788466337465", "Ramón del Valle-Inclán", "https://covers.openlibrary.org/b/isbn/9788466337465-L.jpg", "9788466337465", "espanhol", 14.95f, "Debolsillo", "2016", 1, "", "Sonatas" },
                    { "9788467067316", "Ángelo Néstore", "https://covers.openlibrary.org/b/isbn/9788467067316-L.jpg", "9788467067316", "", 13.9f, "Espasa", "Nov 23, 2022", 1, "", "Deseo de ser árbol" },
                    { "9788467072532", "", "", "9788467072532", "", 13.9f, "", "", 2, "", "Antología de poesía queer: una imaginacion radical" },
                    { "9788467940473", "Maia Kobabe", "https://covers.openlibrary.org/b/isbn/9788467940473-L.jpg", "9788467940473", "", 19.95f, "Astronave", "Sep 03, 2020", 1, "", "Género queer (castelhano)" },
                    { "9788472909267", "", "https://covers.openlibrary.org/b/isbn/9788472909267-L.jpg", "9788472909267", "", 18f, "Bellaterra", "2019", 0, "", "Fenomenología queer: orientaciones, objetos, otros" },
                    { "9788475175694", "", "", "9788475175694", "", 10f, "", "", 1, "", "La posesión del humo" },
                    { "9788475179438", "", "", "9788475179438", "", 10f, "", "", 0, "", "Oscuro dominio" },
                    { "9788475229921", "", "", "9788475229921", "", 12f, "", "", 1, "", "Correspondencias" },
                    { "9788476588406", "Ibon Zubiaur (Ed.), K.H. Ulrichs, K.M. Kertbeny, M. Hirschfeld", "https://covers.openlibrary.org/b/isbn/9788476588406-L.jpg", "9788476588406", "", 10f, "Anthropos", "Jan 01, 2007", 1, "", "Pioneros de lo homosexual" },
                    { "9788478335961", "Ralf König", "https://covers.openlibrary.org/b/isbn/9788478335961-L.jpg", "9788478335961", "", 10.95f, "LA Cupula Ediciones", "Apr 14, 2014", 1, "", "Roy & Al" },
                    { "9788478338108", "Ralf König", "https://covers.openlibrary.org/b/isbn/9788478338108-L.jpg", "9788478338108", "espanhol", 12f, "Ediciones La Cúpula, S.L.", "Apr 23, 2013", 1, "", "Poppers" },
                    { "9788478398454", "Carmen Conde", "", "9788478398454", "", 16f, "Ediciones Torremozas", "Jan 21, 2021", 1, "", "Poemas a Amanda" },
                    { "9788481914337", "Juan Gil-Albert", "https://covers.openlibrary.org/b/isbn/9788481914337-L.jpg", "9788481914337", "", 13f, "Editorial Pre-Textos", "Jan 01, 2002", 1, "", "Heraclés" },
                    { "9788483447451", "", "https://covers.openlibrary.org/b/isbn/9788483447451-L.jpg", "9788483447451", "espanhol", 13.37f, "Universidad Autónoma de Madrid", "2020", 1, "", "La fuente envenenada" },
                    { "9788483740156", "", "", "9788483740156", "", 10f, "", "", 0, "", "Consecuencia del lugar" },
                    { "9788483745038", "", "", "9788483745038", "", 15f, "Huerga y Fierro", "2005", 0, "", "La vida entera (1937-1977): Antologia poética" },
                    { "9788483812730", "Elizabeth Duval", "https://covers.openlibrary.org/b/isbn/9788483812730-L.jpg", "9788483812730", "espanhol", 17.5f, "Lengua de Trapo", "2021", 0, "", "Madrid será la tumba" },
                    { "9788484728139", "Porfirio Barba Jacob", "", "9788484728139", "espanhol", 12f, "Renacimiento", "2013", 0, "", "Rosas negras" },
                    { "9788487524710", "", "", "9788487524710", "", 12f, "", "", 0, "", "Orgia" },
                    { "9788488052520", "", "https://covers.openlibrary.org/b/isbn/9788488052520-L.jpg", "9788488052520", "espanhol", 16.5f, "Editorial Egales", "2007", 0, "", "Ética marica: Proclamas libertarias para una militancia LGTBQ" },
                    { "9788490020982", "", "https://covers.openlibrary.org/b/isbn/9788490020982-L.jpg", "9788490020982", "", 10f, "Hhiperion", "2017", 1, "", "Actos impuros" },
                    { "9788490021033", "Dimas Prychyslyy", "", "9788490021033", "espanhol", 10f, "Hiperión", "2017", 1, "", "Molly House" },
                    { "9788490021408", "Rodrigo García Marina", "", "9788490021408", "", 10f, "Ediciones Hiperión, S. L.", "Mar 30, 2019", 1, "", "Edad" },
                    { "9788490021439", "Carlos Catena Cózar", "", "9788490021439", "espanhol", 10f, "Ediciones Hiperión", "2019", 0, "", "Los días hábiles" },
                    { "9788490021576", "Juan Gallego Benot", "https://covers.openlibrary.org/b/isbn/9788490021576-L.jpg", "9788490021576", "", 10f, "Ediciones Hiperión, S. L.", "Mar 20, 2020", 1, "", "Oración en el huerto" },
                    { "9788490022146", "", "", "9788490022146", "", 12.5f, "", "", 1, "", "Lugares donde quienes se amaron se amaron mucho" },
                    { "9788490668061", "", "", "9788490668061", "", 18f, "Tusquets", "2019", 0, "", "Las malas" },
                    { "9788490669112", "Eduardo Mendicutti", "https://covers.openlibrary.org/b/isbn/9788490669112-L.jpg", "9788490669112", "", 17.5f, "Tusquets Editores S.A.", "Feb 10, 2021", 1, "", "Una mala noche la tiene cualquiera" },
                    { "9788491045670", "Sor Juana Inés de la Cruz", "https://covers.openlibrary.org/b/isbn/9788491045670-L.jpg", "9788491045670", "", 10.95f, "Alianza, Alianza Editorial", "Jan 26, 2017", 0, "", "Antología poética" },
                    { "9788491213321", "María do Cebreiro", "https://covers.openlibrary.org/b/isbn/9788491213321-L.jpg", "9788491213321", "", 13.5f, "Edicións Xerais, Xerais", "Mar 08, 2018", 1, "", "Soños. Arquivos. Cartas" },
                    { "9788491810599", "", "https://covers.openlibrary.org/b/isbn/9788491810599-L.jpg", "9788491810599", "", 12.3f, "Alianza", "2018", 0, "", "Antología poética" },
                    { "9788491812920", "Luis Cernuda", "https://covers.openlibrary.org/b/isbn/9788491812920-L.jpg", "9788491812920", "", 13.95f, "Alianza Editorial", "Sep 13, 2018", 1, "", "La realidad y el deseo (1924-1962)" },
                    { "9788492813209", "Miquel Missé", "", "9788492813209", "espanhol", 20f, "Egales Editorial", "2010", 0, "", "El género desordenado: Críticas en torno a la patalogización de la transexualidad" },
                    { "9788493108604", "", "", "9788493108604", "", 8.95f, "", "", 0, "", "Yo no tengo la culpa de haber nacido tan sexy" },
                    { "9788493664817", "Klaus Mann", "", "9788493664817", "espanhol", 19.95f, "Cabaret Voltaire", "2012", 0, "", "La danza piadosa" },
                    { "9788493868987", "", "https://covers.openlibrary.org/b/isbn/9788493868987-L.jpg", "9788493868987", "", 18.95f, "Cabaret Voltaire", "2012", 0, "", "Paul Bowles, el recluso de Tánger" },
                    { "9788493993573", "Alberto Berzosa Camacho", "", "9788493993573", "espanhol", 28.54f, "Brumaria", "2014", 1, "", "Homoherejías fílmicas: Cine homosexual subversivo en España en los años setenta y ochenta" },
                    { "9788494035364", "Muhammad Sukri", "https://covers.openlibrary.org/b/isbn/9788494035364-L.jpg", "9788494035364", "", 17.95f, "Editorial Cabaret Voltaire", "May 01, 2013", 0, "", "Jean Genet en Tánger" },
                    { "9788494218514", "Agustin Gomez-Arcos", "", "9788494218514", "espanhol", 21.95f, "Cabaret Voltaire", "2014", 1, "", "María República" },
                    { "9788494218576", "", "https://covers.openlibrary.org/b/isbn/9788494218576-L.jpg", "9788494218576", "", 21.95f, "Cabaret Voltaire", "2015", 1, "", "El cordero carnívoro" },
                    { "9788494241314", "Barbara Adair", "https://covers.openlibrary.org/b/isbn/9788494241314-L.jpg", "9788494241314", "", 16.95f, "Editorial Dos Bigotes", "May 19, 2014", 2, "", "Los deseos afines: Narraciones africanas contra la homofobia" },
                    { "9788494241321", "Edward Prime-Stevenson", "https://covers.openlibrary.org/b/isbn/9788494241321-L.jpg", "9788494241321", "", 15.95f, "Editorial Dos Bigotes", "Jun 16, 2014", 1, "", "Imre: una memoria íntima" },
                    { "9788494241383", "", "", "9788494241383", "", 19.95f, "", "", 0, "", "Mañana hablarán de nosotros: Antología del cuento cubano" },
                    { "9788494311550", "", "", "9788494311550", "", 13f, "", "", 0, "", "Los pecados de las ciudades de la llanur" },
                    { "9788494311598", "", "", "9788494311598", "", 13f, "", "", 1, "", "La inversión sexual en las mujeres" },
                    { "9788494355974", "", "https://covers.openlibrary.org/b/isbn/9788494355974-L.jpg", "9788494355974", "", 16.95f, "Dosbigotes", "2016", 1, "", "Una barba para dos y otros 99 microrrelatos eróticos" },
                    { "9788494448850", "", "", "9788494448850", "", 8f, "", "", 0, "", "Un útero es del tamaño de un puño" },
                    { "9788494504327", "", "https://covers.openlibrary.org/b/isbn/9788494504327-L.jpg", "9788494504327", "", 20f, "CAPITAN SWING", "2016", 1, "", "Borderlands / La frontera: La nueva mestiza" },
                    { "9788494519932", "", "", "9788494519932", "", 10f, "", "", 1, "", "Manor" },
                    { "9788494519970", "", "", "9788494519970", "", 13.5f, "", "", 1, "", "La zona sotádica" },
                    { "9788494519994", "", "", "9788494519994", "", 14f, "", "", 1, "", "Escal-Vigor" },
                    { "9788494520815", "", "https://covers.openlibrary.org/b/isbn/9788494520815-L.jpg", "9788494520815", "espanhol", 18f, "Ultramarinos", "2016", 1, "", "Mi mas hermoso texto" },
                    { "9788494682452", "Gloria Fortún", "https://covers.openlibrary.org/b/isbn/9788494682452-L.jpg", "9788494682452", "", 19.95f, "Editorial Dos Bigotes", "Sep 25, 2017", 2, "", "La nueva mujer: Relatos de escritoras estadounidenses del siglo XIX" },
                    { "9788494710803", "", "", "9788494710803", "", 15.95f, "", "", 0, "", "Tennessee Williams en Tánger" },
                    { "9788494710841", "", "https://covers.openlibrary.org/b/isbn/9788494710841-L.jpg", "9788494710841", "", 17.95f, "Cabaret Voltaire, Editorial Cabaret Voltaire", "2018", 1, "", "El que es digno de ser amado" },
                    { "9788494878459", "", "", "9788494878459", "", 14f, "", "", 1, "", "Los Neoplatónicos" },
                    { "9788494878473", "", "", "9788494878473", "", 15f, "", "", 0, "", "Por los caminos de Sodoma" },
                    { "9788494941481", "", "", "9788494941481", "", 18.95f, "", "", 0, "", "Mis padres" },
                    { "9788494945441", "", "", "9788494945441", "", 15f, "", "", 0, "", "El condenado a vivir" },
                    { "9788494967412", "Valeria Vegas", "https://covers.openlibrary.org/b/isbn/9788494967412-L.jpg", "9788494967412", "", 19.95f, "Editorial Dos Bigotes", "Feb 25, 2019", 1, "", "Vestidas de azul: Análisis social y cinematográfico de la mujer transexual en los años de la transición española" },
                    { "9788494967450", "Alex Espinoza", "https://covers.openlibrary.org/b/isbn/9788494967450-L.jpg", "9788494967450", "", 19.95f, "Editorial Dos Bigotes", "Feb 03, 2020", 1, "", "Cruising: Historia íntima de un pasatiempo radical" },
                    { "9788495346971", "Monique Wittig", "https://covers.openlibrary.org/b/isbn/9788495346971-L.jpg", "9788495346971", "espanhol", 16.95f, "", "", 0, "", "El pensamiento heterosexual y otros ensayos" },
                    { "9788495346995", "", "https://covers.openlibrary.org/b/isbn/9788495346995-L.jpg", "9788495346995", "espanhol", 19f, "", "", 0, "", "Teoría queer" },
                    { "9788495430096", "", "", "9788495430096", "", 6.2f, "", "", 1, "", "Four Roses" },
                    { "9788496614512", "", "", "9788496614512", "", 18.9f, "", "", 1, "", "El deseo homosexual / Terror anal" },
                    { "9788497840507", "Tamsin Spargo", "https://covers.openlibrary.org/b/isbn/9788497840507-L.jpg", "9788497840507", "", 5f, "GEDISA", "Nov 04, 2005", 0, "", "Foucault y la teoría queer" },
                    { "9788497931625", "", "", "9788497931625", "espanhol", 9.95f, "Debolsillo", "February 28, 2004", 1, "", "Poesía completa: I – Libro de poemas / Primeras canciones / Canciones" },
                    { "9788497931632", "", "https://covers.openlibrary.org/b/isbn/9788497931632-L.jpg", "9788497931632", "espanhol", 9.95f, "Debolsillo", "February 28, 2004", 1, "", "Poesía completa: II – Romancero gitano / Poema del cante jondo" },
                    { "9788497931649", "", "https://covers.openlibrary.org/b/isbn/9788497931649-L.jpg", "9788497931649", "espanhol", 9.95f, "Debolsillo", "February 28, 2004", 0, "", "Poesía completa: III – Poeta en Nueva York / Sonetos" },
                    { "9788497932905", "Federico García Lorca", "https://covers.openlibrary.org/b/isbn/9788497932905-L.jpg", "9788497932905", "espanhol", 9.95f, "Debolsillo", "May 31, 2004", 1, "", "Teatro completo: II – El público / Así que pasen cinco años" },
                    { "9788497933346", "Federico García Lorca", "https://covers.openlibrary.org/b/isbn/9788497933346-L.jpg", "9788497933346", "", 10.95f, "DEBOLSILLO, Debolsillo", "Jun 13, 2018", 1, "", "Teatro completo: III – Bodas de sangre / Yerma" },
                    { "9788497933353", "Federico García Lorca", "https://covers.openlibrary.org/b/isbn/9788497933353-L.jpg", "9788497933353", "espanhol", 9.95f, "Debolsillo", "June 30, 2004", 1, "", "Teatro completo: IV – La casa de Bernarda Alba / Doña Rosita la soltera" },
                    { "9788497936422", "", "", "9788497936422", "", 12.95f, "Siruela : Debolsillo", "2005", 1, "", "La danza de la realidad" },
                    { "9788497936439", "Alejandro Jodorowsky", "https://covers.openlibrary.org/b/isbn/9788497936439-L.jpg", "9788497936439", "espanhol", 9.95f, "", "", 1, "", "Psicomagia" },
                    { "9788498653557", "Lois - Salgado Daniel Pereiro", "https://covers.openlibrary.org/b/isbn/9788498653557-L.jpg", "9788498653557", "", 13.1f, "Editorial Galaxia, S.A.", "Feb 28, 2011", 1, "", "Antoloxía poética" },
                    { "9788498881455", "Rafael M. Mérida Jiménez", "", "9788498881455", "espanhol", 17f, "Icaria editorial", "2009", 0, "", "Manifiestos gays, lesbianos y queer: Testimonios de una lucha (1969-1994)" },
                    { "9788498954111", "", "https://covers.openlibrary.org/b/isbn/9788498954111-L.jpg", "9788498954111", "", 22f, "Visor Libros, VISOR LIBROS, S.L.", "2021", 0, "", "Poesía completa (1993-2019)" },
                    { "9788498954272", "Mario Obrero", "", "9788498954272", "espanhol", 12f, "Visor Libros", "2021", 1, "", "Peachtree City" },
                    { "9788498954500", "", "https://covers.openlibrary.org/b/isbn/9788498954500-L.jpg", "9788498954500", "", 30f, "Visor", "2021", 0, "", "Poesía completa" },
                    { "9788498954562", "", "", "9788498954562", "", 14f, "", "", 0, "", "Canciones de Alejandría" },
                    { "9788499530765", "Alfonso Hernández Catá", "", "9788499530765", "espanhol", 5f, "Linkgua Ediciones, S.L.", "2014", 1, "", "El ángel de Sodoma" },
                    { "9788499703015", "Ramon Llull", "", "9788499703015", "espanhol", 9.9f, "Esfera de los Libros", "2012", 1, "", "Libro del amigo y del amado" },
                    { "9788499989556", "", "https://covers.openlibrary.org/b/isbn/9788499989556-L.jpg", "9788499989556", "", 18.9f, "Temas de hoy", "2023", 0, "", "La mejor actriz de reparto" },
                    { "9788499989587", "", "", "9788499989587", "", 17.9f, "", "", 0, "", "Melancolía" },
                    { "9788501115591", "", "https://covers.openlibrary.org/b/isbn/9788501115591-L.jpg", "9788501115591", "português", 16.96f, "Rosa dos tempos", "2023", 0, "", "O feminismo é para todo mundo: Políticas arrebatadoras" },
                    { "9788520945988", "", "", "9788520945988", "", 15.9f, "", "", 1, "", "O beijo no asfalto" },
                    { "9788522006649", "", "", "9788522006649", "", 16.96f, "", "", 0, "", "Carta a minha filha" },
                    { "9788535915389", "", "", "9788535915389", "", 27.56f, "", "", 0, "", "Ciranda de pedra" },
                    { "9788535923629", "Ana Cristina Cesar", "", "9788535923629", "português", 40.28f, "Companhia das Letras", "2013", 0, "", "Poética" },
                    { "9788535927719", "Victor Heringer", "", "9788535927719", "português", 26.5f, "Companhia das Letras", "2016", 0, "", "O amor dos homens avulsos" },
                    { "9788535928716", "", "", "9788535928716", "", 31.8f, "", "", 1, "", "Contra a moral e os bons costumes: A ditadura e a repressão à comunidade LGBT" },
                    { "9788535928853", "[author not identified]", "https://covers.openlibrary.org/b/isbn/9788535928853-L.jpg", "9788535928853", "", 39.22f, "Companhia das Letras", "May 14, 2017", 0, "", "Da poesia" },
                    { "9788535929812", "", "", "9788535929812", "", 29.68f, "", "", 0, "", "Stella Manhattan" },
                    { "9788535929829", "Angélica Freitas", "", "9788535929829", "", 14.84f, "Companhia Das Letras, Companhia das Letras", "Nov 28, 2017", 1, "", "Um útero é do tamanho de um punho" },
                    { "9788535930863", "Hilda Hilst", "https://covers.openlibrary.org/b/isbn/9788535930863-L.jpg", "9788535930863", "português", 47.7f, "Companhia das Letras", "2018", 1, "", "Da prosa" },
                    { "9788535931280", "Caio Fernando Abreu", "", "9788535931280", "", 42.4f, "Companhia das Letras", "", 1, "", "Contos completos" },
                    { "9788535931501", "", "", "9788535931501", "", 27.56f, "", "", 1, "", "Glória" },
                    { "9788535932669", "Caio Fernando Abreu", "https://covers.openlibrary.org/b/isbn/9788535932669-L.jpg", "9788535932669", "", 26.5f, "Companhia das Letras", "", 0, "", "Morangos mofados" },
                    { "9788535933512", "Angélica Freitas", "", "9788535933512", "português", 19.61f, "Companhia das Letras", "2020", 1, "", "Canções de atormentar" },
                    { "9788535933581", "", "", "9788535933581", "", 15.9f, "", "", 1, "", "Ideias para o fim do mundo" },
                    { "9788535933697", "[author not identified]", "https://covers.openlibrary.org/b/isbn/9788535933697-L.jpg", "9788535933697", "", 15.9f, "Companhia das Letras", "Apr 06, 2019", 0, "", "A vida não é útil: Ideias para salvar a Humanidade" },
                    { "9788535935417", "", "", "9788535935417", "", 33.92f, "", "", 0, "", "Sodomita" },
                    { "9788542223798", "", "", "9788542223798", "", 25.44f, "", "", 0, "", "Descolonizando afetos: Experimentações sobre outras formas de amar" },
                    { "9788544107881", "", "", "9788544107881", "", 29.68f, "", "", 0, "", "Viagem solitária" },
                    { "9788546901401", "Jonathan C. Young", "", "9788546901401", "", 25.44f, "WMF Martins Fontes", "", 0, "", "Ensinando a transgredir: A educação como prática da liberdade" },
                    { "9788546904587", "", "", "9788546904587", "", 28.62f, "", "", 2, "", "Irmãs do inhame: Mulheres negras e autorrecuperação" },
                    { "9788547000653", "João Silvério Trevisan", "", "9788547000653", "português", 40.28f, "Objetiva", "2018", 0, "", "Devassos no paraíso: A homossexualidade no Brasil, da colônia à atualidade" },
                    { "9788547000936", "", "", "9788547000936", "", 19f, "", "", 0, "", "Velhice transviada: Memórias e reflexões" },
                    { "9788547001391", "João Silvério Trevisan", "", "9788547001391", "português", 39.22f, "Objetiva", "2021", 1, "", "Seis balas num buraco só: A crise do masculino" },
                    { "9788569433507", "", "", "9788569433507", "", 13f, "", "", 0, "", "O mais difícil do capitalismo é encontrar o sítio onde pôr as bombas" },
                    { "9788569433767", "", "", "9788569433767", "", 12f, "", "", 0, "", "A fúria da loiça da China" },
                    { "9788571051393", "", "", "9788571051393", "", 13.5f, "", "", 0, "", "Degelo" },
                    { "9788571051409", "Debora Ribeiro", "", "9788571051409", "português", 13f, "Editora Urutau", "2019", 1, "", "Quem dera o sangue fosse só o da menstruação: Volume I" },
                    { "9788581280554", "", "", "9788581280554", "", 12f, "", "", 14, "", "Quinze anos de minha vida" },
                    { "9788588808683", "Chico Felitti", "https://covers.openlibrary.org/b/isbn/9788588808683-L.jpg", "9788588808683", "português", 23.32f, "Todavia", "2019", 0, "", "Ricardo e Vânia" },
                    { "9788593115257", "", "", "9788593115257", "", 23.32f, "", "", 1, "", "Erguer a voz: pensar como feminista, pensar como negra" },
                    { "9788593115363", "", "", "9788593115363", "", 26.5f, "", "", 1, "", "Ética do amor livre" },
                    { "9788593115769", "", "", "9788593115769", "", 25.44f, "", "", 1, "", "Pertencimento: Uma cultura do lugar" },
                    { "9788593115783", "", "", "9788593115783", "", 27.56f, "", "", 0, "", "Cultura fora da lei: representações da resistência" },
                    { "9788593115912", "", "", "9788593115912", "", 32.86f, "", "", 3, "", "Novas fronteiras das histórias LGBTI+ no Brasil" },
                    { "9788598349688", "Djamila Ribeiro", "https://covers.openlibrary.org/b/isbn/9788598349688-L.jpg", "9788598349688", "", 12.72f, "Pólen Livros, Editora Jandaira", "Jan 04, 2019", 0, "", "Lugar de fala (Feminismos plurais)" },
                    { "9788598349695", "", "", "9788598349695", "", 12.72f, "", "", 0, "", "Interseccionalidade (Feminismos plurais)" },
                    { "9788862086554", "Peter Berlin", "", "9788862086554", "inglês", 45f, "Damiani", "2019", 1, "", "Peter Berlin: Icon, Artist, Photosexual" },
                    { "9788874399284", "Hugh Nini", "https://covers.openlibrary.org/b/isbn/9788874399284-L.jpg", "9788874399284", "inglês", 75.35f, "Five Continents Editions Srl", "Oct 14, 2020", 0, "", "Loving: A Photographic History of Men in Love, 1850s-1950s" },
                    { "9789569974168", "Pedro Lemebel", "", "9789569974168", "espanhol", 19f, "Alquimia Ediciones", "2018", 1, "", "No tengo amigos, tengo amores: Extractos de entrevistas" },
                    { "9789587040783", "", "", "9789587040783", "", 13.55f, "", "", 1, "", "Los días azules" },
                    { "9789720030399", "Valter Hugo Mãe", "", "9789720030399", "Português", 15.5f, "Porto Editora", "2018-01-01", 1, "", "O paraíso são os outros" },
                    { "9789720031570", "Isabel de Sá", "", "9789720031570", "Português", 12.2f, "Porto Editora", "2019-01-01", 1, "", "O real arrasa tudo" },
                    { "9789720031600", "Andreia C. Faria", "", "9789720031600", "Português", 16.65f, "Porto Editora", "2019-01-01", 0, "", "Alegria para o fim do mundo" },
                    { "9789720031846", "Walter Isaacson", "", "9789720031846", "Português", 24f, "Porto Editora", "2019-01-01", 0, "", "Leonardo da Vinci" },
                    { "9789720032492", "Emanuel Madalena", "", "9789720032492", "Português", 12.2f, "Porto Editora", "2019-01-01", 0, "", "Sob a forma do silêncio" },
                    { "9789720033024", "Cruzeiro Seixas", "", "9789720033024", "Português", 22.2f, "Porto Editora", "2020-01-01", 1, "", "Obra poética: I" },
                    { "9789720033031", "Cruzeiro Seixas", "", "9789720033031", "Português", 24.4f, "Porto Editora", "2020-01-01", 0, "", "Obra poética: II" },
                    { "9789720033048", "Cruzeiro Seixas", "", "9789720033048", "Português", 25.5f, "Porto Editora", "2020-01-01", 0, "", "Obra poética: III" },
                    { "9789720033260", "André Tecedeiro", "", "9789720033260", "Português", 16.65f, "Porto Editora", "2020-01-01", 2, "", "A axila de Egon Schiele: poesia reunida" },
                    { "9789720033659", "Valter Hugo Mãe", "", "9789720033659", "Português", 17.75f, "Porto Editora", "2020-01-01", 0, "", "Contra mim" },
                    { "9789720033857", "Richard Zimler", "", "9789720033857", "Português", 17.75f, "Porto Editora", "2020-01-01", 1, "", "Insubmissos" },
                    { "9789720034861", "Valter Hugo Mãe", "", "9789720034861", "Português", 17.75f, "Porto Editora", "2021-01-01", 2, "", "As doenças do Brasil" },
                    { "9789720035226", "Teolinda Gersão", "", "9789720035226", "Português", 16.65f, "Porto Editora", "2022-01-01", 1, "", "O cavalo de sol" },
                    { "9789720042361", "Luisgé Martín", "", "9789720042361", "Português", 16.65f, "Porto Editora", "2017-01-01", 0, "", "O amor do avesso" },
                    { "9789720044945", "Valter Hugo Mãe", "https://covers.openlibrary.org/b/isbn/9789720044945-L.jpg", "9789720044945", "Português", 17.75f, "Porto Editora", "2013-01-01", 0, "", "A desumanização" },
                    { "9789720046543", "José Saramago", "", "9789720046543", "Português", 17.7f, "Porto Editora", "2014-01-01", 0, "", "A caverna" },
                    { "9789720046673", "José Saramago", "", "9789720046673", "Português", 0f, "Porto Editora", "2014-01-01", 0, "", "As intermitências da morte" },
                    { "9789720047335", "Valter Hugo Mãe", "", "9789720047335", "Português", 17.75f, "Porto Editora", "2016-01-01", 0, "", "a máquina de fazer espanhóis" },
                    { "9789720047342", "Valter Hugo Mãe", "https://covers.openlibrary.org/b/isbn/9789720047342-L.jpg", "9789720047342", "Português", 17.75f, "Porto Editora", "2015-01-01", 0, "", "o remorso de baltazar serapião" },
                    { "9789720047397", "Valter Hugo Mãe", "", "9789720047397", "Português", 17.75f, "Porto Editora", "2015-01-01", 1, "", "O filho de mil homens" },
                    { "9789720047410", "Valter Hugo Mãe", "", "9789720047410", "Português", 17.75f, "Porto Editora", "2015-01-01", 1, "", "o apocalipse dos trabalhadores" },
                    { "9789720047472", "Valter Hugo Mãe", "https://covers.openlibrary.org/b/isbn/9789720047472-L.jpg", "9789720047472", "Português", 17.75f, "Porto Editora", "2015-01-01", 0, "", "o nosso reino" },
                    { "9789720048103", "Valter Hugo Mãe", "https://covers.openlibrary.org/b/isbn/9789720048103-L.jpg", "9789720048103", "Português", 16.65f, "Porto Editora", "2015-01-01", 0, "", "Contos de cães e maus lobos" },
                    { "9789720048424", "David Walliams", "", "9789720048424", "Português", 16.65f, "Porto Editora", "2017-01-01", 0, "", "Campeão de saias" },
                    { "9789720048547", "Richard Zimler", "", "9789720048547", "Português", 18.85f, "Porto Editora", "2016-01-01", 1, "", "O evangelho segundo Lázaro" },
                    { "9789720048653", "Becky Albertalli", "", "9789720048653", "Português", 15.5f, "Porto Editora", "2017-01-01", 1, "", "O coração de Simon contra o mundo" },
                    { "9789720048868", "Valter Hugo Mãe", "", "9789720048868", "Português", 17.75f, "Porto Editora", "2016-01-01", 1, "", "Homens imprudentemente poéticos" },
                    { "9789720071491", "Truman Capote", "", "9789720071491", "Português", 16.65f, "Sextante", "2011-01-01", 0, "", "A harpa de ervas" },
                    { "9789720425065", "E. A. Abbott", "", "9789720425065", "Português", 12.2f, "Porto Editora", "2016-01-01", 0, "", "Flatland: O mundo plano" },
                    { "9789720712776", "Holly Price", "", "9789720712776", "Português", 12.2f, "Porto Editora", "2021-01-01", 0, "", "Autocarro das cores" },
                    { "9789720715593", "Giancarlo Macrì", "", "9789720715593", "Português", 16.65f, "Porto Editora", "2022-01-01", 0, "", "O muro" },
                    { "9789720715968", "", "", "9789720715968", "Português", 9.99f, "Porto Editora", "2020-01-01", 0, "", "As rodas do autocarro" },
                    { "9789720724182", "Elise Gravel", "", "9789720724182", "Português", 13.3f, "Porto Editora", "2024-01-01", 0, "", "Todos nós!" },
                    { "9789720724199", "Elise Gravel", "", "9789720724199", "Português", 13.3f, "Porto Editora", "2024-01-01", 1, "", "O meu corpo!" },
                    { "9789720793065", "Armando Silva Carvalho", "", "9789720793065", "", 11.1f, "Assírio & Alvim", "2012-01-01", 1, "", "De amore" },
                    { "9789722026369", "Mário de Sá Carneiro", "", "9789722026369", "Português", 12.9f, "Dom Quixote", "2010-01-01", 1, "", "Antologia poética" },
                    { "9789722028547", "", "", "9789722028547", "", 9.9f, "", "", 1, "", "As perturbações do pupilo Törless" },
                    { "9789722028615", "", "", "9789722028615", "", 18.17f, "", "", 0, "", "Diário remendado: 1971-1975" },
                    { "9789722029094", "Hannah Arendt", "https://covers.openlibrary.org/b/isbn/9789722029094-L.jpg", "9789722029094", "Português", 32.9f, "Dom Quixote", "2008-01-01", 1, "", "As origens do totalitarismo" },
                    { "9789722030960", "Truman Capote", "", "9789722030960", "Português", 19.9f, "Dom Quixote", "2016-01-01", 0, "", "A sangue frio" },
                    { "9789722031325", "Truman Capote", "https://covers.openlibrary.org/b/isbn/9789722031325-L.jpg", "9789722031325", "Português", 12.9f, "Dom Quixote", "2009-01-01", 0, "", "Breakfast at Tiffany's" },
                    { "9789722033046", "Jonathan Littell", "https://covers.openlibrary.org/b/isbn/9789722033046-L.jpg", "9789722033046", "Português", 27.7f, "Dom Quixote", "2008-01-01", 1, "", "As benevolentes" },
                    { "9789722034081", "António Lobo Antunes", "", "9789722034081", "Português", 19.9f, "Dom Quixote", "2008-01-01", 0, "", "A morte de Carlos Gardel" },
                    { "9789722034098", "António Lobo Antunes", "", "9789722034098", "Português", 24.9f, "Dom Quixote", "2008-01-01", 1, "", "Que farei quando tudo arde?" },
                    { "9789722037600", "Marguerite Yourcenar", "", "9789722037600", "Português", 16.9f, "Dom Quixote", "2009-01-01", 1, "", "A obra ao negro" },
                    { "9789722038072", "Honoré de Balzac", "", "9789722038072", "Português", 9.9f, "Dom Quixote", "2009-01-01", 0, "", "Ilusões perdidas" },
                    { "9789722038676", "António Lobo Antunes", "", "9789722038676", "Português", 20.9f, "D. Quixote", "2009-01-01", 1, "", "Que cavalos são aqueles que fazem sombra no mar?" },
                    { "9789722039727", "Robert Louis Stevenson", "", "9789722039727", "Português", 9.9f, "Dom Quixote", "2010-01-01", 1, "", "O estranho caso do Dr. Jekyll e Mr. Hyde" },
                    { "9789722040112", "Maria Isabel Barreno", "", "9789722040112", "Português", 22.2f, "Dom Quixote", "2014-01-01", 1, "", "Novas Cartas Portuguesas" },
                    { "9789722040334", "Alfred Doblin", "", "9789722040334", "Português", 22.2f, "Dom Quixote", "2010-01-01", 0, "", "Berlim Alexanderplatz" },
                    { "9789722044868", "Eduardo Pita", "", "9789722044868", "Português", 15f, "Dom Quixote", "2011-01-01", 1, "", "Desobediência: poemas escolhidos" },
                    { "9789722046527", "Mário Vargas Llosa", "", "9789722046527", "Português", 14.9f, "Dom Quixote", "2011-01-01", 1, "", "Os cachorros / Os chefes" },
                    { "9789722048057", "Alan Hollinghurst", "", "9789722048057", "Português", 24.9f, "D. Quixote", "2011-01-01", 1, "", "O filho do desconhecido" },
                    { "9789722053280", "Natália Correia", "", "9789722053280", "português", 17.7f, "Dom Quixote", "2013", 0, "", "Antologia poética" },
                    { "9789722054102", "Mário Cláudio", "", "9789722054102", "Português", 15.9f, "Dom Quixote", "2014-01-01", 0, "", "Triunfo do amor português" },
                    { "9789722054126", "Maria Teresa Horta", "", "9789722054126", "Português", 12.9f, "Dom Quixote", "2014-01-01", 0, "", "Ambas as mãos sobre o corpo" },
                    { "9789722054386", "Mário Cláudio", "", "9789722054386", "Português", 13.9f, "Dom Quixote", "2014-01-01", 0, "", "Retrato de rapaz" },
                    { "9789722056298", "Ana Luisa Amaral", "", "9789722056298", "português", 20f, "D.Quixote", "2014", 1, "", "“Novas Cartas Portuguesas”: entre Portugal e o mundo" },
                    { "9789722057073", "Judite Teixeira", "", "9789722057073", "Português", 18.9f, "D. Quixote", "2015-01-01", 0, "", "Poesia e prosa" },
                    { "9789722057431", "Chimamanda Ngozi Adichie", "", "9789722057431", "Português", 8.5f, "Dom Quixote", "2015-01-01", 0, "", "Todos devemos ser feministas" },
                    { "9789722058544", "Mário Cláudio", "", "9789722058544", "Português", 19.9f, "D. Quixote", "2015-01-01", 1, "", "Astronomia" },
                    { "9789722059688", "Hermann Hesse", "", "9789722059688", "Português", 18.9f, "Dom Quixote", "2016-01-01", 1, "", "Narciso e Goldmund" },
                    { "9789722059725", "Mário de Sá Carneiro", "", "9789722059725", "Português", 22.2f, "Dom Quixote", "2016-01-01", 0, "", "Prosa" },
                    { "9789722064309", "Chimamanda Ngozi Adichie", "", "9789722064309", "Português", 8.5f, "Dom Quixote", "2018-01-01", 0, "", "Querida Ijeawele: como educar para o feminismo" },
                    { "9789722064736", "Pedro Juan Gutiérrez", "", "9789722064736", "Português", 16.9f, "Dom Quixote", "2018-01-01", 0, "", "Fabián e o caos" },
                    { "9789722065153", "Sasha Marianna Salzmann", "", "9789722065153", "Português", 18.8f, "D. Quixote", "2018-01-01", 0, "", "Fora de si" },
                    { "9789722065863", "Alan Hollinghurst", "", "9789722065863", "Português", 20.9f, "Dom Quixote", "2018-01-01", 1, "", "O caso Sparsholt" },
                    { "9789722065993", "Afonso Reis Cabral", "https://covers.openlibrary.org/b/isbn/9789722065993-L.jpg", "9789722065993", "Português", 16.6f, "D. Quixote", "2018-01-01", 1, "", "Pão de açúcar" },
                    { "9789722066983", "Didier Eribon", "", "9789722066983", "Português", 17.7f, "Dom Quixote", "2019-01-01", 1, "", "Regresso a Reims" },
                    { "9789722067317", "Maria Teresa Horta", "", "9789722067317", "Português", 15.9f, "Dom Quixote", "2019-01-01", 1, "", "Eu sou a minha poesia: Antologia pessoal" },
                    { "9789722067331", "Maria Teresa Horta", "", "9789722067331", "Português", 14.9f, "D. Quixote", "2019-01-01", 1, "", "Quotidiano instável: Crómicas (1968-1972)" },
                    { "9789722067805", "Eduardo Pita", "", "9789722067805", "Português", 12.5f, "Dom Quixote", "2019-01-01", 0, "", "Persona" },
                    { "9789722069489", "Chimamanda Ngozi Adichie", "", "9789722069489", "Português", 12.5f, "D. Quixote", "2020-01-01", 0, "", "Todos devemos ser feministas (Ilustrado)" },
                    { "9789722071086", "António Lobo Antunes", "", "9789722071086", "Português", 20.9f, "Dom Quixote", "2020-01-01", 1, "", "Diccionario da linguagem das flores" },
                    { "9789722071291", "Hermann Hesse", "", "9789722071291", "Português", 14.9f, "D. Quixote", "2021-01-01", 0, "", "Peter Camenzind" },
                    { "9789722071734", "", "", "9789722071734", "", 17.7f, "", "", 1, "", "A biblioteca da piscina" },
                    { "9789722072007", "Merieke Lucas Rijneveld", "", "9789722072007", "Português", 15.5f, "Dom Quixote", "2021-01-01", 2, "", "O desassossego da noite" },
                    { "9789722072151", "Eduardo Pita", "", "9789722072151", "Português", 11f, "Dom Quixote", "2021-01-01", 0, "", "Devastação" },
                    { "9789722073165", "Maria Teresa Horta", "", "9789722073165", "Português", 12.9f, "Publicações Dom Quixote", "2021-01-01", 1, "", "Paixão" },
                    { "9789722074124", "William Faulkner", "", "9789722074124", "Português", 17.7f, "Dom Quixote", "2022-01-01", 1, "", "Na minha morte" },
                    { "9789722074162", "Itamar Vieira Junior", "", "9789722074162", "Português", 15.9f, "Dom Quixote", "2022-01-01", 0, "", "Doramar ou A odisseia: Histórias" },
                    { "9789722074896", "Maria Isabel Barreno", "", "9789722074896", "Português", 24.9f, "Dom Quixote", "2022-01-01", 0, "", "Novas Cartas Portuguesas (Capa Dura)" },
                    { "9789722080729", "Jessica Herthel", "", "9789722080729", "Português", 11.9f, "Dom Quixote", "2024-01-01", 3, "", "Sou a Jazz" },
                    { "9789722081313", "Stênio Gardel", "", "9789722081313", "Português", 16.6f, "Dom Quixote", "2024-01-01", 3, "", "A palavra que resta" },
                    { "9789722100397", "", "", "9789722100397", "", 9.9f, "", "", 0, "", "Viagem à roda do meu nome" },
                    { "9789722115758", "", "", "9789722115758", "", 9.9f, "", "", 1, "", "Vagabundos de nós" },
                    { "9789722120753", "Manuela Castro Neves", "", "9789722120753", "Português", 10.5f, "Caminho", "2009-01-01", 0, "", "O elefante diferente (que espantava toda a gente)" },
                    { "9789722121118", "Frederico Lourenço", "", "9789722121118", "Português", 12.9f, "Caminho", "2010-01-01", 1, "", "Santo Asinha e outros poemas" },
                    { "9789722121200", "Raymond Briggs", "", "9789722121200", "Português", 11.9f, "Caminho", "2010-01-01", 1, "", "O boneco de neve" },
                    { "9789722124478", "Frederico Lourenço", "", "9789722124478", "português", 12.9f, "Caminho", "2011", 1, "", "Clara suspeita de luz" },
                    { "9789722127752", "Manuela Castro Neves", "", "9789722127752", "Português", 10.9f, "Caminho", "2015-01-01", 0, "", "O pato amarelo e o gato riscado" },
                    { "9789722128162", "Paulina Chiziane", "https://covers.openlibrary.org/b/isbn/9789722128162-L.jpg", "9789722128162", "Português", 15.9f, "Caminho", "2016-01-01", 0, "", "Ventos do apocalipse" },
                    { "9789722128186", "Paulina Chiziane", "", "9789722128186", "Português", 15.9f, "Caminho", "2016-01-01", 1, "", "Niketche: Uma história de poligamia" },
                    { "9789722128469", "Moacyr Scliar", "", "9789722128469", "Português", 19.9f, "Caminho", "2017-01-01", 0, "", "O centauro no jardim" },
                    { "9789722129794", "Manuela Castro Neves", "", "9789722129794", "Português", 10.9f, "Caminho", "2019-01-01", 0, "", "Uma girafa reticulada, uma zebra bem riscada e uma grande caminhada" },
                    { "9789722130547", "Sam McBratney", "", "9789722130547", "Português", 12.9f, "Caminho", "2020-01-01", 0, "", "Queres ser meu amigo?" },
                    { "9789722131377", "", "", "9789722131377", "", 15.9f, "", "", 1, "", "“Exterminem todas as bestas”" },
                    { "9789722522809", "Colm Tóibín", "", "9789722522809", "Português", 7.5f, "Bertrand", "2011-01-01", 0, "", "Mães e filhos" },
                    { "9789722523462", "Thomas Pynchon", "", "9789722523462", "Português", 17.7f, "Bertrand", "2011-01-01", 0, "", "V." },
                    { "9789722525121", "Thomas Pynchon", "", "9789722525121", "", 28.8f, "Bertrand Editora", "Jun 22, 2012", 1, "", "Arco-íris da gravidade" },
                    { "9789722531177", "Marjane Satrapi", "", "9789722531177", "Português", 19.9f, "Bertrand", "2015-01-01", 0, "", "Persépolis" },
                    { "9789722532938", "Sebastian Barry", "", "9789722532938", "Português", 17.7f, "Bertrand", "2017-01-01", 1, "", "Dias sem fim" },
                    { "9789722533867", "Manuela Gonzaga", "", "9789722533867", "Português", 17.7f, "Bertrand", "2018-01-01", 1, "", "António Variações: Entre Braga e Nova Iorque" },
                    { "9789722536158", "Mary Beard", "", "9789722536158", "Português", 12.2f, "Bertrand", "2018-01-01", 0, "", "Mulheres & Poder" },
                    { "9789722536240", "Virginia Woolf", "https://covers.openlibrary.org/b/isbn/9789722536240-L.jpg", "9789722536240", "Português", 18.8f, "Bertrand", "2018-01-01", 0, "", "Diário 1915-1926" },
                    { "9789722536257", "Virginia Woolf", "", "9789722536257", "Português", 18.8f, "Bertrand", "2019-01-01", 0, "", "Diário 1927-1941" },
                    { "9789722536486", "Bruno Bettelheim", "", "9789722536486", "Português", 16.6f, "Bertrand", "2018-01-01", 0, "", "Psicanálise dos contos de fadas" },
                    { "9789722537704", "", "", "9789722537704", "Português", 10.9f, "Bertrand", "2019-01-01", 0, "", "Cucu!" },
                    { "9789722538237", "Shel Silverstein", "https://covers.openlibrary.org/b/isbn/9789722538237-L.jpg", "9789722538237", "Português", 13.3f, "Bertrand", "2019-01-01", 0, "", "O pedaço que falta" },
                    { "9789722538411", "Marta Breen", "", "9789722538411", "Português", 17.7f, "Bertrand", "2020-01-01", 0, "", "Mulheres sem medo" },
                    { "9789722538688", "Ana Bárbara Pedrosa", "", "9789722538688", "Português", 15.5f, "Bertrand Editora", "2019-01-01", 0, "", "Lisboa, chão sagrado" },
                    { "9789722538862", "Shel Silverstein", "", "9789722538862", "Português", 13.3f, "Bertrand", "2020-01-01", 1, "", "O pedaço que falta encontra o grande O" },
                    { "9789722539524", "Liv Strömquist", "", "9789722539524", "Português", 15.5f, "Bertrand", "2021-01-01", 1, "", "O fruto proibido" },
                    { "9789722541091", "Ana Bárbara Pedrosa", "", "9789722541091", "Português", 14.4f, "Bertrand Editora", "2021-01-01", 0, "", "Palavra do Senhor" },
                    { "9789722541589", "Margaret Atwood", "", "9789722541589", "Português", 16.6f, "Bertrand", "2021-01-01", 1, "", "Afectuosamente" },
                    { "9789722542647", "Michaela Coel", "", "9789722542647", "Português", 14.4f, "Bertrand", "2021-01-01", 0, "", "Inadaptados: Um manifesto pessoal" },
                    { "9789722543040", "Oscar Wilde", "", "9789722543040", "Português", 8f, "11x17", "2022-01-01", 1, "", "Teleny" },
                    { "9789722544818", "Andrea Abreu", "", "9789722544818", "Português", 16.6f, "Bertrand", "2023-01-01", 0, "", "Pança de burro" },
                    { "9789722546621", "André Gide", "", "9789722546621", "Português", 18.8f, "Bertrand", "2024-01-01", 2, "", "Os moedeiros falsos" },
                    { "9789722546737", "François Soyer", "", "9789722546737", "Português", 18.8f, "Bertrand", "2024-01-01", 1, "", "A hermafrodita e a Inquisição Portuguesa" },
                    { "9789722723343", "Carla Maia de Almeida", "", "9789722723343", "Português", 11f, "Imprensa Nacional-Casa da Moeda", "2015-01-01", 0, "", "Ana de Castro Osório: A mulher que votou na literatura" },
                    { "9789722727259", "1475-1564 Miguel Ângelo", "", "9789722727259", "Português", 35f, "Imprensa Nacional - Casa da Moeda", "2019-01-01", 0, "", "Miguel Ângelo: Rimas" },
                    { "9789722727853", "Giuseppe Ungaretti", "", "9789722727853", "Português", 45f, "Imprensa Nacional", "2021-01-01", 1, "", "Vida de um homem: Toda a poesia" },
                    { "9789722728522", "Carla Maia de Almeida", "", "9789722728522", "Português", 11f, "Pato Lógico", "2021-01-01", 1, "", "Carolina Beatriz Ângelo: Um pequeno grande gesto de coragem" },
                    { "9789722728881", "Paulo Teixeira", "", "9789722728881", "Português", 30f, "Imprensa Nacional", "2020-01-01", 1, "", "O último poeta romano" },
                    { "9789722728898", "António Cícero", "", "9789722728898", "Português", 20f, "Imprensa Nacional", "2020-01-01", 0, "", "Guardar a cidade e os livros porventura" },
                    { "9789722729048", "Inês Fonseca Santos", "", "9789722729048", "Português", 11f, "Pato Lógico", "2021-01-01", 0, "", "António Variações: Fora de tom" },
                    { "9789723308649", "", "", "9789723308649", "", 7.5f, "", "", 1, "", "Salomé" },
                    { "9789723602210", "", "", "9789723602210", "", 31.8f, "", "", 1, "", "História da vida privada: 1 – Do Império Romano ao Ano Mil" },
                    { "9789723602265", "", "", "9789723602265", "", 7.57f, "", "", 1, "", "O herói das mansardas de Mansard" },
                    { "9789723603149", "", "", "9789723603149", "", 31.8f, "", "", 1, "", "História das mulheres: 1 – A Antiguidade" },
                    { "9789723603194", "", "", "9789723603194", "", 31.8f, "", "", 1, "", "História das mulheres: 2 – A Idade Média" },
                    { "9789723603347", "", "", "9789723603347", "", 31.8f, "", "", 1, "", "História das mulheres: 3 – Do Renascimento à Idade Moderna" },
                    { "9789723603385", "Luísa Ducla Soares", "https://covers.openlibrary.org/b/isbn/9789723603385-L.jpg", "9789723603385", "Português", 9.5f, "Afrontamento", "2011-01-01", 0, "", "Os ovos misteriosos" },
                    { "9789723603521", "", "", "9789723603521", "", 31.8f, "", "", 1, "", "História das mulheres: 4 – O Século XIX" },
                    { "9789723603934", "", "", "9789723603934", "", 31.8f, "", "", 1, "", "História das mulheres: 5 – O Século XX" },
                    { "9789723607581", "Gabriela Macedo", "", "9789723607581", "português", 14.13f, "Edições Afrontamento", "2005", 0, "", "Dicionário da crítica feminista" },
                    { "9789723607604", "Ana Cristina Santos", "", "9789723607604", "português", 13.12f, "Edições Afrontamento", "2005", 1, "", "A lei do desejo: Direitos humanos e minorias sexuais em Portugal" },
                    { "9789723609387", "", "", "9789723609387", "", 12.12f, "", "", 0, "", "O livro do Pedro" },
                    { "9789723610901", "", "", "9789723610901", "Português", 22f, "Afrontamento", "2011-01-01", 1, "", "Antologia da poesia grega clássica" },
                    { "9789723611472", "Ana Maria Simões de Azevedo Brandão", "", "9789723611472", "Português", 16f, "Afrontamento", "2010-01-01", 1, "", "E se tu fosses um rapaz?" },
                    { "9789723611786", "Luísa Neto Jorge", "", "9789723611786", "Português", 14f, "Modo de Ler", "2011-01-01", 0, "", "Poesia traduzida" },
                    { "9789723612455", "", "", "9789723612455", "Português", 14f, "Afrontamento", "2012-01-01", 1, "", "Três momentos da poesia europeia: De Safo e Píndaro a Ungaretti e Salinas" },
                    { "9789723613865", "Marinela Carvalho Freitas", "", "9789723613865", "Português", 19.5f, "Afrontamento", "2014-01-01", 1, "", "Emily Dickinson e Luiza Neto Jorge: Quantas faces?" },
                    { "9789723615043", "José Marmelo e Silva", "", "9789723615043", "Português", 22f, "Afrontamento", "2016-01-01", 1, "", "Sedução e outras ficções" },
                    { "9789723615050", "43 a.C.-18 d.C. Ovídio", "", "9789723615050", "Português", 12f, "Afrontamento", "2017-01-01", 0, "", "Poemas do desterro" },
                    { "9789723616651", "Paulo Freire", "", "9789723616651", "Português", 14f, "Afrontamento", "2018-01-01", 1, "", "Pedagogia do oprimido" },
                    { "9789723617788", "", "", "9789723617788", "Português", 19f, "Instituto de Literatura Comparada Margarida Losa", "2019-01-01", 1, "", "Legados e heranças: políticas (inter)sexuais hoje" },
                    { "9789723700305", "Mário Cesariny", "", "9789723700305", "português", 9.99f, "Assírio & Alvim", "2000", 1, "", "A cidade queimada" },
                    { "9789723701074", "", "", "9789723701074", "", 13.3f, "", "", 1, "", "A noite da iguana e outras histórias" },
                    { "9789723702798", "Mário Cesariny", "", "9789723702798", "português", 11.1f, "Assírio & Alvim", "1991", 1, "", "Nobilíssima visão" },
                    { "9789723703203", "", "", "9789723703203", "", 6.65f, "", "", 0, "", "Cálamo" },
                    { "9789723703726", "Mário Cesariny", "", "9789723703726", "português", 12.2f, "Assírio & Alvim", "1994", 0, "", "Titânia" },
                    { "9789723703870", "", "", "9789723703870", "", 12.2f, "", "", 0, "", "Vinte e cinco poemas à hora do almoço" },
                    { "9789723705089", "pseud. Al Berto", "", "9789723705089", "Português", 13.3f, "Assírio & Alvim", "2012-01-01", 1, "", "Lunário" },
                    { "9789723705195", "pseud. Al Berto", "", "9789723705195", "Português", 13.3f, "Assírio & Alvim", "2012-01-01", 0, "", "O anjo mudo" },
                    { "9789723707225", "", "", "9789723707225", "", 14f, "", "", 0, "", "Lágrimas e suspiros / Persona / Dependência" },
                    { "9789723708790", "", "", "9789723708790", "", 16.65f, "", "", 1, "", "Contos do mal errante" },
                    { "9789723708813", "", "", "9789723708813", "", 16.65f, "", "", 1, "", "Poesias" },
                    { "9789723709117", "", "", "9789723709117", "", 22.2f, "", "", 0, "", "Uma vida violenta" },
                    { "9789723709124", "", "", "9789723709124", "", 6.65f, "", "", 2, "", "O oficial prussiano" },
                    { "9789723709209", "", "", "9789723709209", "", 11.1f, "", "", 1, "", "Jornal do gato" },
                    { "9789723709554", "", "", "9789723709554", "", 20f, "", "", 0, "", "Cadernos" },
                    { "9789723709810", "", "", "9789723709810", "", 18.85f, "", "", 0, "", "Ensaios reunidos" },
                    { "9789723710021", "", "", "9789723710021", "", 11.1f, "", "", 1, "", "As irmãs Brontë, filhas do vento" },
                    { "9789723711769", "Armando Silva Carvalho", "https://covers.openlibrary.org/b/isbn/9789723711769-L.jpg", "9789723711769", "português", 34.99f, "Assírio & Alvim", "2007", 1, "", "O que foi passado a limpo" },
                    { "9789723711912", "Jorge de Sousa Braga", "", "9789723711912", "Português", 22.2f, "Assírio & Alvim", "2014-01-01", 1, "", "O poeta nu: Poesia reunida" },
                    { "9789723712018", "Federico García Lorca", "", "9789723712018", "Português", 15.5f, "Assírio & Alvim", "2007-01-01", 1, "", "Anjo e duende" },
                    { "9789723712933", "Mário Cesariny", "", "9789723712933", "Português", 7.75f, "Minerva", "2008-01-01", 1, "", "Manual de prestidigitação (Livro de bolso)" },
                    { "9789723713084", "Armando Silva Carvalho", "", "9789723713084", "Português", 13f, "Assírio & Alvim", "2008-01-01", 1, "", "O amante japonês" },
                    { "9789723713404", "Umberto Saba", "", "9789723713404", "Português", 23.3f, "Assírio & Alvim", "2010-01-01", 1, "", "Poesia" },
                    { "9789723713695", "Maria Velho da Costa", "", "9789723713695", "Português", 16.65f, "Assírio & Alvim", "2008-01-01", 1, "", "Myra" },
                    { "9789723713893", "Mário Cesariny", "", "9789723713893", "Português", 18.85f, "Fundação Cupertino de Miranda", "2008-01-01", 0, "", "Louvor e simplificação de Álvaro de Campos" },
                    { "9789723714043", "pseud. Al Berto", "", "9789723714043", "Português", 40f, "Assírio & Alvim", "2009-01-01", 1, "", "O medo" },
                    { "9789723714623", "Mário Cesariny", "", "9789723714623", "Português", 20f, "Assírio & Alvim ;", "2009-01-01", 0, "", "De Mário Cesariny para Artur Manuel do Cruzeiro Seixas" },
                    { "9789723714937", "Armando Silva Carvalho", "", "9789723714937", "Português", 13.3f, "Assírio & Alvim", "2010-01-01", 1, "", "Anthero, areia e água" },
                    { "9789723715712", "Oscar Wilde", "", "9789723715712", "Português", 7f, "Assírio & Alvim", "2011-01-01", 0, "", "Salomé" },
                    { "9789723716498", "Eugénio de Andrade", "", "9789723716498", "Português", 12.2f, "Assírio & Alvim", "2014-01-01", 1, "", "Primeiros poemas / As mãos e os frutos / Os amantes sem dinheiro" },
                    { "9789723716504", "pseud. Al Berto", "https://covers.openlibrary.org/b/isbn/9789723716504-L.jpg", "9789723716504", "Português", 22.2f, "Assírio & Alvim", "2012-01-01", 1, "", "Diários" },
                    { "9789723716566", "Eugénio de Andrade", "", "9789723716566", "Português", 11.1f, "Assírio & Alvim", "2013-01-01", 1, "", "As palavras interditas / Até amanhã" },
                    { "9789723716665", "Eugénio de Andrade", "", "9789723716665", "Português", 11.1f, "Assírio & Alvim", "2013-01-01", 1, "", "Coração do dia / Mar de setembro" },
                    { "9789723716672", "Eugénio de Andrade", "", "9789723716672", "Português", 11.1f, "Assírio & Alvim", "2013-01-01", 1, "", "Ostinato rigore" },
                    { "9789723716696", "António Patrício", "", "9789723716696", "Português", 13.3f, "Assírio & Alvim", "2013-01-01", 1, "", "Serão inquieto" },
                    { "9789723716894", "Maria Velho da Costa", "", "9789723716894", "Português", 19.99f, "Assírio & Alvim", "2013-01-01", 1, "", "Casas pardas" },
                    { "9789723717044", "Eugénio de Andrade", "", "9789723717044", "Português", 14.4f, "Assírio & Alvim", "2013-01-01", 1, "", "Os afluentes do silêncio" },
                    { "9789723717099", "Federico García Lorca", "", "9789723717099", "Português", 13.3f, "Assírio & Alvim", "2013-01-01", 1, "", "Poemas" },
                    { "9789723717174", "Eugénio de Andrade", "", "9789723717174", "Português", 11.1f, "Assírio & Alvim", "2013-01-01", 1, "", "Obscuro domínio" },
                    { "9789723717402", "Eugénio de Andrade", "", "9789723717402", "Português", 11.1f, "Assírio & Alvim", "2014-01-01", 1, "", "Véspera da água" },
                    { "9789723717419", "Eugénio de Andrade", "", "9789723717419", "Português", 13.3f, "Assírio & Alvim", "2014-01-01", 1, "", "Escrita da terra / Homenagens e outros epitáfios" },
                    { "9789723717655", "Ana Luísa Amaral", "", "9789723717655", "Português", 14.4f, "Assírio & Alvim", "2014-01-01", 1, "", "Escuro" },
                    { "9789723717921", "Eugénio de Andrade", "", "9789723717921", "Português", 11.1f, "Assírio & Alvim", "2014-01-01", 1, "", "Memória doutro rio" },
                    { "9789723717938", "Eugénio de Andrade", "", "9789723717938", "Português", 11.1f, "Assírio & Alvim", "2014-01-01", 1, "", "Limiar dos pássaros" },
                    { "9789723718096", "Adília Lopes", "", "9789723718096", "Português", 13.3f, "Assírio & Alvim", "2015-01-01", 0, "", "Manhã" },
                    { "9789723718133", "Eugénio de Andrade", "", "9789723718133", "Português", 11.1f, "Assírio & Alvim", "2015-01-01", 1, "", "Matéria solar" },
                    { "9789723718157", "Eugénio de Andrade", "", "9789723718157", "Português", 14.4f, "Assírio & Alvim", "2015-01-01", 1, "", "Rosto precário" },
                    { "9789723718263", "Ana Luísa Amaral", "https://covers.openlibrary.org/b/isbn/9789723718263-L.jpg", "9789723718263", "Português", 14.4f, "Assírio & Alvim", "2018-01-01", 0, "", "E todavia" },
                    { "9789723718324", "Mário Cesariny", "", "9789723718324", "Português", 13.3f, "Assírio & Alvim", "2015-01-01", 0, "", "O Virgem Negra" },
                    { "9789723718348", "Armando Silva Carvalho", "", "9789723718348", "Português", 13.3f, "Assírio & Alvim", "2015-01-01", 1, "", "A sombra do mar" },
                    { "9789723718447", "Daniel Faria", "https://covers.openlibrary.org/b/isbn/9789723718447-L.jpg", "9789723718447", "Português", 22.2f, "Porto Editora", "2015-01-01", 1, "", "Poesia" },
                    { "9789723718584", "Eugénio de Andrade", "", "9789723718584", "Português", 11.1f, "Assírio & Alvim", "2015-01-01", 1, "", "O peso da sombra" },
                    { "9789723718591", "Eugénio de Andrade", "", "9789723718591", "Português", 12.2f, "Assírio & Alvim", "2015-01-01", 1, "", "Branco no branco / Contra a obscuridade" },
                    { "9789723718836", "Ana Luísa Amaral", "https://covers.openlibrary.org/b/isbn/9789723718836-L.jpg", "9789723718836", "Português", 14.4f, "Assírio & Alvim", "2018-01-01", 1, "", "What's in a name" },
                    { "9789723718904", "Helder Moura Pereira", "", "9789723718904", "Português", 12.2f, "Assírio & Alvim", "2016-01-01", 0, "", "Golpe de teatro" },
                    { "9789723718959", "Eugénio de Andrade", "", "9789723718959", "Português", 11.1f, "Assírio & Alvim", "2016-01-01", 1, "", "Vertentes do olhar" },
                    { "9789723718973", "Eugénio de Andrade", "", "9789723718973", "Português", 11.1f, "Assírio & Alvim", "2016-01-01", 1, "", "O outro nome da terra" },
                    { "9789723719116", "", "", "9789723719116", "Português", 16.65f, "Assírio & Alvim", "2017-01-01", 1, "", "Épico de Gilgames" },
                    { "9789723719161", "Adília Lopes", "", "9789723719161", "Português", 16.65f, "Assírio & Alvim", "2016-01-01", 0, "", "Bandolim" },
                    { "9789723719451", "Eugénio de Andrade", "", "9789723719451", "Português", 44f, "Assírio & Alvim", "2017-01-01", 1, "", "Poesia" },
                    { "9789723719666", "Mário Cesariny", "", "9789723719666", "Português", 44f, "Assírio & Alvim", "2017-01-01", 1, "", "Poesia" },
                    { "9789723719710", "Mário Cláudio", "", "9789723719710", "Português", 16.65f, "Assírio & Alvim", "2017-01-01", 0, "", "Mike Tyson para principiantes: antologia poética" },
                    { "9789723719734", "Maria Gabriela Llansol", "", "9789723719734", "Português", 14.4f, "Assírio & Alvim", "2017-01-01", 0, "", "O livro das comunidades" },
                    { "9789723719932", "Mário Cesariny", "", "9789723719932", "Português", 14.4f, "Assírio & Alvim", "2017-01-01", 1, "", "Manual de prestidigitação" },
                    { "9789723719963", "Arthur Rimbaud", "", "9789723719963", "Português", 14.4f, "Assírio & Alvim", "2017-01-01", 1, "", "Iluminações / Uma cerveja no inferno" },
                    { "9789723720099", "", "", "9789723720099", "Português", 8.85f, "Assírio & Alvim", "2018-01-01", 0, "", "Poemas da Antologia grega" },
                    { "9789723720136", "Eugénio de Andrade", "", "9789723720136", "Português", 11.1f, "Assírio & Alvim", "2018-01-01", 1, "", "Rente ao dizer" },
                    { "9789723720198", "Valter Hugo Mãe", "", "9789723720198", "Português", 18.85f, "Assírio & Alvim", "2018-01-01", 1, "", "Publicação da mortalidade: poesia reunida" },
                    { "9789723720402", "Eugénio de Andrade", "", "9789723720402", "Português", 13.3f, "Assírio & Alvim", "2018-01-01", 1, "", "À sombra da memória" },
                    { "9789723720600", "Eugénio de Andrade", "", "9789723720600", "Português", 11.1f, "Assírio & Alvim", "2018-01-01", 1, "", "O sal da língua" },
                    { "9789723720624", "", "", "9789723720624", "Português", 16.65f, "Assírio & Alvim", "2018-01-01", 2, "", "Do corpo, outras habitações: Identidades e desejos outros" },
                    { "9789723720631", "Eugénio de Andrade", "", "9789723720631", "Português", 11.1f, "Assírio & Alvim", "2018-01-01", 1, "", "Ofício de paciência" },
                    { "9789723720679", "António Boto", "", "9789723720679", "Português", 44f, "Assírio & Alvim", "2018-01-01", 1, "", "Poesia" },
                    { "9789723720938", "Eugénio de Andrade", "", "9789723720938", "Português", 11.1f, "Assírio & Alvim", "2019-01-01", 1, "", "Os lugares do lume" },
                    { "9789723720952", "Eugénio de Andrade", "", "9789723720952", "Português", 11.1f, "Assírio & Alvim", "2019-01-01", 1, "", "Os sulcos da sede" },
                    { "9789723720990", "Maria Gabriela Llansol", "", "9789723720990", "Português", 16.65f, "Assírio & Alvim", "2019-01-01", 1, "", "Da sebe ao ser" },
                    { "9789723721065", "Daniel Faria", "", "9789723721065", "Português", 15.5f, "Assírio & Alvim", "2019-01-01", 1, "", "O livro do Joaquim" },
                    { "9789723721096", "Ana Luísa Amaral", "", "9789723721096", "Português", 19.99f, "Assírio & Alvim", "2019-01-01", 1, "", "Ágora" },
                    { "9789723721201", "Adília Lopes", "", "9789723721201", "Português", 14.4f, "Assírio & Alvim", "2022-01-01", 0, "", "Estar em casa" },
                    { "9789723721294", "Sofia de Melo Breyner Andresen", "", "9789723721294", "Português", 37.99f, "Assírio & Alvim", "2021-01-01", 0, "", "Prosa" },
                    { "9789723721362", "Luís Miguel Nava", "", "9789723721362", "Português", 28.85f, "Assírio & Alvim", "2020-01-01", 1, "", "Poesia" },
                    { "9789723721454", "Mário Cesariny", "", "9789723721454", "Português", 44f, "Porto Editora", "2020-01-01", 1, "", "Poemas dramáticos e pictopoemas" },
                    { "9789723721560", "Adília Lopes", "", "9789723721560", "Português", 13.3f, "Assírio & Alvim", "2020-01-01", 0, "", "Dias e dias" },
                    { "9789723721669", "ca 610-580 a.C. Safo", "", "9789723721669", "Português", 16.65f, "Assírio & Alvim", "2021-01-01", 1, "", "Poemas e fragmentos" },
                    { "9789723721706", "António Franco Alexandre", "", "9789723721706", "Português", 32.99f, "Assírio & Alvim", "2021-01-01", 1, "", "Poemas" },
                    { "9789723721744", "Daniel Faria", "", "9789723721744", "Português", 15.5f, "Assírio  & Alvim", "2021-01-01", 1, "", "Sétimo dia" },
                    { "9789723721782", "Adília Lopes", "", "9789723721782", "Português", 44f, "Assírio & Alvim", "2021-01-01", 1, "", "Dobra" },
                    { "9789723721843", "José Tolentino Mendonça", "", "9789723721843", "Português", 24.4f, "Assírio & Alvim", "2021-01-01", 0, "", "A noite abre meus olhos" },
                    { "9789723721935", "Mário Cesariny", "", "9789723721935", "Português", 16.65f, "Assírio & Alvim", "2021-01-01", 0, "", "Pena capital" },
                    { "9789723721959", "Ana Luísa Amaral", "", "9789723721959", "Português", 14.4f, "Assírio & Alvim", "2021-01-01", 1, "", "Mundo" },
                    { "9789723722253", "Ana Luísa Amaral", "", "9789723722253", "Português", 40f, "Assírio & Alvim", "2022-01-01", 1, "", "O olhar diagonal das coisas" },
                    { "9789723722314", "Eugénio de Andrade", "", "9789723722314", "Português", 37.99f, "Assírio & Alvim", "2022-01-01", 1, "", "Prosa" },
                    { "9789723722352", "Pedro Homem de Melo", "", "9789723722352", "Português", 44f, "Assírio & Alvim", "2023-01-01", 1, "", "Poemas: 1934-1961" },
                    { "9789723722475", "António Maria Lisboa", "", "9789723722475", "Português", 16.65f, "Assírio e Alvim", "2022-01-01", 2, "", "Poesia" },
                    { "9789723722550", "Maria Velho da Costa", "", "9789723722550", "Português", 18.85f, "Assírio & Alvim", "2023-01-01", 1, "", "Lúcialima" },
                    { "9789723722574", "Maria Velho da Costa", "", "9789723722574", "Português", 17.75f, "Assírio & Alvim", "2023-01-01", 1, "", "O mapa cor de rosa: Cartas de Londres" },
                    { "9789723722635", "Luísa Neto Jorge", "", "9789723722635", "Português", 29.99f, "Assírio & Alvim", "2023-01-01", 1, "", "Poesia" },
                    { "9789723722673", "Adília Lopes", "", "9789723722673", "Português", 14.4f, "Assírio & Alvim", "2022-01-01", 0, "", "Pardais" },
                    { "9789723722888", "Adília Lopes", "", "9789723722888", "Português", 14.4f, "Assírio & Alvim", "2023-01-01", 0, "", "Choupos" },
                    { "9789723723236", "Mariana Alcoforado", "", "9789723723236", "Português", 15.5f, "Assírio & Alvim", "2023-01-01", 1, "", "Cartas portuguesas" },
                    { "9789723723496", "Santo Juan de la Cruz", "", "9789723723496", "Português", 15.5f, "Assírio & Alvim", "2024-01-01", 1, "", "Poesias completas" },
                    { "9789723723595", "Mário Cesariny", "", "9789723723595", "Português", 16.65f, "Assírio & Alvim", "2023-01-01", 1, "", "Poesia de Mário Cesariny: Antologia" },
                    { "9789723723618", "Mário Cesariny", "", "9789723723618", "Português", 16.65f, "Assírio & Alvim", "2023-01-01", 3, "", "Poetas do amor, da revolta e da náusea" },
                    { "9789723723632", "Émile Nelligan", "", "9789723723632", "Português", 15.5f, "Assírio & Alvim", "2024-01-01", 2, "", "Sonhos cercados" },
                    { "9789723723793", "Maria Velho da Costa", "", "9789723723793", "Português", 16.65f, "Assírio & Alvim", "2024-01-01", 1, "", "Cravo" },
                    { "9789723729112", "", "", "9789723729112", "", 16.65f, "", "", 0, "", "O diário de Anne Frank" },
                    { "9789723829044", "", "", "9789723829044", "", 16.65f, "", "", 1, "", "Música para camaleões" },
                    { "9789723829419", "Eça de Queirós", "", "9789723829419", "Português", 9.99f, "Livros do Brasil", "2015-01-01", 1, "", "O primo Bazilio" },
                    { "9789723830064", "Jorge de Sena", "", "9789723830064", "Português", 11.1f, "Livros do Brasil", "2017-01-01", 0, "", "Sinais de fogo (Livro de bolso)" },
                    { "9789723830361", "Henry Miller", "", "9789723830361", "Português", 19.99f, "Livros do Brasil", "2018-01-01", 1, "", "Sexus" },
                    { "9789723830385", "Franz Kafka", "https://covers.openlibrary.org/b/isbn/9789723830385-L.jpg", "9789723830385", "Português", 8.85f, "Livros do Brasil", "2018-01-01", 1, "", "A metamorfose (Livro de bolso)" },
                    { "9789723830521", "Truman Capote", "", "9789723830521", "Português", 8.85f, "Livros do Brasil", "2018-01-01", 0, "", "A harpa de ervas (Livro de bolso)" },
                    { "9789723830811", "Jean-Paul Sartre", "", "9789723830811", "Português", 16.65f, "Livros do Brasil", "2018-01-01", 1, "", "A náusea" },
                    { "9789724410449", "", "", "9789724410449", "", 12.9f, "", "", 1, "", "Epigramas – Vol. I" },
                    { "9789724410708", "", "", "9789724410708", "", 11.9f, "", "", 1, "", "Epigramas – Vol. II" },
                    { "9789724411033", "", "", "9789724411033", "", 11.9f, "", "", 1, "", "Epigramas – Vol. III" },
                    { "9789724411965", "", "", "9789724411965", "", 14.9f, "Edições 70", "2004", 1, "", "Epigramas – Vol. IV" },
                    { "9789724413082", "Jean Préposiet", "", "9789724413082", "Português", 32.9f, "Edições 70", "2007-01-01", 0, "", "História do anarquismo" },
                    { "9789724413181", "Roland Barthes", "", "9789724413181", "Português", 17.9f, "Edições 70", "2006-01-01", 1, "", "Fragmentos de um discurso amoroso" },
                    { "9789724413225", "", "", "9789724413225", "", 13.9f, "", "", 1, "", "O Anticristo" },
                    { "9789724413396", "Roland Barthes", "", "9789724413396", "Português", 12.9f, "Edições 70", "2007-01-01", 1, "", "Lição" },
                    { "9789724413419", "428?-347? a.C. Platão", "", "9789724413419", "Português", 12.9f, "Edições 70", "2007-01-01", 1, "", "Laques" },
                    { "9789724413495", "Roland Barthes", "https://covers.openlibrary.org/b/isbn/9789724413495-L.jpg", "9789724413495", "Português", 14.9f, "70", "2008-01-01", 2, "", "A câmara clara" },
                    { "9789724413532", "428?-347? a.C. Platão", "https://covers.openlibrary.org/b/isbn/9789724413532-L.jpg", "9789724413532", "Português", 12.9f, "Edições 70", "2008-01-01", 1, "", "O banquete" },
                    { "9789724414461", "Álvaro Pombo", "", "9789724414461", "Português", 25.9f, "Minotauro", "2009-01-01", 2, "", "Contra-natura" },
                    { "9789724415659", "Roland Barthes", "", "9789724415659", "Português", 12.5f, "Edições 70", "2009-01-01", 1, "", "Roland Barthes por Roland Barthes (Livro usado)" },
                    { "9789724415956", "428?-347? a.C. Platão", "", "9789724415956", "Português", 14.9f, "Edições 70", "2018-01-01", 1, "", "Fedro" },
                    { "9789724415970", "Friedrich Nietzsche", "", "9789724415970", "Português", 14.9f, "Edições 70", "2010-01-01", 1, "", "Ecce Homo" },
                    { "9789724416182", "", "", "9789724416182", "", 14.9f, "", "", 1, "", "Sade, Fourier, Loiola" },
                    { "9789724416533", "ca 480-406 a.C. Eurípides", "", "9789724416533", "Português", 13.9f, "Edições 70", "2011-01-01", 1, "", "As bacantes" },
                    { "9789724417660", "Michel Foucault", "", "9789724417660", "Português", 25.3f, "Edições 70", "2013-01-01", 0, "", "Vigiar e punir: Nascimento da prisão" },
                    { "9789724420660", "Ludwig Wittgenstein", "", "9789724420660", "Português", 18.9f, "Edições 70", "2017-01-01", 1, "", "Cadernos 1914-1916" },
                    { "9789724422695", "Ludwig Wittgenstein", "", "9789724422695", "Português", 14.9f, "Edições 70", "2019-01-01", 0, "", "Cultura e valor" },
                    { "9789724423081", "", "", "9789724423081", "", 23.9f, "", "", 1, "", "O poder simbólico" },
                    { "9789724423968", "Judith Butler", "", "9789724423968", "Português", 16.9f, "Edições 70", "2021-01-01", 2, "", "A força da não-violência" },
                    { "9789724424200", "Edward W. Said", "", "9789724424200", "Português", 29.9f, "Edições 70", "2021-01-01", 0, "", "Orientalismo: Representações ocidentais do Oriente" },
                    { "9789724424231", "", "", "9789724424231", "", 24.1f, "", "", 0, "", "Comunidades imaginadas" },
                    { "9789724424651", "António Guerreiro", "", "9789724424651", "Português", 19.9f, "Edições 70", "2021-01-01", 0, "", "Zonas de baixa pressão: Crónicas escolhidas" },
                    { "9789724424842", "Georges Bataille", "", "9789724424842", "Português", 20.9f, "Edições 70", "2021-01-01", 0, "", "O erotismo" },
                    { "9789724425337", "Michel Foucault", "", "9789724425337", "Português", 26.9f, "Edições 70", "2022-01-01", 1, "", "Os anormais" },
                    { "9789724425757", "Luís Alegre", "", "9789724425757", "Português", 16.9f, "Edições 70", "2022-01-01", 0, "", "Elogio da homossexualidade" },
                    { "9789724425771", "André Gide", "", "9789724425771", "Português", 15.9f, "Edições 70", "2022-01-01", 1, "", "Córidon" },
                    { "9789724427058", "Simone de Beauvoir", "", "9789724427058", "Português", 15.9f, "Edições 70", "2023-01-01", 0, "", "Para uma moral da ambiguidade" },
                    { "9789724427089", "", "", "9789724427089", "", 22.9f, "", "", 0, "", "Cadernos do cárcere: A filosofia da práxis - Vol. 1" },
                    { "9789725566391", "", "", "9789725566391", "", 25f, "", "", 1, "", "Livros proibidos no Estado Novo" },
                    { "9789725647929", "Bruce Chawin", "", "9789725647929", "Português", 12f, "Quetzal", "2009-01-01", 1, "", "O que faço eu aqui?" },
                    { "9789725648032", "384-322 a.C. Aristóteles", "", "9789725648032", "Português", 16.6f, "Quetzal", "2012-01-01", 0, "", "Ética a Nicómaco" },
                    { "9789725648414", "", "", "9789725648414", "", 12.2f, "", "", 0, "", "Os gémeos de Blackhill" },
                    { "9789725648674", "518 a.C.-438 a.C. Píndaro", "", "9789725648674", "Português", 10f, "Quetzal", "2010-01-01", 1, "", "Odes" },
                    { "9789725649244", "Christopher Isherwood", "", "9789725649244", "Português", 14.39f, "Quetzal", "2011-01-01", 1, "", "Um homem singular" },
                    { "9789725649312", "Susan Sontag", "", "9789725649312", "Português", 12f, "Quetzal", "2011-01-01", 0, "", "Ao mesmo tempo" },
                    { "9789725649428", "1265-1321 Dante Alighieri", "", "9789725649428", "Português", 24.4f, "Quetzal", "2011-01-01", 0, "", "A Divina Comédia" },
                    { "9789725649565", "Patti Smith", "", "9789725649565", "Português", 18.8f, "Quetzal", "2011-01-01", 1, "", "Apenas miúdos" },
                    { "9789725649855", "Christopher Isherwood", "", "9789725649855", "Português", 5f, "Quetzal", "2012-01-01", 1, "", "Encontro à beira-rio" },
                    { "9789725657065", "Ângelo de Lima", "", "9789725657065", "Português", 15f, "Biblioteca Nacional de Portugal", "2023-01-01", 1, "", "Obra reunida" },
                    { "9789726080121", "Henry David Thoreau", "", "9789726080121", "Português", 14f, "Antígona", "2012-01-01", 0, "", "A desobediência civil / Defesa de John Brown" },
                    { "9789726080138", "Étienne de La Boétie", "", "9789726080138", "Português", 12f, "Antígona", "2016-01-01", 1, "", "Discurso sobre a servidão voluntária" },
                    { "9789726080329", "Evgenii Ivanovich Zamiatin", "https://covers.openlibrary.org/b/isbn/9789726080329-L.jpg", "9789726080329", "Português", 16f, "Antígona", "2014-01-01", 1, "", "Nós" },
                    { "978972608069X", "", "", "978972608069X", "", 5f, "", "", 0, "", "O tempo da SIDA" },
                    { "9789726081029", "", "", "9789726081029", "", 14.7f, "", "", 1, "", "Uma viagem sentimental" },
                    { "9789726081067", "", "", "9789726081067", "", 15f, "", "", 0, "", "Walden ou a vida nos bosques" },
                    { "9789726081128", "", "", "9789726081128", "", 5f, "", "", 0, "", "Diário para Eliza" },
                    { "9789726081241", "", "", "9789726081241", "", 7.5f, "", "", 0, "", "Os libertadores do amor" },
                    { "9789726081494", "", "", "9789726081494", "", 5f, "", "", 1, "", "O monstro e outros contos" },
                    { "9789726081555", "", "", "9789726081555", "", 5f, "", "", 1, "", "Satanás diz" },
                    { "9789726081866", "", "", "9789726081866", "", 7.5f, "", "", 0, "", "O engenho" },
                    { "9789726081890", "George Orwell", "https://covers.openlibrary.org/b/isbn/9789726081890-L.jpg", "9789726081890", "Português", 14f, "Antígona", "2007-01-01", 1, "", "1984" },
                    { "9789726081906", "Lewis Mumford", "", "9789726081906", "Português", 18f, "Antígona", "2007-01-01", 1, "", "História das utopias" },
                    { "9789726081944", "Pierre Klossowski", "", "9789726081944", "Português", 5f, "Antígona", "2008-01-01", 0, "", "A moeda viva" },
                    { "9789726082033", "", "", "9789726082033", "Português", 7.5f, "Antígona", "2009-01-01", 1, "", "Poesia cubana contemporânea: dez poetas" },
                    { "9789726082156", "Andrea Cavalletti", "", "9789726082156", "Português", 5f, "Antígona", "2010-01-01", 0, "", "Classe: Uma ideia política sob o signo de Walter Benjamin" },
                    { "9789726082224", "Guy Debord", "", "9789726082224", "Português", 14f, "Antigona", "2012-01-01", 1, "", "A sociedade do espectáculo" },
                    { "9789726082248", "Andrei Platónov", "", "9789726082248", "Português", 7.5f, "Antígona", "2012-01-01", 1, "", "Djan ou a alma" },
                    { "9789726082408", "Marquês de Condorcet", "", "9789726082408", "Português", 5f, "Antígona", "2014-01-01", 1, "", "Reflexões sobre a escravidão dos negros" },
                    { "9789726082422", "Aldous Huxley", "https://covers.openlibrary.org/b/isbn/9789726082422-L.jpg", "9789726082422", "Português", 18.5f, "Antígona", "2013-01-01", 1, "", "Admirável mundo novo" },
                    { "9789726082439", "Aldous Huxley", "", "9789726082439", "Português", 15f, "Antígona", "2013-01-01", 1, "", "As portas da percepção" },
                    { "9789726082446", "Edmundo Correia Lopes", "", "9789726082446", "Português", 5f, "Antígona", "2013-01-01", 1, "", "A escravatura: Subsídios para a usa história" },
                    { "9789726082453", "Cathy Bernheim", "", "9789726082453", "Português", 7.5f, "Antígona", "2014-01-01", 1, "", "Mary Shelley: Uma biografia da autora de Frankenstein" },
                    { "9789726082491", "Asger Jorn", "", "9789726082491", "Português", 7.5f, "Antógona", "2014-01-01", 1, "", "A génese natural: Sobre a situação singular dos machos na Humanidade" },
                    { "9789726082507", "Roswitha Scholz", "", "9789726082507", "Português", 5f, "Antígona", "2014-01-01", 2, "", "Homo Sacer e os ciganos" },
                    { "9789726082545", "Achille Mbembe", "", "9789726082545", "Português", 18f, "Antígona", "2014-01-01", 1, "", "Crítica da razão negra" },
                    { "9789726082569", "Laurence Sterne", "", "9789726082569", "Português", 35f, "Antígona", "2014-01-01", 1, "", "A vida e opiniões de Tristram Shandy" },
                    { "9789726082699", "Albertine Sarrazin", "", "9789726082699", "Português", 15f, "Antígona", "2015-01-01", 1, "", "O astrágalo" },
                    { "9789726082712", "Pier Paolo Pasolini", "", "9789726082712", "Português", 7.5f, "Antígona", "2016-01-01", 1, "", "A nebulosa" },
                    { "9789726082743", "Karin Boye", "https://covers.openlibrary.org/b/isbn/9789726082743-L.jpg", "9789726082743", "Português", 16f, "Antígona", "2016-01-01", 1, "", "Kallocaína" },
                    { "9789726082781", "Fran Ross", "", "9789726082781", "Português", 18f, "Antígona", "2016-01-01", 1, "", "Oreo" },
                    { "9789726082835", "Henry Miller", "", "9789726082835", "Português", 15f, "Antígona", "2016-01-01", 2, "", "O tempo dos assassinos: Um estudo sobre Rimbaud" },
                    { "9789726082897", "Achille Mbembe", "", "9789726082897", "Português", 16f, "Antígona", "2017-01-01", 1, "", "Políticas da inimizade" },
                    { "9789726082934", "Eduardo Galeano", "", "9789726082934", "Português", 22f, "Antígona", "2017-01-01", 1, "", "As veias aberta da América Latina" },
                    { "9789726082972", "", "", "9789726082972", "Português", 13f, "Antígona", "2017-01-01", 0, "", "Manifesto contra o trabalho" },
                    { "9789726083016", "Mary Wollstonecraft", "", "9789726083016", "Português", 18.5f, "Antígona", "2017-01-01", 2, "", "Uma vindicação dos direitos da mulher" },
                    { "9789726083023", "Simone Weil", "", "9789726083023", "Português", 14f, "Antígona", "2017-01-01", 0, "", "Reflexões sobre as causas da liberdade e da opressão social" },
                    { "9789726083078", "Maya Angelou", "", "9789726083078", "Português", 17.5f, "Antígona", "2017-01-01", 1, "", "Sei porque canta o pássaro na gaiola" },
                    { "9789726083092", "Eduardo Galeano", "", "9789726083092", "Português", 16f, "Antígona", "2017-01-01", 1, "", "Mulheres" },
                    { "9789726083108", "Edward Abbey", "", "9789726083108", "Português", 24.99f, "Antígona", "2019-01-01", 0, "", "O gangue da chave-inglesa" },
                    { "9789726083154", "", "", "9789726083154", "", 12f, "", "", 1, "", "Entretanto" },
                    { "9789726083177", "Eduardo Galeano", "", "9789726083177", "Português", 17.5f, "Antígona", "2018-01-01", 0, "", "O livro dos abraços" },
                    { "9789726083184", "Eduardo Galeano", "", "9789726083184", "Português", 18f, "Antígona", "2018-01-01", 1, "", "As palavras andantes" },
                    { "9789726083191", "Pierre Clastres", "", "9789726083191", "Português", 16f, "Antígona", "2018-01-01", 0, "", "A sociedade contra o estado" },
                    { "9789726083207", "Lewis Mumford", "", "9789726083207", "Português", 24.99f, "Antígona", "2018-01-01", 1, "", "Técnica e civilização" },
                    { "9789726083238", "Eduardo Galeano", "", "9789726083238", "Português", 20f, "Antígona", "2018-01-01", 1, "", "Espelhos: Uma história quase universal" },
                    { "9789726083245", "Karel ÏCapek", "", "9789726083245", "Português", 18f, "Antígona", "2018-01-01", 1, "", "A guerra das salamandras" },
                    { "9789726083269", "Gary Snyder", "", "9789726083269", "Português", 16.5f, "Antígona", "2018-01-01", 1, "", "A prática da natureza selvagem" },
                    { "9789726083276", "Jonathan Crary", "", "9789726083276", "Português", 15f, "Antígona", "2018-01-01", 1, "", "24/7: O capitalismo tardio e os fins do sono" },
                    { "9789726083290", "John Berger", "", "9789726083290", "Português", 16f, "Antígona", "2018-01-01", 1, "", "Modos de ver" },
                    { "9789726083320", "John Berger", "", "9789726083320", "Português", 18f, "Antígona", "2019-01-01", 0, "", "Um sétimo homem" },
                    { "9789726083344", "Johann Benjamim Erhard", "", "9789726083344", "Português", 14f, "Antígona", "2018-01-01", 1, "", "Apologia do diabo" },
                    { "9789726083351", "Choderlos de Laclos", "", "9789726083351", "Português", 14f, "Antígona", "2018-01-01", 1, "", "Da educação das mulheres" },
                    { "9789726083382", "Leonid Andreev", "", "9789726083382", "Português", 16f, "Antígona", "2018-01-01", 1, "", "As trevas e outros contos" },
                    { "9789726083399", "Eduardo Galeano", "", "9789726083399", "Português", 18f, "Antígona", "2019-01-01", 1, "", "Dias e noites de amor e de guerra" },
                    { "9789726083405", "Bohumil Hrabal", "", "9789726083405", "Português", 15f, "Antígona", "2019-01-01", 0, "", "Uma solidão demasiado ruidosa" },
                    { "9789726083467", "Leopoldo Maria Panero", "", "9789726083467", "Português", 15f, "", "2019-01-01", 1, "", "A canção do croupier do Mississípi e outros poemas" },
                    { "9789726083474", "Cláudia de Campos", "", "9789726083474", "Português", 15f, "Antígona", "2019-01-01", 1, "", "O quépi e outros contos" },
                    { "9789726083498", "", "", "9789726083498", "Português", 15f, "Antígona", "2019-01-01", 1, "", "Ministros da noite: Livro negro da expansão portuguesa" },
                    { "9789726083511", "Roland Topor", "", "9789726083511", "Português", 10f, "Antígona", "2019-01-01", 1, "", "A cozinha canibal" },
                    { "9789726083597", "Pierre Grimal", "", "9789726083597", "Português", 30f, "Antígona", "2020-01-01", 1, "", "Dicionário da mitologia grega e romana" },
                    { "9789726083610", "E. M. Forster", "", "9789726083610", "Português", 16f, "Antígona", "2020-01-01", 1, "", "A máquina pára e outros contos" },
                    { "9789726083634", "Graça Pina de Morais", "", "9789726083634", "Português", 17f, "Antígona", "2020-01-01", 0, "", "Contos completos" },
                    { "9789726083641", "Angela Y. Davis", "", "9789726083641", "Português", 16f, "Antígona", "2020-01-01", 1, "", "A liberdade é uma luta constante: Ferguson, a Palestina e as bases de um movimento" },
                    { "9789726083658", "Guy Debord", "", "9789726083658", "Português", 13f, "Antígona", "2021-01-01", 1, "", "Comentários sobre a sociedade do espectáculo" },
                    { "9789726083689", "Rosario Castellanos", "", "9789726083689", "Português", 14f, "Antígona", "2020-01-01", 1, "", "Poemas escolhidos" },
                    { "9789726083757", "Piotr Alexievitch Kropotkine", "", "9789726083757", "Português", 17f, "Antígona", "2021-01-01", 1, "", "O apoio mútuo" },
                    { "9789726083764", "Benjamin Péret", "", "9789726083764", "Português", 10f, "Antígona", "2020-01-01", 1, "", "Os tomates enlatados / Os colhões enraivecidos" },
                    { "9789726083788", "Eduardo Galeano", "", "9789726083788", "Português", 20f, "Antígona", "2020-01-01", 1, "", "Os filhos dos dias" },
                    { "9789726083795", "George Orwell", "", "9789726083795", "Português", 12f, "Antígona", "2020-01-01", 0, "", "A quinta dos animais" },
                    { "9789726083818", "Bohumil Hrabal", "", "9789726083818", "Português", 15f, "Antígona", "2022-01-01", 1, "", "Comboios rigorosamente vigiados" },
                    { "9789726083832", "Silvina Ocampo", "", "9789726083832", "Português", 16.5f, "Antígona", "2021-01-01", 1, "", "A fúria e outros contos" },
                    { "9789726083849", "Chukri Muhammad", "", "9789726083849", "Português", 15f, "Antígona", "2021-01-01", 1, "", "Pão seco" },
                    { "9789726083863", "Emma Goldman", "", "9789726083863", "Português", 35f, "Antígona", "2021-01-01", 1, "", "Viver a minha vida" },
                    { "9789726083887", "Lewis Mumford", "", "9789726083887", "Português", 18f, "Antígona", "2021-01-01", 1, "", "As transformações do Homem" },
                    { "9789726083894", "Ingeborg Bachmann", "", "9789726083894", "Português", 18f, "Antígona", "2022-01-01", 0, "", "Malina" },
                    { "9789726083900", "Achille Mbembe", "", "9789726083900", "Português", 17f, "Antígona", "2021-01-01", 1, "", "Brutalismo" },
                    { "9789726083924", "Witold Gombrowicz", "", "9789726083924", "Português", 25f, "Antígona", "2021-01-01", 1, "", "Diário: volume I (1953-1958)" },
                    { "9789726083986", "Marquês de Sade", "", "9789726083986", "Português", 17f, "Antígona", "2023-01-01", 2, "", "A filosofia na alcova" },
                    { "9789726084051", "Hannah Arendt", "", "9789726084051", "Português", 13f, "Antígona", "2021-01-01", 1, "", "Nós, refugiados / Para lá dos direitos do homem" },
                    { "9789726084082", "Felwine Sarr", "", "9789726084082", "Português", 15f, "Antígona", "2022-01-01", 1, "", "Afrotopia" },
                    { "9789726084129", "Graça Pina de Morais", "", "9789726084129", "Português", 16f, "Antígona", "2022-01-01", 0, "", "A origem" },
                    { "9789726084136", "Joseph Andras", "", "9789726084136", "Português", 14f, "Antígona", "2022-01-01", 1, "", "Assim lhes fazemos a guerra" },
                    { "9789726084150", "Silvina Ocampo", "", "9789726084150", "Português", 18f, "Antígona", "2022-01-01", 1, "", "As convidadas" },
                    { "9789726084167", "Angela Y. Davis", "", "9789726084167", "Português", 16f, "Antígona", "2022-01-01", 1, "", "As prisões estão obsoletas?" },
                    { "9789726084198", "Dany Laferrière", "", "9789726084198", "Português", 15f, "Antígona", "2022-01-01", 0, "", "Como fazer amor com um negro sem se cansar" },
                    { "9789726084228", "Witold Gombrowicz", "", "9789726084228", "Português", 20f, "Antígona", "2022-01-01", 1, "", "Diário: volume II (1959-1969)" },
                    { "9789726084235", "Dany Laferrière", "", "9789726084235", "Português", 18f, "Antígona", "2022-01-01", 1, "", "O grito dos pássaros loucos" },
                    { "9789726084242", "Cláudia Rankine", "", "9789726084242", "Português", 18f, "Antígona", "2022-01-01", 1, "", "Cidadã: uma lírica americana" },
                    { "9789726084266", "Silvina Ocampo", "", "9789726084266", "Português", 14f, "Antígona", "2023-01-01", 1, "", "A promessa" },
                    { "9789726084273", "Déborah Danowski", "", "9789726084273", "Português", 16f, "Antígona", "2023-01-01", 1, "", "Há mundo por vir?: Ensaio sobre os medos e os fins" },
                    { "9789726084297", "", "", "9789726084297", "", 25f, "", "", 1, "", "Uma autobiografia" },
                    { "9789726084303", "Grégoire Chamayou", "", "9789726084303", "Português", 16f, "Antígona", "2023-01-01", 3, "", "As caças ao Homem: História e filosofia do poder cinegético" },
                    { "9789726084327", "Frédéric Gros", "", "9789726084327", "Português", 18f, "Antígona", "2024-01-01", 1, "", "Caminhar: Uma filosofia" },
                    { "9789726084341", "", "", "9789726084341", "", 16f, "", "", 0, "", "O homem que viveu debaixo da terra" },
                    { "9789726084372", "Peter Linebaugh", "", "9789726084372", "Português", 13f, "Antígona", "2023-01-01", 2, "", "Ned Ludd e a Rainha Mab: Destruição de máquinas, Romantismo e os vários comunais de 1811-1812" },
                    { "9789726084396", "", "", "9789726084396", "", 16f, "", "", 1, "", "Terra queimada: Da era digital ao mundo pós-capitalista" },
                    { "9789726084402", "Chukri Muhammad", "", "9789726084402", "Português", 15f, "Antígona", "2023-01-01", 1, "", "Tempo de erros" },
                    { "9789726084419", "", "", "9789726084419", "", 16.5f, "", "", 0, "", "Carta aberta" },
                    { "9789726084426", "Maya Angelou", "", "9789726084426", "Português", 16f, "Antígona", "2023-01-01", 2, "", "Reúnam-se em meu nome" },
                    { "9789726084440", "", "", "9789726084440", "", 18f, "", "", 2, "", "Autodefesa: uma filosofia da violência" },
                    { "9789726084501", "Lawrence Ferlinghetti", "", "9789726084501", "Português", 17f, "Antígona", "2024-01-01", 1, "", "Uma Coney Island da mente" },
                    { "9789726084518", "Achille Mbembe", "", "9789726084518", "Português", 17.5f, "Antígona", "2024-01-01", 0, "", "A comunidade terrestre" },
                    { "9789726084549", "Marquês de Sade", "", "9789726084549", "Português", 17f, "Antígona", "2024-01-01", 3, "", "Justine" },
                    { "9789726084556", "Layla Marttínez", "", "9789726084556", "Português", 15f, "Antígona", "2024-01-01", 1, "", "Caruncho" },
                    { "9789726084594", "Monique Wittig", "", "9789726084594", "Português", 16f, "Antígona", "2024-01-01", 3, "", "As guerrilheiras" },
                    { "9789726084600", "Marlen Haushofer", "", "9789726084600", "Português", 17.5f, "Antígona", "2024-01-01", 1, "", "A parede" },
                    { "9789726084617", "Eric Hobsbawn", "", "9789726084617", "Português", 18.5f, "Antígona", "2024-01-01", 0, "", "Bandidos" },
                    { "9789726084624", "Norman G. Finkelstein", "", "9789726084624", "Português", 16f, "Antígona", "2024-01-01", 1, "", "A indústria do Holocausto: Reflexões sobre a exploração do sofrimento dos judeus" },
                    { "9789726084648", "Leão Tolstoi", "", "9789726084648", "Português", 14f, "Antígona", "2024-01-01", 1, "", "A escravatura dos nossos tempos" },
                    { "9789726952425", "", "", "9789726952425", "", 7.5f, "", "", 0, "", "Pássaros de inverno" },
                    { "9789726955254", "", "", "9789726955254", "", 12.5f, "", "", 0, "", "Rapaz de sonho" },
                    { "9789726955416", "", "", "9789726955416", "", 15f, "", "", 1, "", "A colcha de mármore" },
                    { "9789726955769", "", "", "9789726955769", "", 12.5f, "", "", 1, "", "Consolo e alegria" },
                    { "9789726995094", "", "", "9789726995094", "", 10f, "", "", 0, "", "Myra Breckinridge (Usado)" },
                    { "9789727081681", "", "", "9789727081681", "", 12.69f, "", "", 1, "", "Sexta-feira ou Os limbos do Pacífico" },
                    { "9789727082094", "", "", "9789727082094", "", 17.45f, "", "", 0, "", "História da SIDA" },
                    { "9789727082407", "", "", "9789727082407", "", 12.12f, "", "", 0, "", "História da sexualidade: 1 – A vontade de saber" },
                    { "9789727082414", "", "", "9789727082414", "", 20.19f, "", "", 1, "", "História da sexualidade: 2 – O uso dos prazeres" },
                    { "9789727082421", "", "", "9789727082421", "", 20.19f, "", "", 1, "", "História da sexualidade: 3 – O cuidado de si" },
                    { "9789727082582", "", "", "9789727082582", "", 8.08f, "", "", 1, "", "Diz-me a verdade acerca do amor" },
                    { "9789727082711", "", "", "9789727082711", "", 8.46f, "", "", 1, "", "A ponte" },
                    { "9789727082750", "", "", "9789727082750", "", 8.46f, "", "", 0, "", "Que sinos dobram por aqueles que morrem como gado?" },
                    { "9789727082810", "", "", "9789727082810", "", 16.15f, "", "", 1, "", "Auto-retrato num espelho convexo e outros poemas" },
                    { "9789727083985", "", "", "9789727083985", "", 10.09f, "", "", 0, "", "A crucificada" },
                    { "9789727084142", "", "", "9789727084142", "", 12.12f, "", "", 0, "", "A pornografia" },
                    { "9789727084807", "", "", "9789727084807", "", 14.13f, "", "", 1, "", "O rapaz raro" },
                    { "9789727084869", "", "", "9789727084869", "", 24.23f, "", "", 1, "", "Mulheres apaixonadas" },
                    { "9789727085330", "Clarice Lispector", "", "9789727085330", "Português", 14f, "Relógio d'Água", "2013-01-01", 0, "", "Uma aprendizagem ou O livro dos prazeres" },
                    { "9789727085453", "", "", "9789727085453", "", 8.06f, "", "", 0, "", "Elegias" },
                    { "9789727085484", "", "", "9789727085484", "", 10f, "", "", 0, "", "Lavoura arcaica (Usado)" },
                    { "9789727085637", "Clarice Lispector", "", "9789727085637", "Português", 16f, "Relógio d'Água", "2013-01-01", 0, "", "A paixão segundo G.H." },
                    { "9789727085965", "", "", "9789727085965", "", 10.07f, "", "", 0, "", "Mercado dos duendes" },
                    { "9789727086146", "", "", "9789727086146", "", 11.11f, "", "", 0, "", "De profundis" },
                    { "9789727086559", "Evelyn Waugh", "", "9789727086559", "Português", 20.19f, "Relógio d'Água", "2014-01-01", 1, "", "Reviver o passado em Brideshead" },
                    { "9789727086641", "", "", "9789727086641", "", 10.09f, "", "", 1, "", "Manfredo" },
                    { "9789727087198", "", "", "9789727087198", "", 18.17f, "", "", 1, "", "A importância de ser Earnest e outras peças" },
                    { "9789727087211", "", "", "9789727087211", "", 15.14f, "", "", 0, "", "O beijo da mulher aranha" },
                    { "9789727087825", "", "", "9789727087825", "", 9.08f, "", "", 1, "", "Três mulheres" },
                    { "9789727087922", "", "", "9789727087922", "", 14f, "", "", 1, "", "Mau tempo no canal" },
                    { "9789727087983", "Thomas Mann", "", "9789727087983", "Português", 10.09f, "Relógio d'Água", "2010-01-01", 1, "", "A morte em Veneza" },
                    { "9789727088256", "", "", "9789727088256", "", 14.13f, "", "", 0, "", "Jakob von Gunten: Um diário" },
                    { "9789727089642", "Malcolm Lowry", "", "9789727089642", "Português", 20.19f, "Relógio d'Água", "2007-01-01", 1, "", "Debaixo do vulcão" },
                    { "9789727089659", "Glenway Wescott", "", "9789727089659", "Português", 14.13f, "Relógio d'Água", "2007-01-01", 1, "", "O falcão peregrino" },
                    { "9789727089994", "Glenway Wescott", "", "9789727089994", "Português", 14.13f, "Relógio d'Água", "2008-01-01", 1, "", "Um apartamento em Atenas" },
                    { "9789727933013", "", "", "9789727933013", "", 13.3f, "", "", 0, "", "O menino com flores no cabelo" },
                    { "9789727951048", "", "", "9789727951048", "", 25f, "", "", 0, "", "Teatro 2: A vida de Eduardo II de Inglaterra / Um homem é um homem / Ascensão e queda da cidade de Mahagonny / A ópera de três vinténs" },
                    { "9789727953325", "Caius Valerius Catullus", "", "9789727953325", "Português", 25f, "Livros Cotovia", "2017-01-01", 0, "", "Carmina" },
                    { "9789727953448", "Frederico Lourenço", "", "9789727953448", "Português", 18f, "Livros Cotovia", "2015-01-01", 0, "", "Pode um desejo imenso" },
                    { "9789727953585", "ca 27-66 d.C. Petrónio", "", "9789727953585", "Português", 14f, "Livros Cotovia", "2016-01-01", 0, "", "Satyricon" },
                    { "9789727953783", "Hubert Fichte", "", "9789727953783", "Português", 19f, "Cotovia", "2017-01-01", 0, "", "Um amor feliz" },
                    { "9789727953806", "Emmanuel Bove", "", "9789727953806", "Português", 18f, "Cotovia", "2017-01-01", 0, "", "Os meus amigos" },
                    { "9789727953950", "70-19 a.C. Virgílio", "", "9789727953950", "Português", 13f, "Livros Cotovia", "2019-01-01", 0, "", "Bucólicas" },
                    { "9789728418469", "", "", "9789728418469", "", 15f, "", "", 1, "", "Homens: Retratos de amor, compromisso e vida" },
                    { "9789728781309", "Leo Lionni", "", "9789728781309", "", 15f, "Kalandraka", "2013-01-01", 1, "", "Frederico" },
                    { "9789728781446", "Iela Mari", "", "9789728781446", "Português", 12.5f, "Kalandraka", "2018-01-01", 1, "", "O balãozinho vermelho" },
                    { "9789728781538", "Leo Lionni", "", "9789728781538", "", 12.5f, "Kalandraka", "2012-01-01", 2, "", "Pequeno Azul e Pequeno Amarelo" },
                    { "9789728781590", "Leo Lionni", "", "9789728781590", "", 15f, "Kalandraka", "2014-01-01", 1, "", "Nadadorzinho" },
                    { "9789728781606", "Eric Carle", "", "9789728781606", "Português", 15.5f, "Kalandraka", "2010-01-01", 0, "", "A lagartinha muito comilona" },
                    { "9789728781910", "Anthony Browne", "", "9789728781910", "Português", 14f, "Klandraka", "2008-01-01", 1, "", "Pela floresta" },
                    { "9789728791902", "Carmen Laforet", "", "9789728791902", "Português", 16.99f, "Cavalo de Ferro", "2014-01-01", 1, "", "Nada" },
                    { "9789728827014", "Pitta, Eduardo.", "", "9789728827014", "português", 5f, "Angelus Novus Editora", "2003", 0, "", "Fractura: A condição homossexual na literatura portuguesa contemporânea" },
                    { "9789728827113", "", "", "9789728827113", "", 5f, "", "", 0, "", "Epistemologia do armário" },
                    { "9789728955656", "Annemarie Schwarzenbach", "", "9789728955656", "Português", 17.5f, "Tinta-da-China", "2008-01-01", 1, "", "Morte na Pérsia" },
                    { "9789728972295", "Jean Genet", "", "9789728972295", "Português", 7f, "Artistas Unidos", "2010-01-01", 0, "", "As criadas / Alta vigilância" },
                    { "9789728972455", "Jean Genet", "", "9789728972455", "Português", 10f, "Artistas Unidos", "2011-01-01", 0, "", "Os biombos" },
                    { "9789728972639", "Noël Coward", "", "9789728972639", "Português", 10f, "Artistas Unidos", "2013-01-01", 1, "", "Vórtice / Espírito alegre" },
                    { "9789728972769", "Edward Albee", "", "9789728972769", "Português", 7f, "Artistas Unidos", "2015-01-01", 0, "", "A história do jardim zoológico / A morte de Bessie Smith / Caixa de areia" },
                    { "9789728972776", "Edward Albee", "", "9789728972776", "Português", 7f, "Artistas Unidos", "2015-01-01", 0, "", "A cabra ou Quem é Sylvia? / Casamento em jogo" },
                    { "9789728972851", "Marguerite Duras", "", "9789728972851", "Português", 7f, "Artistas Unidos", "2016-01-01", 0, "", "La musica / Cinema Éden" },
                    { "9789729013201", "Rainer Werner Fassbinder", "", "9789729013201", "Português", 12f, "Cotovia", "2015-01-01", 0, "", "As lágrimas amargas de Petra von Kant" },
                    { "9789729941078", "Isabel Minhós Martins", "", "9789729941078", "Português", 11.9f, "Planeta Tangerina", "2008-01-01", 2, "", "Pê de pai" },
                    { "9789729941085", "Isabel Minhós Martins", "https://covers.openlibrary.org/b/isbn/9789729941085-L.jpg", "9789729941085", "Português", 11.9f, "Planeta Tangerina", "2007-01-01", 1, "", "Quando eu nasci" },
                    { "9789774168758", "Muhammad Abdelnabi", "", "9789774168758", "inglês", 17.32f, "", "2018", 1, "", "In the Spider's Room" },
                    { "9789871622849", "José Esteban Muñoz", "https://covers.openlibrary.org/b/isbn/9789871622849-L.jpg", "9789871622849", "", 20f, "Caja Negra", "Nov 04, 2020", 1, "", "Utopia queer: El entonces y allí de la futuridad antinormativa" },
                    { "9789873831829", "", "", "9789873831829", "", 9f, "", "", 1, "", "Tocando al extrañx interior / Dar la mano / M/e toca" },
                    { "9789878272207", "", "", "9789878272207", "", 20f, "", "", 1, "", "Faltas: Cartas a todas las personas de mi pueblo que no me violaron" },
                    { "9789892049106", "", "", "9789892049106", "Português", 15f, "Associação Cultural Janela Indiscreta", "2014-01-01", 0, "", "Cinema e cultura queer / Queer film and culture" },
                    { "9789892054643", "Ricardo Tiago Moura", "", "9789892054643", "Português", 12f, "Não (Edições)", "2015-01-01", 1, "", "1 gato para 2" },
                    { "9789892087283", "", "", "9789892087283", "Português", 10f, "Um Marido Ideal", "2018-01-01", 0, "", "Queerquivo: Arquivo LGBT português" },
                    { "9789892087290", "", "", "9789892087290", "", 15f, "", "", 0, "", "O vírus-cinema: Cinema queer e VIH/SIDA" },
                    { "9789892092614", "Maria Manuel Pedrosa", "", "9789892092614", "Português", 16.5f, "Museu da Paisagem", "2019-01-01", 2, "", "O que há neste lugar?" },
                    { "9789892324562", "Álvaro Magalhães", "", "9789892324562", "Português", 12.9f, "Asa", "2013-01-01", 0, "", "O rapaz dos sapatos prateados" },
                    { "9789892328553", "John Green", "", "9789892328553", "Português", 15.9f, "Asa II", "2014-01-01", 0, "", "Will e Will" },
                    { "9789892331959", "W. Somerset Maugham", "", "9789892331959", "Português", 20.5f, "Asa", "2016-01-01", 1, "", "Servidão humana" },
                    { "9789892346076", "Rebecca Makkai", "", "9789892346076", "Português", 18.5f, "Asa", "2019-01-01", 0, "", "Os otimistas" },
                    { "9789892351872", "E. M. Forster", "", "9789892351872", "Português", 17.9f, "ASA", "2021-01-01", 2, "", "Maurice" },
                    { "9789892352329", "Thomas Savage", "", "9789892352329", "Português", 17.5f, "ASA", "2021-01-01", 1, "", "O poder do cão" },
                    { "9789892352589", "Robert Jones Jr", "", "9789892352589", "Português", 18.5f, "ASA", "2021-01-01", 2, "", "Os profetas" },
                    { "9789892357836", "Maia Kobabe", "", "9789892357836", "Português", 19.9f, "Asa", "2023-01-01", 0, "", "Género queer (português)" },
                    { "9789893305539", "Maria Antónia Fiadeiro", "", "9789893305539", "Português", 25f, "Caixa Alta", "2020-01-01", 0, "", "Artistas, artesãs, pioneiras: Conversas singulares entre mulheres extraordinárias" },
                    { "9789893311202", "Sara Brandão", "", "9789893311202", "Português", 14.9f, "Truz Truz", "2020-01-01", 0, "", "A geração dos bancos de madeira" },
                    { "9789893317198", "Miguel De", "", "9789893317198", "Português", 30f, "Miguel de", "2021-01-01", 10, "", "conhecer um corpo" },
                    { "9789893319543", "Manuel Palaio", "", "9789893319543", "Português", 14f, "Cor de Burro Quando Foge", "2021-01-01", 1, "", "O meu coração é um senhor" },
                    { "9789893329047", "", "", "9789893329047", "", 18f, "", "", 1, "", "Mão verde II" },
                    { "9789893335260", "Rui Cerqueira Coelho", "", "9789893335260", "Português", 16.5f, "Truz Truz", "2022-01-01", 0, "", "Ferrabrás" },
                    { "9789893340868", "Sara Brandão", "", "9789893340868", "Português", 15.5f, "Truz Truz", "2022-01-01", 1, "", "CriÁrvore" },
                    { "9789893350515", "José Sérgio", "", "9789893350515", "Português", 30f, "José Sérgio", "2023-01-01", 1, "", "Presentes!: Africanos e afrodescendentes no Porto" },
                    { "9789893358726", "", "", "9789893358726", "", 16f, "", "", 1, "", "Mais alto!" },
                    { "9789893511039", "André Murraças", "", "9789893511039", "Português", 7f, "Artistas Unidos", "2023-01-01", 3, "", "Sombras andantes / O triângulo cor-de-rosa / Fronteiras" },
                    { "9789893539309", "Abdellah Taïa", "", "9789893539309", "Português", 12f, "Maldoror", "2023-01-01", 3, "", "Aquele que é digno de ser amado" },
                    { "9789895307401", "", "", "9789895307401", "Português", 10f, "União de Resistentes Antifascistas Portugueses", "2021-01-01", 0, "", "Elas estiveram nas prisões do fascismo" },
                    { "9789895309658", "Raquel Gaspar Silva", "", "9789895309658", "Português", 12f, "Caixa Alta", "2022-01-01", 0, "", "A pedra é mais bela que o pássaro" },
                    { "9789895311569", "Derek Walcott", "", "9789895311569", "Português", 22f, "Maldoror", "2022-01-01", 0, "", "Omeros" },
                    { "9789895313013", "Federico García Lorca", "", "9789895313013", "Português", 7f, "Artistas Unidos", "2021-01-01", 0, "", "Retábulo de Dom Cristóvão / Yerma" },
                    { "9789895313044", "Dimitriádis Dimitris", "", "9789895313044", "Português", 7f, "Artistas Unidos", "2022-01-01", 1, "", "Obstrução e outras peças" },
                    { "9789895313068", "Tennessee Williams", "", "9789895313068", "Português", 7f, "Artistas Unidos", "2022-01-01", 0, "", "O comboio da madrugada" },
                    { "9789895313082", "", "", "9789895313082", "Português", 10f, "Artistas Unidos", "2022-01-01", 0, "", "Prado de fundo / Fora de campo / Folle Époque / Hotel Paraíso" },
                    { "9789895313099", "André Murraças", "", "9789895313099", "Português", 7f, "Artistas Unidos", "2022-01-01", 1, "", "Cabaret Repórter X / A última noite em que dançámos juntos" },
                    { "9789895328376", "Benjamin Fondane", "", "9789895328376", "Português", 15f, "VS.", "2021-01-01", 1, "", "Ulisses" },
                    { "9789895328383", "Pierre Louÿs", "", "9789895328383", "Português", 19f, "Vs. Editor", "2022-01-01", 2, "", "As canções de Bilitis" },
                    { "9789895339808", "Ernst Jünger", "", "9789895339808", "Português", 14f, "BCF", "2021-01-01", 0, "", "O passo da floresta" },
                    { "9789895339822", "Camila Sosa Villada", "", "9789895339822", "Português", 17.5f, "BCF", "2022-01-01", 0, "", "As malditas" },
                    { "9789895339825", "", "", "9789895339825", "", 13f, "", "", 1, "", "O meu corpo, este desejo, esta lei: Reflexões sobre a política da sexualidade" },
                    { "9789895339839", "João Oliveira Duarte", "", "9789895339839", "", 12f, "BCF", "2022-01-01", 3, "", "Não sou da família: Notas sobre Pasolini" },
                    { "9789895339846", "Chantal Akerman", "", "9789895339846", "Português", 10f, "BCF", "2023-01-01", 1, "", "Uma família em Bruxelas" },
                    { "9789895339853", "Hervé Guibert", "", "9789895339853", "Português", 13.5f, "BCF - Brito e Cunha Ferreira Editores", "2023-01-01", 3, "", "A imagem fantasma" },
                    { "9789895339860", "Alice Zeniter", "", "9789895339860", "Português", 11f, "BCF", "2024-01-01", 2, "", "Eu sou uma rapariga sem história" },
                    { "9789895342938", "Salete Tavares", "", "9789895342938", "Português", 39.5f, "Tigre de Papel", "2022-01-01", 1, "", "Sintra no Jardim da Esmeralda" },
                    { "9789895349203", "Gertrude Stein", "", "9789895349203", "Português", 12f, "Não (edições)", "2021-01-01", 1, "", "Tenros botões" },
                    { "9789895349227", "", "", "9789895349227", "", 12f, "", "", 0, "", "Linha, labirinto" },
                    { "9789895349234", "", "", "9789895349234", "", 12f, "", "", 2, "", "Desiderio" },
                    { "9789895349241", "Mina Loy", "", "9789895349241", "Português", 12f, "Não (Edições)", "2022-01-01", 2, "", "Canções para Joannes" },
                    { "9789895349258", "Helder Moura Pereira", "", "9789895349258", "Português", 30f, "Não (edições)", "2022-01-01", 0, "", "Shuffle" },
                    { "9789895349265", "", "", "9789895349265", "", 12f, "", "", 0, "", "Adriano" },
                    { "9789895349272", "", "", "9789895349272", "", 14f, "", "", 2, "", "Mar vermelho na vila toda branca" },
                    { "9789895349289", "Gertrude Stein", "", "9789895349289", "Português", 12f, "Traditore", "2022-01-01", 1, "", "A barriga no ar" },
                    { "9789895349296", "Ricardo Tiago Moura", "", "9789895349296", "Português", 15f, "não (edições)", "2024-01-01", 3, "", "Comunidade / Comunicante" },
                    { "9789895353828", "Emanuel Madalena", "", "9789895353828", "Português", 15f, "Outro Modo", "2022-01-01", 14, "", "Desafiar o género: O transgénero na literatura infantil" },
                    { "9789895357802", "Ursula Le Guin", "", "9789895357802", "Português", 9f, "Dois Dias", "2022-01-01", 0, "", "A ficção como cesta: Uma teoria e outros textos" },
                    { "9789895360505", "Maryse Condé", "", "9789895360505", "Português", 16f, "Maldoror", "2022-01-01", 1, "", "Eu, Tituba, bruxa... negra de Salem" },
                    { "9789895360536", "", "", "9789895360536", "", 18f, "", "", 0, "", "90 e mais quatro poemas" },
                    { "9789895360550", "Joris Karl Huysmans", "", "9789895360550", "Português", 16f, "Maldoror", "2023-01-01", 2, "", "Ao arrepio" },
                    { "9789895361311", "Bernardo Salgado", "", "9789895361311", "Português", 8f, "Anfisbena", "2022-01-01", 0, "", "Morder o isco" },
                    { "9789895361328", "Bernardo Salgado", "", "9789895361328", "Português", 8f, "Anfisbena", "2022-01-01", 0, "", "O Homem-cão, O Fiel Marinheiro & O aniversário" },
                    { "9789895361335", "Bernardo Salgado", "", "9789895361335", "Português", 8f, "Bernardo Salgado", "2022-01-01", 0, "", "Sombra & Paisagem" },
                    { "9789895361366", "Bernardo Salgado", "", "9789895361366", "Português", 6f, "Bernardo Salgado", "2022-01-01", 0, "", "Sonetos dos males e dos vales" },
                    { "9789895361809", "Emília Nor", "", "9789895361809", "Português", 13f, "UPA", "2022-01-01", 1, "", "Sr. Caracol" },
                    { "9789895361816", "Cátia Vidinhas", "", "9789895361816", "Português", 13f, "UPA", "2022-01-01", 0, "", "Bicho de conta" },
                    { "9789895361823", "Sérgio Condeço", "", "9789895361823", "Português", 13f, "Padrões Óbvios", "2022-01-01", 0, "", "Lagarto pintado" },
                    { "9789895361830", "Cinara Saiónára", "", "9789895361830", "Português", 13f, "Padrões Óbvios", "2022-01-01", 0, "", "Visto visto" },
                    { "9789895361847", "", "", "9789895361847", "", 15f, "", "", 1, "", "Livro do outono" },
                    { "9789895361854", "Cinara Saiónára", "", "9789895361854", "Português", 14.5f, "Upa", "2023-01-01", 0, "", "Quem está?" },
                    { "9789895361861", "Isabel Peixeiro", "", "9789895361861", "Português", 14.5f, "Padrões Óbvios", "2023-01-01", 0, "", "Esconde esconde" },
                    { "9789895361878", "Joana Barata", "", "9789895361878", "Português", 15f, "UPA", "2023-01-01", 0, "", "Livro do Verão" },
                    { "9789895382002", "João Gomes de Abreu", "", "9789895382002", "Português", 18.5f, "Associação Portuguesa dos Arquitectos Paisagistas", "2022-01-01", 0, "", "Procuras uma árvore?" },
                    { "9789895382446", "Cadu Cinelli", "", "9789895382446", "Português", 12f, "Kotter", "2023-01-01", 3, "", "Percursos afetivos" },
                    { "9789895396801", "Bernardo Salgado", "", "9789895396801", "Português", 8f, "[s.n.]", "2022-01-01", 0, "", "22: I" },
                    { "9789895396818", "Bernardo Salgado", "", "9789895396818", "Português", 8f, "[s.n.]", "2022-01-01", 0, "", "22: II" },
                    { "9789895396825", "Bernardo Salgado", "", "9789895396825", "Português", 8f, "[s.n.]", "2022-01-01", 0, "", "22: III" },
                    { "9789895396849", "Bernardo Salgado", "", "9789895396849", "Português", 6f, "[s.n.]", "2023-01-01", 0, "", "23: I" },
                    { "9789895398508", "", "", "9789895398508", "", 12f, "", "", 0, "", "Sinais de Saturno" },
                    { "9789895398515", "", "", "9789895398515", "Português", 20f, "Não (Edições)", "2023-01-01", 1, "", "Florilégio" },
                    { "9789895398522", "", "", "9789895398522", "", 14f, "", "", 2, "", "O minotauro e outros versos assim" },
                    { "9789895398546", "", "", "9789895398546", "", 14f, "", "", 2, "", "O sermão de Noé dentro da arca e outros poemas" },
                    { "9789895398560", "", "", "9789895398560", "", 14f, "", "", 1, "", "Amendoeiras brancas e vermelhas" },
                    { "9789895398577", "Inger Christensen", "", "9789895398577", "Português", 13f, "Não (Edições)", "2024-01-01", 1, "", "Alfabeto" },
                    { "9789895401390", "Cecília Corujo", "", "9789895401390", "inglês", 36f, "Stolen Books", "2019", 1, "", "Don't Make Me Spell It Out" },
                    { "9789895424399", "Geoffroy de Lagasnerie", "", "9789895424399", "Português", 13f, "BCF", "2021-01-01", 1, "", "Sair da nossa impotência política" },
                    { "9789895428441", "", "", "9789895428441", "", 25f, "", "", 1, "", "Páginas inquietas: sobre documentos insubmissos" },
                    { "9789895428458", "Witold Gombrowicz", "", "9789895428458", "Português", 18f, "Dois Dias", "2020-01-01", 0, "", "Bakakai" },
                    { "9789895428489", "Rubén Sabbadini", "", "9789895428489", "Português", 12f, "Dois Dias", "2021-01-01", 2, "", "Um fêmeo / 88 coisos de um minuto / Um disfarce magnífico" },
                    { "9789895428496", "Gertrude Stein", "", "9789895428496", "Português", 15f, "Dois Dias", "2022-01-01", 0, "", "A história de todos e de cada um" },
                    { "9789895434084", "Eva Baltasar", "", "9789895434084", "Português", 15.5f, "Faktoria K", "2021-01-01", 0, "", "Permafrost" },
                    { "9789895434411", "Ricardo Henriques", "", "9789895434411", "Português", 14.5f, "Pato Lógico", "2020-01-01", 1, "", "1.º Direito" },
                    { "9789895438013", "Raquel Afonso", "", "9789895438013", "Português", 14f, "Lua Eléctrica", "2019-01-01", 0, "", "Homossexualidade e resistência no Estado Novo" },
                    { "9789895440009", "Ricardo Tiago Moura", "", "9789895440009", "Português", 15f, "Não Edições", "2020-01-01", 0, "", "Política (um resumo)" },
                    { "9789895440030", "", "", "9789895440030", "Português", 13f, "Não (Edições)", "2019-01-01", 1, "", "Al Berto: “o que vejo já não se pode cantar”" },
                    { "9789895440047", "Ricardo Marques", "", "9789895440047", "Português", 12f, "Não Edições", "2019-01-01", 1, "", "Lucidez & outras sombras" },
                    { "9789895440061", "Edwin Morgan", "", "9789895440061", "Português", 19f, "Não Edições", "2000-01-01", 3, "", "Última mensagem: 100 poemas" },
                    { "9789895440078", "José António Almeida", "", "9789895440078", "Português", 19f, "Não (edições)", "2020-01-01", 2, "", "Pouca tinta" },
                    { "9789895442973", "Luiz Pacheco", "", "9789895442973", "Português", 15f, "Maldoror", "2020-01-01", 1, "", "Cartas ao léu" },
                    { "9789895442980", "Frederick Douglass", "", "9789895442980", "Português", 15f, "Maldoror", "2020-01-01", 0, "", "Memórias de um escravo americano" },
                    { "9789895453467", "Joris Karl Huysmans", "", "9789895453467", "Português", 15f, "VS - Vasco Santos", "2020-01-01", 0, "", "À deriva" },
                    { "9789895456710", "Jean Cocteau", "", "9789895456710", "Português", 10f, "Artistas Unidos", "2020-01-01", 1, "", "Os pais terríveis / A águia de duas cabeças" },
                    { "9789895456772", "Giovanni Testori", "", "9789895456772", "Português", 7f, "Artistas Unidos", "2020-01-01", 0, "", "Conversa com a morte" },
                    { "9789895456796", "Federico García Lorca", "", "9789895456796", "Português", 7f, "Artistas Unidos", "2020-01-01", 1, "", "Mariana Pineda / A sapateira prodigiosa" },
                    { "9789895458967", "Miguel Flor", "", "9789895458967", "Inglês", 35f, "Stolen Books", "2020-01-01", 1, "", "Boys Appetite" },
                    { "9789895470839", "Ghérasim Luca", "", "9789895470839", "Português", 14f, "Não (Edições)", "2021-01-01", 2, "", "Mandado de libertação" },
                    { "9789895470860", "Duarte Nuno Drumond Braga", "", "9789895470860", "Português", 8f, "Não (Edições)", "2021-01-01", 2, "", "Os sininhos do inferno" },
                    { "9789895470884", "Anne Carson", "", "9789895470884", "Português", 15f, "Não (Edições)", "2021-01-01", 1, "", "Vidro, ironia e Deus" },
                    { "9789895470891", "José António Almeida", "", "9789895470891", "Português", 16f, "Não (Edições)", "2021-01-01", 1, "", "A vida de Horácio e outras ficções" },
                    { "9789895472260", "Laia Malo", "", "9789895472260", "Português", 15f, "Sexto Sentido", "2022-01-01", 1, "", "Uma alienígena na varanda" },
                    { "9789895472291", "Blanca Llum Vidal", "", "9789895472291", "Português", 16f, "Sexto Sentido", "2022-01-01", 0, "", "Lavrar fundo pelas nuvens" },
                    { "9789895473571", "Carolina Maria de Jesus", "", "9789895473571", "Português", 19f, "VS Editores", "2021-01-01", 2, "", "Quarto de despejo" },
                    { "9789895473816", "André Letria", "", "9789895473816", "Português", 15.9f, "Pato Lógico", "2020-01-01", 0, "", "Eu vou ser" },
                    { "9789895479252", "Paul B. Preciado", "", "9789895479252", "Português", 20f, "Bazarov", "2020-01-01", 0, "", "Um apartamento em Urano" },
                    { "9789895483105", "Emily Dickinson", "", "9789895483105", "Português", 16f, "Edições do Saguão", "2020-01-01", 0, "", "Poemas envelope" },
                    { "9789895483136", "Alberto Pimenta", "", "9789895483136", "Português", 14f, "Saguão", "2021-01-01", 0, "", "Ilhíada" },
                    { "9789895483143", "Silvina Rodrigues Lopes", "", "9789895483143", "Português", 15f, "Saguão", "2021-01-01", 0, "", "O nascer do mundo nas suas passagens" },
                    { "9789895483181", "António Aragão", "", "9789895483181", "Português", 19.5f, "Edições do Saguão", "2021-01-01", 0, "", "Obra (re)encontrada" },
                    { "9789895488216", "Rui Cidra", "", "9789895488216", "Português", 14f, "Outro Modo", "2021-01-01", 1, "", "Funaná, raça e masculinidade: Uma trajetória colonial e pós-colonial" },
                    { "9789895489503", "", "", "9789895489503", "", 16f, "", "", 0, "", "Sex as Care and Other Viral Poems" },
                    { "9789895489510", "", "", "9789895489510", "", 18f, "", "", 1, "", "O livro de Frank" },
                    { "9789895489527", "", "", "9789895489527", "", 16f, "", "", 0, "", "The Elder Femme and Other Stone Writings" },
                    { "9789895489534", "", "", "9789895489534", "", 16f, "", "", 0, "", "The Moon Is Reading Us a Book" },
                    { "9789895490943", "", "", "9789895490943", "", 7f, "", "", 1, "", "Dona Rosinha, a solteira" },
                    { "9789895491575", "Inês Pedrosa", "", "9789895491575", "Português", 17.7f, "Sibila", "2021-01-01", 0, "", "Nas tuas mãos" },
                    { "9789895495528", "Alex Hart", "", "9789895495528", "Inglês", 12f, "Feel Better Books", "2022-01-01", 3, "", "The Naughty Non-Binary" },
                    { "9789895640140", "Rachel Ingalls", "", "9789895640140", "Português", 14.99f, "Cavalo de Ferro", "2020-01-01", 0, "", "Mrs. Caliban" },
                    { "9789895640959", "Juliana Perdomo", "", "9789895640959", "Português", 12.95f, "Lilliput", "2020-01-01", 0, "", "As cores do arco-íris" },
                    { "9789895642328", "Reza Dalvand", "", "9789895642328", "Português", 13.95f, "Fábula", "2021-01-01", 2, "", "O elefante da Dona Bibi" },
                    { "9789895643349", "Sarah S. Brannen", "", "9789895643349", "Português", 13.99f, "Booksmile", "2022-01-01", 1, "", "O casamento do meu tio" },
                    { "9789895643356", "Pippa Goodhart", "", "9789895643356", "Português", 13.95f, "Fábula", "2021-01-01", 2, "", "Que confusão!" },
                    { "9789895646050", "Bernardine Evaristo", "", "9789895646050", "Português", 18.45f, "Elsinore", "2021-01-01", 1, "", "Raízes brancas" },
                    { "9789895646487", "Ali Smith", "", "9789895646487", "Português", 20.45f, "Elsinore", "2021-01-01", 1, "", "Verão" },
                    { "9789895647651", "Judith Schalansky", "", "9789895647651", "Português", 19.45f, "Elsinore", "2022-01-01", 0, "", "Inventário de algumas perdas" },
                    { "9789895648122", "", "", "9789895648122", "", 12.95f, "", "", 0, "", "À descoberta dos planetas" },
                    { "9789895648542", "Daniel Gray-Barnett", "", "9789895648542", "Português", 14.39f, "Fábula", "2022-01-01", 1, "", "Avó Z" },
                    { "9789895649280", "André Gide", "", "9789895649280", "Português", 14.99f, "Cavalo de Ferro", "2022-01-01", 2, "", "A porta estreita" },
                    { "9789895649297", "André Gide", "", "9789895649297", "Português", 14.99f, "Cavalo de Ferro", "2022-01-01", 1, "", "O imoralista" },
                    { "9789895649471", "Édouard Louis", "", "9789895649471", "Português", 14.95f, "Elsinore", "2022-01-01", 0, "", "Para acabar de vez com Eddy Bellegueule" },
                    { "9789895680054", "", "", "9789895680054", "", 12f, "", "", 1, "", "O duplo Rimbaud" },
                    { "9789895680221", "", "", "9789895680221", "", 16f, "", "", 2, "", "Ser ou não ser: três histórias – Sarrasine / Pierre Grassou / O coronel Chabert" },
                    { "9789895680283", "", "", "9789895680283", "", 14f, "", "", 0, "", "Morte de Judas seguido de O ponto de vista de Pôncio Pilatos" },
                    { "9789895680405", "", "", "9789895680405", "", 13f, "", "", 2, "", "Codine" },
                    { "9789895680412", "", "", "9789895680412", "", 15f, "", "", 2, "", "Kyra Kyralina" },
                    { "9789895680429", "", "", "9789895680429", "", 13f, "", "", 1, "", "Carmilla (edição portuguesa)" },
                    { "9789895680450", "", "", "9789895680450", "", 14f, "", "", 1, "", "Babilónia" },
                    { "9789895680559", "", "", "9789895680559", "", 16f, "", "", 1, "", "Salomé, Salomés..." },
                    { "9789895680665", "Maria Silva Prado Lessa", "", "9789895680665", "Português", 24f, "Documenta ;", "2022-01-01", 0, "", "Mário Cesariny: A obra ou a vida" },
                    { "9789895680719", "", "", "9789895680719", "", 16f, "", "", 2, "", "Jésus-la-Caille" },
                    { "9789895680818", "", "", "9789895680818", "", 13f, "", "", 1, "", "A mandrágora" },
                    { "9789895681068", "", "", "9789895681068", "", 16f, "", "", 1, "", "O concílio de amor: Uma tragédia celeste" },
                    { "9789895681099", "Maria Cabral", "", "9789895681099", "Português", 28f, "Rialto6", "2023-01-01", 6, "", "1983" },
                    { "9789895681129", "", "", "9789895681129", "", 15f, "", "", 1, "", "Carmen, seguido de Lokis" },
                    { "9789895681495", "", "", "9789895681495", "", 14f, "", "", 2, "", "Do andrógino: Teoria plástica" },
                    { "9789895681518", "Paulo Pascoal", "", "9789895681518", "Português", 16f, "Sistema Solar", "2024-01-01", 2, "", "XPR4xTX" },
                    { "9789895681532", "Pedro Penim", "", "9789895681532", "Português", 12f, "Sistema Solar", "2024-01-01", 2, "", "Pais & Filhos" },
                    { "9789895770236", "Alice Oseman", "", "9789895770236", "Português", 18.5f, "Cultura", "2023-01-01", 2, "", "Heartstopper: 5 – O nosso futuro" },
                    { "9789895770571", "Alexis Hall", "", "9789895770571", "Português", 20.5f, "Desrotina", "2024-01-01", 0, "", "Procura-se marido" },
                    { "9789895770731", "Liv Strömquist", "", "9789895770731", "Português", 18.5f, "Cultura", "2024-01-01", 1, "", "Não sinto nada" },
                    { "9789895830473", "Kristin Roskifte", "", "9789895830473", "Português", 15.95f, "Nuvem de Letras", "2024-01-01", 0, "", "Todos viajam" },
                    { "9789896030014", "", "", "9789896030014", "", 20f, "", "", 2, "", "Indisciplinar a Teoria: Estudos gays, lésbicos e queer" },
                    { "9789896229092", "Rui Oliveira Marques", "", "9789896229092", "Português", 9f, "Ideia-Fixa", "2017-01-01", 0, "", "Histórias da noite gay de Lisboa" },
                    { "9789896231194", "Shirley Jackson", "", "9789896231194", "Português", 16.99f, "Cavalo de Ferro", "2018-01-01", 0, "", "Sempre vivemos no castelo" },
                    { "9789896232412", "Magda Szabó", "", "9789896232412", "Português", 18.79f, "Cavalo de Ferro", "2017-01-01", 0, "", "A porta" },
                    { "9789896232511", "Shirley Jackson", "", "9789896232511", "Português", 16.99f, "Cavalo de Ferro", "2018-01-01", 1, "", "A maldição de Hill House" },
                    { "9789896232535", "Julio Cortázar", "", "9789896232535", "Português", 23.99f, "Cavalo de Ferro", "2018-01-01", 1, "", "Os prémios" },
                    { "9789896232696", "José Donoso", "", "9789896232696", "Português", 26.58f, "Cavalo de Ferro", "2019-01-01", 1, "", "Casa de campo" },
                    { "9789896232801", "Shirley Jackson", "", "9789896232801", "Português", 20.99f, "Cavalo de Ferro", "2019-01-01", 1, "", "A lotaria e outras histórias" },
                    { "9789896232870", "Jessica Love", "", "9789896232870", "Português", 14.95f, "Fábula", "2021-01-01", 1, "", "O Jaime no casamento" },
                    { "9789896232894", "Bernardine Evaristo", "", "9789896232894", "Português", 22.95f, "Elsinore", "2020-01-01", 0, "", "Rapariga, mulher, outra" },
                    { "9789896233105", "Julie Fogliano", "", "9789896233105", "Português", 14.95f, "Fábula", "2022-01-01", 1, "", "Se quiseres voar" },
                    { "9789896233112", "Dolores Brown", "", "9789896233112", "Português", 15.45f, "Fábula", "2022-01-01", 1, "", "O dia em que chegaste" },
                    { "9789896233891", "Adam Silvera", "", "9789896233891", "Português", 18.85f, "Topseller", "2022-01-01", 1, "", "Tudo o que restou de nós" },
                    { "9789896234621", "Bernardine Evaristo", "", "9789896234621", "Português", 21.45f, "Elsinore", "2022-01-01", 1, "", "Mr. Loverman" },
                    { "9789896235833", "Adam Silvera", "", "9789896235833", "Português", 19.95f, "Topseller", "2023-01-01", 1, "", "O primeiro a morrer no final" },
                    { "9789896236588", "Sally Nicholls", "", "9789896236588", "Português", 13.95f, "Lilliput", "2023-01-01", 1, "", "O nariz? Os pés? A barriga? Onde estão?" },
                    { "9789896237660", "Judith Schalansky", "", "9789896237660", "Português", 21.45f, "Elsinore", "2022-01-01", 1, "", "O pescoço da girafa" },
                    { "9789896237905", "Kevin Panetta", "", "9789896237905", "Português", 17.45f, "Topseller Bliss", "2023-01-01", 1, "", "Bloom: 1 – O verão em que o amor cresceu" },
                    { "9789896238391", "Kristin Roskifte", "", "9789896238391", "Português", 15.95f, "Lilliput", "2023-01-01", 0, "", "Todos contam" },
                    { "9789896238506", "Benjamin Dean", "", "9789896238506", "Português", 15.95f, "Booksmile", "2023-01-01", 0, "", "Eu, o meu pai e o fim do arco-íris" },
                    { "9789896239374", "Elliot Page", "", "9789896239374", "Português", 18.85f, "Vogais", "2023-01-01", 1, "", "Pageboy: Memórias" },
                    { "9789896410117", "L. Frank Baum", "", "9789896410117", "Português", 15.15f, "Relógio d'Água", "2008-01-01", 1, "", "O feiticeiro de Oz" },
                    { "9789896410179", "Virginia Woolf", "https://covers.openlibrary.org/b/isbn/9789896410179-L.jpg", "9789896410179", "Português", 18.17f, "Relógio d'Água", "2008-01-01", 0, "", "Rumo ao farol" },
                    { "9789896410285", "", "", "9789896410285", "", 6f, "", "", 0, "", "Sarrasine" },
                    { "9789896410322", "Kate Chopin", "", "9789896410322", "Português", 16.15f, "Relógio d'Água", "2008-01-01", 1, "", "O despertar" },
                    { "9789896410346", "Sigmund Freud", "", "9789896410346", "Português", 14.13f, "Relógio d'Água", "2009-01-01", 0, "", "Três ensaios sobre teoria da sexualidade" },
                    { "9789896410476", "Sigmund Freud", "", "9789896410476", "Português", 12.12f, "Relógio d'Água", "2009-01-01", 0, "", "Para além do princípio do prazer" },
                    { "9789896410780", "Tennessee Williams", "", "9789896410780", "Português", 15.15f, "Relógio d'Água", "2009-01-01", 1, "", "Um elétrico chamado desejo e outras peças" },
                    { "9789896411107", "", "", "9789896411107", "", 13.12f, "", "", 1, "", "Com o diabo no corpo" },
                    { "9789896411206", "Patricia Highsmith", "", "9789896411206", "Português", 15f, "Relógio d'Água", "2013-01-01", 1, "", "O talentoso Mr. Ripley" },
                    { "9789896411213", "", "", "9789896411213", "Português", 14.13f, "Relógio d'Água", "2009-01-01", 0, "", "Poemas de amor: Antologia poética latina (I a.C. - III)" },
                    { "9789896411435", "George Gordon Byron", "https://covers.openlibrary.org/b/isbn/9789896411435-L.jpg", "9789896411435", "Português", 14.13f, "Relógio d'Água", "2010-01-01", 1, "", "Poesia Romântica inglesa: Byron, Shelley, Keats" },
                    { "9789896411527", "Walt Whitman", "https://covers.openlibrary.org/b/isbn/9789896411527-L.jpg", "9789896411527", "Português", 28.27f, "Relógio d'Água", "2010-01-01", 1, "", "Folhas de erva" },
                    { "9789896411619", "Djuna Barnes", "", "9789896411619", "Português", 17.16f, "Relógio d'Água", "2010-01-01", 1, "", "O bosque da noite" },
                    { "9789896412142", "Patricia Highsmith", "", "9789896412142", "Português", 16f, "Relógio d'Água", "2014-01-01", 1, "", "O desconhecido do Norte Expresso" },
                    { "9789896412401", "Marguerite Yourcenar", "", "9789896412401", "Português", 17f, "Relógio d'Água", "2011-01-01", 1, "", "De olhos abertos" },
                    { "9789896413408", "Clarice Lispector", "https://covers.openlibrary.org/b/isbn/9789896413408-L.jpg", "9789896413408", "Português", 20f, "Relógio d'Água", "2013-01-01", 0, "", "A maçã no escuro" },
                    { "9789896413590", "Johann Wolfgang von Goethe", "https://covers.openlibrary.org/b/isbn/9789896413590-L.jpg", "9789896413590", "Português", 27f, "Relógio d'Água", "2013-01-01", 1, "", "Fausto" },
                    { "9789896413750", "F. Scott Fitzgerald", "", "9789896413750", "Português", 7.5f, "Relógio d'Água", "2016-01-01", 2, "", "O grande Gatsby" },
                    { "9789896414122", "Emily Dickinson", "", "9789896414122", "Português", 22f, "Relógio D'Água", "2014-01-01", 1, "", "Duzentos poemas" },
                    { "9789896414207", "Virginia Woolf", "", "9789896414207", "Português", 19f, "Relógio d'Água", "2014-01-01", 0, "", "Ensaios escolhidos" },
                    { "9789896414221", "Rui Nunes", "", "9789896414221", "Português", 13f, "Relógio d'Água", "2014-01-01", 0, "", "Enredos" },
                    { "9789896414399", "Marguerite Duras", "", "9789896414399", "Português", 12f, "Relógio d'Água", "2014-01-01", 0, "", "Moderato cantabile" },
                    { "9789896414405", "Marguerite Duras", "", "9789896414405", "Português", 12f, "Relógio d'Água", "2014-01-01", 0, "", "Olhos azuis cabelo preto" },
                    { "9789896414467", "Allen Ginsberg", "", "9789896414467", "Português", 12f, "Relógio d'Água", "2014-01-01", 2, "", "Uivo e outros poemas" },
                    { "9789896415211", "Tennessee Williams", "", "9789896415211", "Português", 18f, "Relógio d'Água", "2015-01-01", 1, "", "Doce pássaro da juventude e outras peças" },
                    { "9789896415266", "Virginia Woolf", "", "9789896415266", "Português", 15f, "Relógio d'Água", "2015-01-01", 0, "", "As ondas" },
                    { "9789896415419", "Marcel Proust", "", "9789896415419", "Português", 16f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: I – Do lado de Swann" },
                    { "9789896415433", "H. G. Wells", "", "9789896415433", "Português", 15f, "Relógio d'Água", "2017-01-01", 1, "", "O homem invisível" },
                    { "9789896415457", "Patricia Highsmith", "", "9789896415457", "Português", 18f, "Relógio d'Água", "2015-01-01", 0, "", "Carol ou O preço do sal" },
                    { "9789896415716", "William Shakespeare", "", "9789896415716", "Português", 14f, "Relógio d'Água", "2015-01-01", 0, "", "31 sonetos" },
                    { "9789896415983", "D. H. Lawrence", "", "9789896415983", "Português", 10f, "Relógio d'Água", "2016-01-01", 1, "", "O amante de Lady Chatterley" },
                    { "9789896416065", "Virginia Woolf", "", "9789896416065", "Português", 10f, "Relógio d'Água", "2016-01-01", 3, "", "Orlando" },
                    { "9789896416157", "Iris Murdoch", "", "9789896416157", "Português", 17f, "Relógio d'Água", "2016-01-01", 1, "", "O sino" },
                    { "9789896416201", "Marcel Proust", "", "9789896416201", "Português", 16f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: II – À sombra das raparigas em flor" },
                    { "9789896416218", "Marcel Proust", "", "9789896416218", "Português", 14f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: III – O lado de Guermantes" },
                    { "9789896416249", "Oscar Wilde", "", "9789896416249", "Português", 10f, "Relógio d'Água", "2016-01-01", 1, "", "O retrato de Dorian Gray" },
                    { "9789896416331", "Marlon James", "", "9789896416331", "Português", 24f, "Relógio d'Água", "2016-01-01", 1, "", "Breve história de sete assassinatos" },
                    { "9789896416379", "Marcel Proust", "", "9789896416379", "Português", 14f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: IV – Sodoma e Gomorra" },
                    { "9789896416386", "Patricia Highsmith", "", "9789896416386", "Português", 17f, "Relógio d'Água", "2016-01-01", 1, "", "O amigo americano" },
                    { "9789896416423", "", "", "9789896416423", "", 15f, "", "", 0, "", "Vasto mar de sargaços" },
                    { "9789896416539", "Carson MacCullers", "", "9789896416539", "Português", 17f, "Relógio d'Água", "2017-01-01", 1, "", "Frankie e o casamento" },
                    { "9789896416584", "Marcel Proust", "", "9789896416584", "Português", 14f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: V – A prisioneira" },
                    { "9789896416614", "", "", "9789896416614", "", 15f, "", "", 1, "", "Todos os caminhos estão abertos" },
                    { "9789896416638", "Marcel Proust", "", "9789896416638", "Português", 14f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: VI – A fugitiva" },
                    { "9789896416645", "Marcel Proust", "", "9789896416645", "Português", 14f, "Relógio d'Água", "2016-01-01", 1, "", "Em busca do tempo perdido: VII – O tempo reencontrado" },
                    { "9789896416690", "Carson MacCullers", "", "9789896416690", "Português", 18f, "Relógio d'Água", "2017-01-01", 1, "", "O coração é um caçador solitário" },
                    { "9789896416881", "Carson MacCullers", "", "9789896416881", "Português", 15f, "Relógio d'Água", "2017-01-01", 1, "", "A balada do café triste" },
                    { "9789896416935", "Lawrence Ferlinghetti", "", "9789896416935", "Português", 15f, "Relógio d'Água", "2016-01-01", 0, "", "A poesia como arte insurgente" },
                    { "9789896417079", "Nathaniel Hawthorne", "", "9789896417079", "Português", 10f, "Relógio d'Água", "2017-01-01", 0, "", "A letra encarnada" },
                    { "9789896417147", "1821-1881 Dostoievski", "", "9789896417147", "Português", 10f, "Relógio d'Água", "2017-01-01", 0, "", "O duplo" },
                    { "9789896417208", "Annemarie Schwarzenbach", "", "9789896417208", "Português", 15f, "Relógio d'Água", "2017-01-01", 1, "", "Inverno no Próximo Oriente" },
                    { "9789896417390", "Rui Nunes", "", "9789896417390", "Português", 15f, "Relógio d'Água", "2017-01-01", 1, "", "Baixo contínuo" },
                    { "9789896417420", "1821-1881 Dostoievski", "", "9789896417420", "Português", 10f, "Relógio d'Água", "2017-01-01", 0, "", "Memórias do subterrâneo" },
                    { "9789896417581", "Mary Shelley", "", "9789896417581", "Português", 14f, "Relógio d'Água", "2017-01-01", 1, "", "Frankenstein (RdA)" },
                    { "9789896417666", "Marianne Moore", "", "9789896417666", "Português", 17f, "Relógio D'Água", "2018-01-01", 1, "", "O pangolim e outros poemas" },
                    { "9789896417734", "Bram Stoker", "", "9789896417734", "Português", 17f, "Relógio d'Água", "2017-01-01", 1, "", "Drácula" },
                    { "9789896417758", "Virginia Woolf", "", "9789896417758", "Português", 10f, "Relógio d'Água", "2018-01-01", 1, "", "Mrs. Dalloway" },
                    { "9789896417871", "Gertrude Stein", "", "9789896417871", "Português", 16f, "Relógio d'Água", "2017-01-01", 1, "", "A autobiografia de Alice B. Toklas" },
                    { "9789896417888", "Carson MacCullers", "", "9789896417888", "Português", 14.5f, "Relógio d'Água", "2017-01-01", 1, "", "Reflexos num olho dourado" },
                    { "9789896417932", "Marguerite Duras", "", "9789896417932", "Português", 14f, "Relógio d'Água", "2017-01-01", 0, "", "O amante" },
                    { "9789896417949", "Ana Luísa Amaral", "", "9789896417949", "Português", 19f, "Relógio d'Água", "2017-01-01", 0, "", "Arder a palavra e outros incêndios" },
                    { "9789896417987", "Carson MacCullers", "", "9789896417987", "Português", 17f, "Relógio d'Água", "2017-01-01", 1, "", "Relógio sem ponteiros" },
                    { "9789896418250", "Stefan Zweig", "", "9789896418250", "Português", 16f, "Relógio d'Água", "2018-01-01", 1, "", "O medo / Confusão de sentimentos" },
                    { "9789896418403", "Annemarie Schwarzenbach", "", "9789896418403", "Português", 16f, "Relógio d'Água", "2018-01-01", 1, "", "Com esta chuva" },
                    { "9789896418427", "Arthur Rimbaud", "", "9789896418427", "Português", 34f, "Relógio d'Água", "2018-01-01", 1, "", "Obra completa" },
                    { "9789896418618", "Agustina Bessa Luís", "", "9789896418618", "Português", 18f, "Relógio d'Água", "2018-01-01", 1, "", "Ternos guerreiros" },
                    { "9789896418748", "Rui Nunes", "", "9789896418748", "Português", 17f, "Relógio d'Água", "2018-01-01", 1, "", "Suíte e fúria" },
                    { "9789896418861", "Ursula Le Guin", "", "9789896418861", "Português", 17f, "Relógio d'Água", "2018-01-01", 0, "", "A mão esquerda das trevas" },
                    { "9789896418915", "Joaquim Manuel Magalhães", "", "9789896418915", "Português", 18f, "Relógio D'Água", "2019-01-01", 1, "", "Para comigo" },
                    { "9789896418960", "Agustina Bessa Luís", "", "9789896418960", "Português", 17f, "Relógio d'Água", "2019-01-01", 1, "", "O susto" },
                    { "9789896419028", "Michel Foucault", "", "9789896419028", "Português", 24f, "Relógio d'Água", "1994-01-01", 1, "", "História da sexualidade: 4 – As confissões da carne" },
                    { "9789896419240", "Émile Zola", "", "9789896419240", "Português", 19f, "Relógio D'Água", "2015-01-01", 0, "", "Nana" },
                    { "9789896419295", "Annemarie Schwarzenbach", "", "9789896419295", "Português", 15f, "Relógio d'Água", "2019-01-01", 1, "", "Ver uma mulher" },
                    { "9789896419301", "Reinaldo Ferreira", "", "9789896419301", "Português", 17f, "Relógio d'Água", "2019-01-01", 1, "", "O táxi n.º 9297" },
                    { "9789896419684", "João Miguel Fernandes Jorge", "", "9789896419684", "Português", 17f, "Relógio D'Água", "2019-01-01", 1, "", "Antologia dos poemas" },
                    { "9789896419790", "Marlon James", "", "9789896419790", "Português", 23f, "Relógio D'Água", "2019-01-01", 1, "", "Leopardo negro, lobo vermelho" },
                    { "9789896419912", "Rui Nunes", "", "9789896419912", "Português", 15f, "Relógio d'Água", "2020-01-01", 0, "", "O anjo camponês" },
                    { "9789896419929", "Thomas Mann", "", "9789896419929", "Português", 16f, "Relógio d'Água", "2020-01-01", 1, "", "Tonio Kroger" },
                    { "9789896441449", "José Mattoso", "", "9789896441449", "Português", 19.9f, "Temas e Debates", "2011-01-01", 1, "", "História da vida privada em Portugal: I – A Idade Média" },
                    { "9789896441500", "", "", "9789896441500", "Português", 19.9f, "Temas e Debates", "2011-01-01", 1, "", "História da vida privada em Portugal: IV - Os Nossos Dias" },
                    { "9789896445683", "Amia Srinivasan", "", "9789896445683", "Português", 18.8f, "Temas e Debates", "2022-01-01", 0, "", "O direito ao sexo: Feminismo no século XXI" },
                    { "9789896530037", "Edgar Allan Poe", "https://covers.openlibrary.org/b/isbn/9789896530037-L.jpg", "9789896530037", "Português", 5.95f, "Bis", "2015-01-01", 0, "", "Histórias extraordinárias" },
                    { "9789896530198", "Mary Shelley", "https://covers.openlibrary.org/b/isbn/9789896530198-L.jpg", "9789896530198", "Português", 7.5f, "BIS", "2016-01-01", 0, "", "Frankenstein" },
                    { "9789896600709", "William Golding", "", "9789896600709", "Português", 7.5f, "Bis", "2016-01-01", 0, "", "O deus das moscas" },
                    { "9789896602512", "Rosa Lobato de Faria", "", "9789896602512", "Português", 7.5f, "Bis", "2013-01-01", 0, "", "A alma trocada" },
                    { "9789896604219", "Marguerite Yourcenar", "", "9789896604219", "Português", 10f, "Leya", "2018-01-01", 0, "", "Memórias de Adriano" },
                    { "9789896605773", "Itamar Vieira Junior", "https://covers.openlibrary.org/b/isbn/9789896605773-L.jpg", "9789896605773", "Português", 16.6f, "Leya", "2019-01-01", 0, "", "Torto arado" },
                    { "9789896608088", "Teresa Couto Pinto", "", "9789896608088", "Português", 35f, "Oficina do Livro", "2020-01-01", 0, "", "António Variações" },
                    { "9789896609276", "Maria João Lopo de Carvalho", "", "9789896609276", "Português", 24.9f, "Oficina do Livro", "2020-01-01", 0, "", "O bisavô" },
                    { "9789896617714", "Maria João Vaz", "", "9789896617714", "Português", 16.5f, "Oficina do Livro", "2023-01-01", 25, "", "Memória de uma epifania e outras histórias" },
                    { "9789896642830", "", "", "9789896642830", "", 14.35f, "", "", 0, "", "Como se fazem os bebés" },
                    { "9789896651008", "Raduan Nassar", "", "9789896651008", "Português", 13.95f, "Companhia das Letras", "2016-01-01", 1, "", "Um copo de cólera" },
                    { "9789896651244", "Raduan Nassar", "", "9789896651244", "Português", 15.45f, "Companhia das Letras", "2016-01-01", 1, "", "Lavoura arcaica" },
                    { "9789896651572", "David MacKee", "", "9789896651572", "Português", 10.45f, "Nuvem de Letras", "2017-01-01", 1, "", "O Elmer" },
                    { "9789896651602", "David MacKee", "", "9789896651602", "Português", 10.45f, "Nuvem de Letras", "2017-01-01", 1, "", "Outra vez o Elmer" },
                    { "9789896651800", "Raduan Nassar", "", "9789896651800", "Português", 14.95f, "Companhia das Letras", "2017-01-01", 1, "", "Menina a caminho" },
                    { "9789896652197", "Meredith Russo", "", "9789896652197", "Português", 16.3f, "Nuvem de Tinta", "2017-01-01", 1, "", "Se eu fosse tua" },
                    { "9789896652692", "Milton Hatoum", "", "9789896652692", "Português", 16.9f, "Companhia das Letras", "2017-01-01", 2, "", "Dois irmãos" },
                    { "9789896653248", "David MacKee", "", "9789896653248", "Português", 10.45f, "Nuvem de Letras", "2018-01-01", 0, "", "O Elmer e o Wilbur" },
                    { "9789896653286", "David MacKee", "", "9789896653286", "Português", 10.45f, "Nuvem de Letras", "2018-01-01", 0, "", "O Elmer e a Rosa" },
                    { "9789896653354", "Slawomir Mrozek", "", "9789896653354", "Português", 14.9f, "Alfaguara", "2017-01-01", 1, "", "A revolução" },
                    { "9789896653552", "Nicola Davies", "", "9789896653552", "Português", 16f, "Nuvem de Letras", "2018-01-01", 1, "", "Diversidade: A vida na Terra" },
                    { "9789896653620", "Caetano Veloso", "", "9789896653620", "Português", 21.9f, "Companhia das Letras", "2017-01-01", 1, "", "Verdade tropical" },
                    { "9789896655211", "Sidarta Ribeiro", "", "9789896655211", "Português", 19.5f, "Objectiva", "2019-01-01", 0, "", "O oráculo da noite" },
                    { "9789896655624", "James Baldwin", "", "9789896655624", "Português", 18.45f, "Alfaguara", "2019-01-01", 1, "", "Se o disseres na montanha" },
                    { "9789896655976", "Carmen Maria Machado", "", "9789896655976", "Português", 18.9f, "Alfaguara", "2018-01-01", 1, "", "O corpo dela e outras partes" },
                    { "9789896656461", "James Baldwin", "", "9789896656461", "Português", 17.45f, "Alfaguara", "2018-01-01", 0, "", "Se esta rua falasse" },
                    { "9789896657062", "David MacKee", "", "9789896657062", "Português", 10.45f, "Nuvem de Letras", "2019-01-01", 0, "", "O Elmer e a borboleta" },
                    { "9789896657086", "David MacKee", "", "9789896657086", "Português", 10.45f, "Nuvem de Letras", "2019-01-01", 0, "", "O Elmer e o arco-íris" },
                    { "9789896657611", "James Baldwin", "", "9789896657611", "Português", 17.45f, "Alfaguara", "2020-01-01", 0, "", "O quarto de Giovanni" },
                    { "9789896658137", "João Guimarães Rosa", "", "9789896658137", "Português", 23.95f, "Companhia das Letras", "2019-01-01", 1, "", "Grande Sertão: Veredas" },
                    { "9789896658373", "Jon Agee", "", "9789896658373", "Português", 14.95f, "Nuvem de Letras", "2023-01-01", 1, "", "O muro no meio do livro" },
                    { "9789896659325", "Bruno Horta", "", "9789896659325", "Português", 19.9f, "Suma de Letras", "2020-01-01", 1, "", "António Variações: Uma biografia" },
                    { "9789896661762", "Filipa Martins", "", "9789896661762", "Português", 24.9f, "Contraponto", "2023-01-01", 0, "", "O dever de deslumbrar: Biografia de Natália Correia" },
                    { "9789896661816", "Bruno Vieira Amaral", "", "9789896661816", "Português", 20.9f, "Contraponto", "2021-01-01", 0, "", "Integrado marginal: Biografia de José Cardoso Pires" },
                    { "9789896663568", "Patrícia Reis", "", "9789896663568", "", 20.9f, "Contraponto", "2024-01-01", 0, "", "A desobediente: Biografia de Maria Teresa Horta" },
                    { "9789896685515", "Lewis Carroll", "https://covers.openlibrary.org/b/isbn/9789896685515-L.jpg", "9789896685515", "Português", 10.45f, "Fábula", "2019-01-01", 1, "", "Alice no País das Maravilhas" },
                    { "9789896685614", "Daniel Defoe", "", "9789896685614", "Português", 14.95f, "Fábula", "2019-01-01", 1, "", "Robinson Crusoé" },
                    { "9789896685829", "Onjali Q. Raúf", "", "9789896685829", "Português", 14.99f, "Booksmile", "2019-01-01", 0, "", "O rapaz ao fundo da sala" },
                    { "9789896686239", "", "", "9789896686239", "", 20.99f, "", "", 1, "", "Vernon Subutex: 2" },
                    { "9789896686260", "Bret Easton Ellis", "", "9789896686260", "Português", 15.49f, "Elsinore", "2019-01-01", 1, "", "Menos que zero" },
                    { "9789896686291", "Virginia Woolf", "", "9789896686291", "Português", 16.99f, "Cavalo de Ferro", "2019-01-01", 0, "", "Orlando" },
                    { "9789896686581", "Ali Smith", "", "9789896686581", "Português", 19.45f, "Elsinore", "2019-01-01", 1, "", "Primavera" },
                    { "9789896686628", "Jeanette Winterson", "", "9789896686628", "Português", 19.99f, "Elsinore", "2019-01-01", 2, "", "FranKISSstein" },
                    { "9789896686734", "Édouard Louis", "", "9789896686734", "Português", 16.59f, "Elsinore", "2019-01-01", 0, "", "História da violência" },
                    { "9789896686857", "Jessica Love", "", "9789896686857", "Português", 14.95f, "Fábula", "2020-01-01", 1, "", "O Jaime é uma sereia" },
                    { "9789896686932", "Anna Kavan", "", "9789896686932", "Português", 15.98f, "Cavalo de Ferro", "2019-01-01", 0, "", "Gelo" },
                    { "9789896687427", "Adam Silvera", "", "9789896687427", "Português", 18.79f, "Topseller Bliss", "2022-01-01", 1, "", "E se formos nós" },
                    { "9789896687458", "Cori Doerrfeld", "", "9789896687458", "Português", 13.29f, "Boosmile", "2020-01-01", 0, "", "Marta e Gaspar" },
                    { "9789896687762", "Condessa de Ségur", "", "9789896687762", "Português", 13.25f, "Fábula", "2020-01-01", 1, "", "As meninas exemplares" },
                    { "9789896687786", "Jason Reynolds", "", "9789896687786", "Português", 14.95f, "Fábula", "2019-01-01", 0, "", "Patina" },
                    { "9789896688134", "Shirley Jackson", "", "9789896688134", "Português", 18.79f, "Cavalo de Ferro", "2020-01-01", 1, "", "O homem da forca" },
                    { "9789896688189", "Edna O'Brien", "", "9789896688189", "Português", 17.69f, "Cavalo de Ferro", "2020-01-01", 1, "", "Menina" },
                    { "9789896688684", "Édouard Louis", "", "9789896688684", "Português", 15.45f, "Elsinore", "2020-01-01", 0, "", "Quem matou o meu pai" },
                    { "9789896688899", "Jeanette Winterson", "", "9789896688899", "Português", 16.59f, "Elsinore", "2020-01-01", 0, "", "A paixão" },
                    { "9789896710002", "Jan Morris", "https://covers.openlibrary.org/b/isbn/9789896710002-L.jpg", "9789896710002", "Português", 23.9f, "Tinta-da-China", "2009-01-01", 1, "", "Veneza" },
                    { "9789896710262", "Annemarie Schwarzenbach", "", "9789896710262", "Português", 32.86f, "T.C.", "2010-01-01", 1, "", "Auto-retratos do mundo" },
                    { "9789896710774", "Cândido de Figueiredo", "", "9789896710774", "Português", 9.9f, "Tinta-da-China", "2011-01-01", 1, "", "Entre lençóis: Episódios inocentes para educação e recreio de pessoas casadoiras" },
                    { "9789896710781", "Fernando Schwalbach", "", "9789896710781", "Português", 9.9f, "Tinta-da-China", "2011-01-01", 1, "", "O vício em Lisboa" },
                    { "9789896710965", "Guerra Junqueiro", "", "9789896710965", "Português", 9.9f, "Tinta-da-China", "2011-01-01", 1, "", "Torre de Babel ou A porra do Soriano" },
                    { "9789896711016", "João Pedro George", "", "9789896711016", "Português", 24.9f, "Tinta-da-China", "2012-01-01", 1, "", "Puta que os pariu!: A biografia de Luiz Pacheco" },
                    { "9789896711078", "Alfredo Galis", "", "9789896711078", "Português", 9.9f, "Tinta-da-China", "2011-01-01", 1, "", "Aventuras galantes" },
                    { "9789896711467", "Eduardo Pita", "", "9789896711467", "Português", 16.2f, "Tinta-da-China", "2013-01-01", 0, "", "Cadernos italianos" },
                    { "9789896711825", "Jan Morris", "", "9789896711825", "Português", 23f, "Tinta-da-China", "2013-01-01", 1, "", "Hav" },
                    { "9789896712648", "Sven Lindqvist", "", "9789896712648", "Português", 17.9f, "Tinta-da-China", "2015-01-01", 1, "", "Terra nullius: Viagem aos antípodas" },
                    { "9789896713164", "Jan Morris", "https://covers.openlibrary.org/b/isbn/9789896713164-L.jpg", "9789896713164", "Português", 18.9f, "Tinta-da-China", "2016-01-01", 1, "", "Espanha" },
                    { "9789896713911", "José Afonso", "", "9789896713911", "Português", 21.9f, "Tinta-da-China", "2017-01-01", 0, "", "Às vezes são precisas rimas destas: Poesia política portuguesa e de expressão alemã (1914-2014)" },
                    { "9789896714079", "", "", "9789896714079", "Português", 22.9f, "Tinta-da-China", "2017-01-01", 1, "", "Antologia da poesia erótica brasileira" },
                    { "9789896714420", "Alberto de Lacerda", "", "9789896714420", "Português", 21.9f, "Tinta da China", "2018-01-01", 2, "", "Labareda" },
                    { "9789896714574", "Jan Morris", "", "9789896714574", "Português", 21.9f, "Tinta-da-China", "2018-01-01", 1, "", "Manhattan '45" },
                    { "9789896714659", "Fernando Luís", "", "9789896714659", "Português", 16.9f, "Tinta-da-China", "2018-01-01", 2, "", "Aprender a cantar na era do karaoke" },
                    { "9789896714994", "428?-347? a.C. Platão", "", "9789896714994", "Português", 13.9f, "Tinta-da-China", "2019-01-01", 0, "", "O banquete" },
                    { "9789896715397", "Alejandra Pizarnik", "", "9789896715397", "", 15.9f, "Tinta-da-China", "2020-01-01", 0, "", "Antologia poética" },
                    { "9789896715458", "Jan Morris", "", "9789896715458", "Português", 16.9f, "Tinta da China", "2020-01-01", 1, "", "Conundrum" },
                    { "9789896715533", "Catarina Gomes", "", "9789896715533", "Português", 17.9f, "Tinta da China", "2020-01-01", 1, "", "Coisas de loucos: O que eles deixaram no manicómio" },
                    { "9789896715670", "Nelson Ramalho", "", "9789896715670", "Português", 19.9f, "Tinta-da-China", "2020-01-01", 1, "", "“Virar travesti”" },
                    { "9789896716141", "Margarida Vale de Gato", "", "9789896716141", "Português", 14.9f, "Tinta-da-China", "2021-01-01", 1, "", "Atirar para o torto" },
                    { "9789896716165", "Jorge Gomes Miranda", "", "9789896716165", "Português", 21.9f, "Tinta da China", "2021-01-01", 1, "", "Nova identidade" },
                    { "9789896716172", "Jan Morris", "", "9789896716172", "Português", 20.9f, "Tinta da China", "2021-01-01", 1, "", "Trieste" },
                    { "9789896716295", "João Francisco Gomes", "", "9789896716295", "Português", 21.9f, "Tinta da China", "2021-01-01", 1, "", "Roma, temos um problema" },
                    { "9789896716325", "C. Rosa Costa", "", "9789896716325", "Português", 21.9f, "Tinta da China", "2021-01-01", 1, "", "História do Conselho Nacional das Mulheres Portuguesas (1914-1947)" },
                    { "9789896716332", "Anne Boyer", "", "9789896716332", "Português", 17.9f, "Tinta da China", "2021-01-01", 0, "", "As que não morrem" },
                    { "9789896716424", "Ana Rita Alves", "", "9789896716424", "Português", 17.9f, "Tinta da China", "2021-01-01", 0, "", "O estado do racismo em Portugal: Racismo antinegro e anticiganismo" },
                    { "9789896716448", "", "", "9789896716448", "Português", 12.9f, "Tinta-da-China", "2021-01-01", 0, "", "O pauzinho do matrimónio" },
                    { "9789896716554", "Mário Domingues", "https://covers.openlibrary.org/b/isbn/9789896716554-L.jpg", "9789896716554", "Português", 18.9f, "Tinta-da-China", "2022-01-01", 1, "", "A afirmação negra e a questão colonial: Textos 1919-1928" },
                    { "9789896716820", "Helga Moreira", "", "9789896716820", "Português", 21.9f, "Tinta-da-China", "2023-01-01", 1, "", "A arte de perder" },
                    { "9789896716936", "Andreia C. Faria", "", "9789896716936", "Português", 13.9f, "Tinta-da-China", "2022-01-01", 0, "", "Canina" },
                    { "9789896717292", "Duarte Scott", "", "9789896717292", "Português", 13.9f, "Tinta-da-China", "2022-01-01", 2, "", "Exposição: Poemas e prosímetros" },
                    { "9789896717308", "George S. Schuyler", "", "9789896717308", "Português", 17.9f, "Tinta-da-China", "2023-01-01", 1, "", "Negro nunca mais" },
                    { "9789896717339", "Antonio Manetti", "", "9789896717339", "Português", 12.9f, "Tinta-da-China", "2023-01-01", 2, "", "A novela do gordo entalhador" },
                    { "9789896717407", "", "", "9789896717407", "Português", 18.9f, "Tinta-da-China", "2023-01-01", 0, "", "Mulheres e resistência: “Novas cartas portuguesas” e outras lutas" },
                    { "9789896717469", "Cristina Roldão", "", "9789896717469", "Português", 18.9f, "Tinta-da-China", "2023-01-01", 1, "", "Tribuna negra: Origens do movimento negro em Portugal (1911-1933)" },
                    { "9789896717483", "Jan Morris", "", "9789896717483", "Português", 18.9f, "Tinta-da-China", "2023-01-01", 1, "", "Alegorizações" },
                    { "9789896717865", "", "", "9789896717865", "", 50f, "", "", 1, "", "Agora, agora e mais agora: Seis memórias do último milénio (7 volumes)" },
                    { "9789896718268", "Tiago Rodrigues", "", "9789896718268", "Português", 16.9f, "Tinta-da-China", "2024-01-01", 2, "", "Catarina e a beleza de matar fascistas" },
                    { "9789896718350", "", "", "9789896718350", "Português", 22.9f, "Tinta-da-China", "2024-01-01", 2, "", "Antologia do conto erótico brasileiro" },
                    { "9789896721084", "Ana Zanatti", "", "9789896721084", "Português", 13f, "Objectiva", "2011-01-01", 0, "", "Teodorico e as mães cegonhas" },
                    { "9789896760397", "Bruno Bimbi", "", "9789896760397", "Português", 17.75f, "Sextante", "2020-01-01", 1, "", "O fim do armário" },
                    { "9789896760717", "Ana Luísa Amaral", "", "9789896760717", "Português", 13.3f, "Sextante", "2014-01-01", 2, "", "Ara" },
                    { "9789896761141", "Ana Luísa Amaral", "", "9789896761141", "Português", 16.65f, "Sextante", "2014-01-01", 0, "", "Do branco ao negro" },
                    { "9789896762438", "Frédéric Martel", "", "9789896762438", "Português", 19.99f, "Sextante", "2019-01-01", 0, "", "No armário do Vaticano" },
                    { "9789896762674", "", "", "9789896762674", "", 15.5f, "", "", 1, "", "Deixa-te de mentiras" },
                    { "9789897027062", "Oscar Wilde", "", "9789897027062", "Português", 13f, "Guerra & Paz", "2022-01-01", 0, "", "A intransigente defesa da arte: Transcrição de um julgamento sórdido" },
                    { "9789897074530", "pseud. Dr. Seuss", "", "9789897074530", "Português", 13.99f, "Booksmile", "2017-01-01", 0, "", "Oh, até onde tu podes chegar!" },
                    { "9789897074585", "Judith Kerr", "", "9789897074585", "Português", 14.39f, "Booksmile", "2018-01-01", 1, "", "O tigre que veio para o chá" },
                    { "9789897074608", "Hans Christian Andersen", "", "9789897074608", "Português", 8.79f, "Fábula", "2017-01-01", 1, "", "Contos maravilhosos" },
                    { "9789897074653", "Carlo Collodi", "", "9789897074653", "Português", 13.25f, "Fábula", "2017-01-01", 0, "", "As aventuras de Pinóquio" },
                    { "9789897074837", "Margarida Fonseca Santos", "", "9789897074837", "Português", 9.99f, "Booksmile", "2017-01-01", 0, "", "Ser quem sou" },
                    { "9789897075209", "Oscar Wilde", "", "9789897075209", "Português", 9.95f, "Fábula", "2017-01-01", 0, "", "Contos escolhidos" },
                    { "9789897075216", "James Matthew Barrie", "", "9789897075216", "Português", 13.25f, "Fábula", "2017-01-01", 0, "", "Peter Pan" },
                    { "9789897075629", "Emma Waddington", "", "9789897075629", "Português", 12.69f, "Booksmile", "2018-01-01", 1, "", "Porque é que as pessoas são de cores diferentes?" },
                    { "9789897075667", "Mark Twain", "", "9789897075667", "Português", 14.95f, "Fábula", "2017-01-01", 1, "", "As aventuras de Tom Sawyer" },
                    { "9789897075674", "Thomas Meehan", "", "9789897075674", "Português", 13.95f, "Fábula", "2017-01-01", 1, "", "Annie" },
                    { "9789897076800", "Francesca Sanna", "", "9789897076800", "Português", 14.39f, "Fábula", "2018-01-01", 0, "", "A viagem" },
                    { "9789897076855", "Mark Twain", "", "9789897076855", "Português", 15.98f, "Fábula", "2019-01-01", 1, "", "As aventuras de Huckleberry Finn" },
                    { "9789897077142", "Frances Burnett", "", "9789897077142", "Português", 14.95f, "Fábula", "2018-01-01", 1, "", "O jardim secreto" },
                    { "9789897077784", "Oscar Wilde", "", "9789897077784", "Português", 8.79f, "Fábula", "2018-01-01", 0, "", "O fantasma de Canterville" },
                    { "9789897077791", "Jonathan Swift", "", "9789897077791", "Português", 17.69f, "Fábula", "2018-01-01", 1, "", "As viagens de Gulliver" },
                    { "9789897078019", "Francesca Sanna", "", "9789897078019", "Português", 14.39f, "Fábula", "2019-01-01", 0, "", "Eu e o meu medo" },
                    { "9789897078897", "Jason Reynolds", "", "9789897078897", "Português", 14.95f, "Fábula", "2019-01-01", 0, "", "Ghost" },
                    { "9789897079382", "Arthur Conan Doyle", "", "9789897079382", "Português", 14.95f, "Fábula", "2019-01-01", 1, "", "As aventuras de Sherlock Holmes" },
                    { "9789897079399", "Condessa de Ségur", "", "9789897079399", "Português", 14.95f, "Fábula", "2019-01-01", 1, "", "Os desastres de Sofia" },
                    { "9789897110436", "", "", "9789897110436", "", 16.65f, "", "", 0, "", "Vida à venda" },
                    { "9789897110528", "Henry Miller", "https://covers.openlibrary.org/b/isbn/9789897110528-L.jpg", "9789897110528", "Português", 19.99f, "Livros do Brasil", "2019-01-01", 1, "", "Plexus" },
                    { "9789897110566", "Yukio Mishima", "", "9789897110566", "Português", 9.99f, "Livros do Brasil", "2019-01-01", 1, "", "Confissões de uma máscara" },
                    { "9789897110702", "Yukio Mishima", "", "9789897110702", "Português", 15.5f, "Livros do Brasil", "2020-01-01", 0, "", "O marinheiro que perdeu as graças do mar" },
                    { "9789897110900", "Eça de Queirós", "", "9789897110900", "Português", 11.1f, "Livros do Brasil", "2020-01-01", 1, "", "O crime do padre Amaro" },
                    { "9789897110962", "Henry Miller", "", "9789897110962", "Português", 17.75f, "Livros do Brasil", "2020-01-01", 1, "", "Nexus" },
                    { "9789897110993", "Jorge de Sena", "", "9789897110993", "Português", 8.85f, "Livros do Brasil", "2020-01-01", 1, "", "O físico prodigioso (Livro de bolso)" },
                    { "9789897111099", "Yukio Mishima", "", "9789897111099", "Português", 17.75f, "Livros do Brasil", "2020-01-01", 1, "", "O templo dourado" },
                    { "9789897111983", "D. H. Lawrence", "", "9789897111983", "Português", 8.8f, "Livros do Brasil", "2023-01-01", 2, "", "O raposo" },
                    { "9789897112133", "Franz Kafka", "", "9789897112133", "Português", 22.2f, "Livros do Brasil", "2023-01-01", 1, "", "Todos os contos" },
                    { "9789897220098", "Guillermo Cabrera Infante", "", "9789897220098", "Português", 19.9f, "Quetzal", "2012-01-01", 1, "", "Três Tristes Tigres" },
                    { "9789897220142", "Bruce Chatwin", "", "9789897220142", "Português", 14.39f, "Quetzal", "2012-01-01", 1, "", "Utz" },
                    { "9789897220302", "Bruce Chatwin", "", "9789897220302", "Português", 16.6f, "Quetzal", "2012-01-01", 1, "", "Debaixo do sol" },
                    { "9789897220456", "Christopher Isherwood", "", "9789897220456", "Português", 7.5f, "Quetzal", "2012-01-01", 1, "", "Mister Norris muda de comboio" },
                    { "9789897220531", "Susan Sontag", "", "9789897220531", "Português", 15.5f, "Quetzal", "2015-01-01", 0, "", "Olhando o sofrimento dos outros" },
                    { "9789897220586", "Susan Sontag", "", "9789897220586", "Português", 16.6f, "Quetzal", "2012-01-01", 0, "", "Ensaios sobre fotografia" },
                    { "9789897220760", "William Burroughs", "", "9789897220760", "", 15.5f, "Quetzal", "2013-01-01", 0, "", "E os hipopótamos cozeram nos seus tanques" },
                    { "9789897220968", "Eduardo Pita", "", "9789897220968", "Português", 7.5f, "Quetzal", "2013-01-01", 0, "", "Um rapaz a arder" },
                    { "9789897221378", "Ali Smith", "", "9789897221378", "Português", 7.5f, "Quetzal", "2013-01-01", 0, "", "O passado é um país estrangeiro" },
                    { "9789897221477", "", "", "9789897221477", "", 18.8f, "", "", 1, "", "Cidades da noite vermelha" },
                    { "9789897221934", "", "", "9789897221934", "", 17.7f, "", "", 2, "", "O segundo sexo: I - Os factos e os mitos" },
                    { "9789897221941", "Simone de Beauvoir", "", "9789897221941", "Português", 17.7f, "Quetzal", "2015-01-01", 2, "", "O segundo sexo: II - A experiência vivida" },
                    { "9789897222658", "", "", "9789897222658", "Português", 22.2f, "Quetzal", "2019-01-01", 1, "", "366 Poemas que falam de amor" },
                    { "9789897223013", "Patti Smith", "", "9789897223013", "Português", 18.8f, "Quetzal", "2016-01-01", 0, "", "M Train" },
                    { "9789897223051", "William Burroughs", "", "9789897223051", "Português", 16.6f, "Quetzal", "2016-01-01", 0, "", "Bicha" },
                    { "9789897223129", "Andrew Solomon", "", "9789897223129", "Português", 29.9f, "Quetzal", "2017-01-01", 0, "", "Longe da árvore: Pais, filhos e a busca da identidade" },
                    { "9789897223198", "Laurent Binet", "", "9789897223198", "Português", 19.9f, "Quetzal", "2017-01-01", 1, "", "A sétima função da linguagem" },
                    { "9789897223204", "William Shakespeare", "", "9789897223204", "Português", 17.7f, "Quetzal", "2016-01-01", 1, "", "Os sonetos de Shakespeare" },
                    { "9789897223471", "", "", "9789897223471", "Português", 22.2f, "Quetzal", "2017-01-01", 1, "", "Bíblia: II – Novo Testamento (Apóstolos, Epístolas, Apocalipse)" },
                    { "9789897224027", "", "", "9789897224027", "Português", 24.4f, "Quetzal", "2017-01-01", 1, "", "Bíblia: III – Os livros proféticos" },
                    { "9789897224386", "séc. VIII a.C. Homero", "", "9789897224386", "Português", 24.4f, "Quetzal", "2018-01-01", 0, "", "Odisseia de Homero" },
                    { "9789897224492", "Camille Paglia", "", "9789897224492", "Português", 18.8f, "Quetzal", "2018-01-01", 0, "", "Mulheres livres, homens livres" },
                    { "9789897224645", "séc. VIII a.C. Homero", "", "9789897224645", "Português", 24.4f, "Quetzal", "2019-01-01", 1, "", "Ilíada de Homero" },
                    { "9789897224744", "", "", "9789897224744", "Português", 16.6f, "Quetzal", "2018-01-01", 0, "", "A Odisseia de Homero adaptada para jovens" },
                    { "9789897224751", "", "", "9789897224751", "Português", 16.6f, "Quetzal", "2014-01-01", 1, "", "A Ilíada de Homero adaptada para jovens" },
                    { "9789897224768", "750-650 a.C. Hesíodo", "", "9789897224768", "Português", 19.9f, "Quetzal", "2006-01-01", 0, "", "Poesia grega" },
                    { "9789897224799", "Frederico Lourenço", "", "9789897224799", "Português", 18.8f, "Quetzal", "2022-01-01", 0, "", "Pode um desejo imenso" },
                    { "9789897225437", "Susan Sontag", "", "9789897225437", "Português", 18.8f, "Quetzal", "2019-01-01", 0, "", "Histórias" },
                    { "9789897225574", "Andrew  Sean Greer", "", "9789897225574", "Português", 18.8f, "Quetzal", "2009-01-01", 1, "", "Less" },
                    { "9789897225598", "António Cândido Franco", "", "9789897225598", "Português", 22.2f, "Quetzal", "2019-01-01", 0, "", "O triângulo mágico: Uma biografia de Mário Cesariny" },
                    { "9789897225628", "Federico García Lorca", "", "9789897225628", "Português", 14.39f, "Quetzal", "2019-01-01", 1, "", "Romanceiro cigano, seguido de Pranto por Ignacio Sánchez Mejías" },
                    { "9789897225796", "Bruce Chatwin", "", "9789897225796", "Português", 15.5f, "Quetzal", "2019-01-01", 0, "", "Canto nómada" },
                    { "9789897225802", "Susan Sontag", "", "9789897225802", "Português", 18.8f, "Quetzal", "2020-01-01", 0, "", "O amante do vulcão" },
                    { "9789897226328", "Lawrence Ferlinghetti", "", "9789897226328", "Português", 16.6f, "Quetzal", "2019-01-01", 1, "", "Rapazinho" },
                    { "9789897226380", "Patti Smith", "", "9789897226380", "Português", 17.7f, "Quetzal", "2020-01-01", 0, "", "O ano do macaco" },
                    { "9789897226564", "Bruce Chatwin", "", "9789897226564", "Português", 14.39f, "Quetzal", "2020-01-01", 1, "", "Na Patagónia" },
                    { "9789897226892", "Susan Sontag", "", "9789897226892", "Português", 19.9f, "Quetzal", "2022-01-01", 1, "", "Contra a interpretação e outros ensaios" },
                    { "9789897227172", "Simone de Beauvoir", "", "9789897227172", "Português", 16.6f, "Quetzal", "2021-01-01", 0, "", "As inseparáveis" },
                    { "9789897227233", "Susan Sontag", "", "9789897227233", "Português", 17.7f, "Quetzal", "2022-01-01", 0, "", "Renascer: Diários e apontamentos 1947-1963" },
                    { "9789897227462", "70-19 a.C. Virgílio", "", "9789897227462", "Português", 19.9f, "Quetzal", "2021-01-01", 1, "", "Bucólicas (Frederico Lourenço)" },
                    { "9789897227981", "António Cândido Franco", "", "9789897227981", "Português", 22.2f, "Quetzal", "2022-01-01", 0, "", "O firmamento é negro e não azul: A vida de Luiz Pacheco" },
                    { "9789897228124", "Bruce Chatwin", "", "9789897228124", "Português", 14.39f, "Quetzal", "2022-01-01", 0, "", "Anatomia da errância" },
                    { "9789897228322", "Maryse Condé", "", "9789897228322", "Português", 18.8f, "Quetzal", "2023-01-01", 1, "", "À espera da subida das águas" },
                    { "9789897228339", "Marcial Gala", "", "9789897228339", "Português", 17.7f, "Quetzal", "2023-01-01", 1, "", "Chamem-me Cassandra" },
                    { "9789897228902", "Susan Sontag", "", "9789897228902", "Português", 16.6f, "Quetzal", "2023-01-01", 5, "", "A doença como metáfora / A SIDA e as suas metáforas" },
                    { "9789897229114", "", "", "9789897229114", "", 19.9f, "", "", 0, "", "Memórias de uma menina bem-comportada" },
                    { "9789897229169", "65-8 a.C. Horácio", "", "9789897229169", "Latim", 24.9f, "Quetzal", "2023-01-01", 0, "", "Poesia completa" },
                    { "9789897229343", "Susan Sontag", "", "9789897229343", "Português", 17.7f, "Quetzal", "2024-01-01", 0, "", "Sobre as mulheres" },
                    { "9789897229473", "Andrew  Sean Greer", "", "9789897229473", "Português", 18.8f, "Quetzal", "2024-01-01", 1, "", "Less perdeu-se" },
                    { "9789897244360", "André Aciman", "", "9789897244360", "Português", 16f, "Clube do Autor", "2018-01-01", 3, "", "Chama-me pelo teu nome" },
                    { "9789897245213", "André Aciman", "", "9789897245213", "Português", 17f, "Clube do Autor", "2020-01-01", 1, "", "Encontra-me" },
                    { "9789897400643", "Clara Não", "", "9789897400643", "Português", 13.3f, "Ideias de Ler", "2019-01-01", 0, "", "Miga, esquece lá isso!" },
                    { "9789897490002", "pseud. Janosch", "", "9789897490002", "Português", 15f, "Kalandraka", "2013-01-01", 0, "", "Vamos encontrar um tesouro" },
                    { "9789897490071", "Tomi Ungerer", "", "9789897490071", "Português", 14f, "Kalandraka", "2014-01-01", 2, "", "Adelaide" },
                    { "9789897490408", "pseud. Janosch", "", "9789897490408", "Português", 15f, "Kalandraka", "2015-01-01", 1, "", "Eu ponho-te bom, disse o urso" },
                    { "9789897490569", "Justin Richardson", "", "9789897490569", "Português", 14f, "Kalandraka", "2016-01-01", 1, "", "Três com Tango" },
                    { "9789897490637", "Tomi Ungerer", "", "9789897490637", "Português", 14f, "Kalandraka", "2016-01-01", 1, "", "Emílio" },
                    { "9789897490668", "Eric Carle", "", "9789897490668", "Português", 12.5f, "Kalandraka", "2016-01-01", 0, "", "O senhor cavalo-marinho" },
                    { "9789897490774", "Eric Carle", "", "9789897490774", "Português", 11.5f, "Kalandraka", "2017-01-01", 1, "", "Da cabeça até aos pés" },
                    { "9789897490781", "Eric Carle", "", "9789897490781", "Português", 11.5f, "Kalandraka", "2017-01-01", 0, "", "Queres brincar comigo?" },
                    { "9789897490828", "Maurice Sendak", "", "9789897490828", "Português", 9f, "Kalandraka", "2017-01-01", 0, "", "João e mais oito: Um livro para contar" },
                    { "9789897490897", "Maurice Sendak", "", "9789897490897", "Português", 9f, "Kalandraka", "2018-01-01", 0, "", "Duarte" },
                    { "9789897490941", "Rocío Alejandro", "", "9789897490941", "Português", 15f, "Kalandraka", "2017-01-01", 0, "", "A horta do Simão" },
                    { "9789897490996", "Eric Carle", "", "9789897490996", "Português", 11.5f, "Kalandraka", "2018-01-01", 0, "", "10 patinhos de borracha" },
                    { "9789897491122", "David MacKee", "", "9789897491122", "Português", 13.5f, "Kalandraka", "2019-01-01", 1, "", "Agora não, Tiago" },
                    { "9789897491153", "", "", "9789897491153", "", 15f, "", "", 1, "", "Cornelius" },
                    { "9789897491177", "Maurice Sendak", "", "9789897491177", "Português", 17f, "Kalandraka", "2019-01-01", 1, "", "Estamos todos na sarjeta com João e Rui" },
                    { "9789897491238", "Tomie DePaola", "", "9789897491238", "Português", 15f, "Kalandraka", "2020-01-01", 1, "", "Oliver Button é uma menina" },
                    { "9789897491337", "Eric Carle", "", "9789897491337", "Português", 11.5f, "Kalandraka", "2021-01-01", 0, "", "A mensagem secreta de aniversário" },
                    { "9789897491382", "Eric Carle", "", "9789897491382", "Português", 11.5f, "Kalandraka", "2021-01-01", 0, "", "O artista que pintou um cavalo azul" },
                    { "9789897491504", "Josse Goffin", "", "9789897491504", "Português", 15f, "Kalandraka", "2021-01-01", 1, "", "Oh!" },
                    { "9789897491573", "Leo Lionni", "", "9789897491573", "Português", 13f, "Kalandraka", "2022-01-01", 2, "", "Uma cor apenas sua" },
                    { "9789897491658", "Eric Carle", "", "9789897491658", "Português", 12.5f, "Kalandraka", "2023-01-01", 0, "", "O pirilampo muito só" },
                    { "9789897491672", "pseud. Janosch", "", "9789897491672", "Português", 15f, "Kalandraka", "2023-01-01", 2, "", "O tigre e o urso no trânsito da cidade" },
                    { "9789897491689", "Sesyle Joslin", "", "9789897491689", "Português", 16f, "Kalandraka", "2023-01-01", 2, "", "A pequena família" },
                    { "9789897491801", "Leo Lionni", "", "9789897491801", "Português", 16f, "Kalandraka", "2024-01-01", 1, "", "Um peixe é um peixe" },
                    { "9789897491825", "pseud. Janosch", "", "9789897491825", "Português", 15f, "Kalandraka", "2024-01-01", 1, "", "O tigre e a festa de anos gigante" },
                    { "9789897550126", "Frank Wedekind", "", "9789897550126", "Português", 8.48f, "Húmus", "2013-01-01", 2, "", "O despertar da primavera" },
                    { "9789897550447", "William Shakespeare", "", "9789897550447", "Português", 8.48f, "Húmus", "2014-01-01", 2, "", "Como queiram" },
                    { "9789897550980", "Micael de Oliveira", "", "9789897550980", "Português", 10.6f, "Húmus", "2014-01-01", 1, "", "Cassandra" },
                    { "9789897553264", "", "", "9789897553264", "Português", 15f, "Centro de Estudos Humanísticos da Universidade do Minho ;", "2017-01-01", 1, "", "Estudos comparatistas e cosmopolitismo: Pós-colonialidade, tradução, arte e género" },
                    { "9789897553462", "Witold Gombrowicz", "", "9789897553462", "Português", 8.5f, "Húmus", "2018-01-01", 1, "", "Ivone, Princesa do Borgonha" },
                    { "9789897553523", "Frank Wedekind", "https://covers.openlibrary.org/b/isbn/9789897553523-L.jpg", "9789897553523", "Português", 13f, "Húmus", "2018-01-01", 3, "", "Lulu" },
                    { "9789897553714", "Walt Whitman", "", "9789897553714", "Português", 10.6f, "Húmus", "2018-01-01", 2, "", "Prefácios a Folhas de erva" },
                    { "9789897553943", "Alfred Jarry", "", "9789897553943", "Português", 14f, "Húmus", "2019-01-01", 1, "", "Ubu" },
                    { "9789897553974", "Martin Crimp", "", "9789897553974", "Português", 10f, "Húmus", "2019-01-01", 1, "", "O resto já devem conhecer do cinema" },
                    { "9789897554209", "Georg Büchner", "", "9789897554209", "Português", 11f, "Húmus", "2019-01-01", 1, "", "A morte de Danton" },
                    { "9789897555466", "Jean Genet", "", "9789897555466", "Português", 12f, "Húmus", "2020-01-01", 1, "", "O balcão" },
                    { "9789897555589", "Mário de Andrade", "", "9789897555589", "Português", 4.44f, "Húmus", "2020-01-01", 0, "", "Vestida de preto e outras histórias" },
                    { "9789897555596", "Charlotte Perkins Gilman", "", "9789897555596", "Português", 4.44f, "Húmus", "2020-01-01", 0, "", "O papel de parede amarelo" },
                    { "9789897555725", "Anton Tchekhoff", "", "9789897555725", "Português", 10f, "Húmus", "2021-01-01", 0, "", "As três irmãs" },
                    { "9789897556272", "", "", "9789897556272", "", 4.44f, "", "", 0, "", "Princípio: Novelas originais" },
                    { "9789897556418", "Paula Gomes Ribeiro", "", "9789897556418", "Português", 13.25f, "Húmus ;", "2021-01-01", 0, "", "Música Género Sexualidades: Musical Trouble... After Butler" },
                    { "9789897556487", "", "", "9789897556487", "", 4.44f, "", "", 0, "", "Vida e morte de J. M. Gonzaga de Sá" },
                    { "9789897556586", "Júlio Dinis", "", "9789897556586", "Português", 4.44f, "Húmus", "2021-01-01", 0, "", "Cartas a Cecília e outra correspondência" },
                    { "9789897556968", "", "", "9789897556968", "", 4.44f, "", "", 0, "", "Ah, um soneto: 100 sonetos em língua portuguesa" },
                    { "9789897557378", "Carmen Dolores", "", "9789897557378", "Português", 4.44f, "Húmus", "2022-01-01", 0, "", "A luta" },
                    { "9789897557439", "Gabriela Macedo", "", "9789897557439", "Português", 13.25f, "Húmus", "2022-01-01", 1, "", "Mulheres, artes e ditadura: Diálogos interartísticos e narrativas da memória" },
                    { "9789897557569", "", "", "9789897557569", "", 4.44f, "", "", 2, "", "Gente singular" },
                    { "9789897558184", "Ana Branca Soeiro de Carvalho", "", "9789897558184", "Português", 11f, "Húmus", "2022-01-01", 1, "", "Uma visão interdisciplinar sobre a transexualidade no século XXI" },
                    { "9789897558337", "Tennessee Williams", "", "9789897558337", "Português", 9.5f, "Húmus", "2022-01-01", 1, "", "Bruscamente no verão passado" },
                    { "9789897558962", "Jean Genet", "", "9789897558962", "Português", 11f, "Húmus", "2023-01-01", 0, "", "As criadas" },
                    { "9789897558986", "Leonor Rosas", "", "9789897558986", "Português", 10f, "Húmus", "2023-01-01", 1, "", "De quem se esqueceu Lisboa? A luta pela inscrição da memória anticolonial e antirracista no espaço público" },
                    { "9789897559136", "Nuno Milagre", "", "9789897559136", "Português", 10.6f, "Húmus", "2023-01-01", 20, "", "Angola degredo salvação: Imaginação e ação colonial em 1900" },
                    { "9789897731068", "Ray Bradbury", "https://covers.openlibrary.org/b/isbn/9789897731068-L.jpg", "9789897731068", "Português", 16.6f, "Saída de Emergência", "2018-01-01", 0, "", "Fahrenheit 451" },
                    { "9789897764097", "Todd Parr", "", "9789897764097", "Português", 12.99f, "08 Edições", "2019-01-01", 0, "", "Não faz mal ser diferente" },
                    { "9789897766343", "Todd Parr", "", "9789897766343", "Português", 12.99f, "08 Edições", "2021-01-01", 0, "", "O livro da família" },
                    { "9789897769672", "Sara O'Leary", "", "9789897769672", "Português", 14.99f, "0A8", "2022-01-01", 1, "", "Uma família é uma família é uma família" },
                    { "9789897769689", "Sara O'Leary", "", "9789897769689", "Português", 14.99f, "0A8", "2023-01-01", 0, "", "Uma criança é uma criança é uma criança" },
                    { "9789897769719", "Todd Parr", "", "9789897769719", "Português", 12.99f, "0A8", "2023-01-01", 1, "", "Sê quem tu és" },
                    { "9789897830211", "Ocean Vuong", "", "9789897830211", "Português", 17f, "Relógio D'Água", "2020-01-01", 4, "", "Na terra somos brevemente magníficos" },
                    { "9789897830235", "Caroline Criado Perez", "", "9789897830235", "Português", 19.5f, "Relógio d'Água", "2020-01-01", 0, "", "Mulheres invisíveis" },
                    { "9789897830808", "Oscar Wilde", "", "9789897830808", "Português", 17f, "Relógio D'Água", "2020-01-01", 0, "", "O retrato de Dorian Gray: edição não censurada" },
                    { "9789897831270", "", "", "9789897831270", "", 15f, "", "", 1, "", "Canoagem" },
                    { "9789897831478", "Agustina Bessa Luís", "", "9789897831478", "Português", 18f, "Relógio D'Água", "2021-01-01", 1, "", "Doidos e amantes" },
                    { "9789897831683", "Maria Filomena Mónica", "", "9789897831683", "Português", 19.5f, "Relógio d'Água", "2021-01-01", 0, "", "Uma estranha amizade: Eça de Queiroz e Ramalho Ortigão" },
                    { "9789897831904", "Kay Dick", "", "9789897831904", "Português", 16f, "Relógio D'Água", "2022-01-01", 2, "", "Eles" },
                    { "9789897831959", "Sylvia Plath", "", "9789897831959", "Português", 28.5f, "Relógio D'Água", "2021-01-01", 0, "", "Diários 1950-1962" },
                    { "9789897832109", "Margaret Atwood", "", "9789897832109", "Português", 17f, "Relógio D'Água", "2022-01-01", 1, "", "Políticas de poder" },
                    { "9789897832147", "Rui Nunes", "", "9789897832147", "Português", 16f, "Relógio D'Água", "2022-01-01", 1, "", "Irradiante, o negro" },
                    { "9789897832192", "Gustave Flaubert", "", "9789897832192", "Português", 12.5f, "Relógio D'Água", "2022-01-01", 0, "", "Madame Bovary" },
                    { "9789897832239", "Virginia Woolf", "", "9789897832239", "Português", 17f, "Relógio D'Água", "2022-01-01", 1, "", "O quarto de Jacob" },
                    { "9789897832277", "Virginia Woolf", "", "9789897832277", "Português", 18.5f, "Relógio d'Água", "2022-01-01", 0, "", "Cartas de amor" },
                    { "9789897832512", "Emily Dickinson", "", "9789897832512", "Português", 17.5f, "Relógio D'Água", "2022-01-01", 1, "", "Herbarium" },
                    { "9789897832673", "Virginia Woolf", "", "9789897832673", "Português", 27f, "Relógio d'Água", "2022-01-01", 1, "", "48 ensaios" },
                    { "9789897832895", "Ocean Vuong", "", "9789897832895", "Português", 17f, "Relógio D'Água", "2022-01-01", 0, "", "O tempo é uma mãe" },
                    { "9789897833106", "Konstantinos Kavafis", "", "9789897833106", "Português", 21.5f, "Relógio D'Água", "2023-01-01", 1, "", "Os poemas" },
                    { "9789897833342", "Honoré de Balzac", "", "9789897833342", "Português", 18f, "Relógio d'Água", "2023-01-01", 0, "", "O pai Goriot" },
                    { "9789897833373", "Patricia Highsmith", "", "9789897833373", "Português", 34f, "Relógio d'Água", "2023-01-01", 1, "", "Diários e cadernos" },
                    { "9789897833540", "Marguerite Yourcenar", "", "9789897833540", "Português", 16.5f, "Relógio D'Água", "2023-01-01", 2, "", "Alexis ou Tratado do vão combate" },
                    { "9789897833588", "Rui Nunes", "https://covers.openlibrary.org/b/isbn/9789897833588-L.jpg", "9789897833588", "Português", 15f, "Relógio d'Água", "2023-01-01", 0, "", "Neve, cão e lava" },
                    { "9789897840463", "", "", "9789897840463", "", 14.35f, "", "", 1, "", "Aventureira Marielle e o dia da fotografia" },
                    { "9789897840968", "", "", "9789897840968", "Português", 15.9f, "Nuvem de Tinta", "2020-01-01", 1, "", "The Prom: O baile de finalistas" },
                    { "9789897841385", "Anthony Burgess", "", "9789897841385", "Português", 19.45f, "Alfaguara", "2020-01-01", 1, "", "A laranja mecânica" },
                    { "9789897841866", "James Baldwin", "", "9789897841866", "Português", 16.65f, "Alfaguara", "2023-01-01", 1, "", "Da próxima vez, o fogo" },
                    { "9789897841934", "Jeferson Tenório", "", "9789897841934", "Português", 16.5f, "Companhia das Letras", "2021-01-01", 0, "", "O avesso da pele" },
                    { "9789897842085", "Douglas Stuart", "", "9789897842085", "Português", 23.95f, "Alfaguara", "2021-01-01", 3, "", "Shuggie Bain" },
                    { "9789897843082", "Brit Bennett", "", "9789897843082", "Português", 20.95f, "Alfaguara", "2021-01-01", 1, "", "A outra metade" },
                    { "9789897843310", "Franz Kafka", "", "9789897843310", "Português", 8.9f, "Penguin Clássicos", "2021-01-01", 0, "", "A metamorfose" },
                    { "9789897843327", "Virginia Woolf", "", "9789897843327", "Português", 9.95f, "Pinguin Clássicos", "2021-01-01", 1, "", "Um quarto só seu" },
                    { "9789897843341", "Lima Barreto", "", "9789897843341", "Português", 11.95f, "Penguin Clássicos", "2021-01-01", 1, "", "Triste fim de Policarpo Quaresma" },
                    { "9789897843365", "Jean-Jacques Rousseau", "", "9789897843365", "Português", 9.95f, "Penguin Clássicos", "2021-01-01", 0, "", "Discurso sobre a origem e os fundamentos da desigualdade entre os homens" },
                    { "9789897845024", "Benjamin Moser", "", "9789897845024", "Português", 28.85f, "Objectiva", "2022-01-01", 0, "", "Sontag: vida e obra" },
                    { "9789897845154", "Federico García Lorca", "", "9789897845154", "Português", 10.95f, "Penguin Clássicos", "2022-01-01", 1, "", "Romanceiro cigano e Poeta em Nova Iorque" },
                    { "9789897845628", "Júlia Lopes de Almeida", "", "9789897845628", "Português", 11.95f, "Penguin Clássicos", "2022-01-01", 0, "", "A falência" },
                    { "9789897845635", "", "https://covers.openlibrary.org/b/isbn/9789897845635-L.jpg", "9789897845635", "Português", 16.95f, "Companhia das Letras", "2022-01-01", 1, "", "Reconstituição Portuguesa" },
                    { "9789897846656", "Katherine Mansfield", "", "9789897846656", "Português", 13.25f, "Penguin Clássicos", "2022-01-01", 0, "", "Festa no jardim e outros contos" },
                    { "9789897847172", "Caetano Veloso", "", "9789897847172", "Português", 21.95f, "Companhia das Letras", "2023-01-01", 2, "", "Letras" },
                    { "9789897847189", "Hilda Hilst", "", "9789897847189", "Português", 20.95f, "Companhia das Letras", "2022-01-01", 0, "", "A obscena Senhora D e outras histórias" },
                    { "9789897847738", "Alice Walker", "", "9789897847738", "Português", 18.85f, "Suma de Letras", "2023-01-01", 1, "", "A cor púrpura" },
                    { "9789897847912", "Frederick Douglass", "", "9789897847912", "Português", 14.35f, "Pinguin Clássicos", "2023-01-01", 1, "", "Narrativa da vida de Frederick Douglass, um escravo americano e outros textos" },
                    { "9789897848247", "Lúcia Vicente", "", "9789897848247", "Português", 13.95f, "Nuvem de Letras", "2023-01-01", 0, "", "No meu bairro" },
                    { "9789897849183", "Douglas Stuart", "", "9789897849183", "Português", 22.95f, "Alfaguara", "2023-01-01", 0, "", "Um lugar para Mungo" },
                    { "9789897849619", "Marion Kadi", "", "9789897849619", "Português", 15.95f, "Fábula", "2023-01-01", 0, "", "Os reflexos da Henriqueta" },
                    { "9789897870231", "", "", "9789897870231", "", 22.95f, "", "", 1, "", "Vernon Subutex: 3" },
                    { "9789897870392", "Eleanor Crewes", "", "9789897870392", "Português", 16.65f, "Iguana", "2023-01-01", 0, "", "Quando soube que era gay" },
                    { "9789897870576", "Pedro Almodóvar", "", "9789897870576", "Português", 18.45f, "Alfaguara", "2023-01-01", 0, "", "O último sonho" },
                    { "9789897870644", "", "", "9789897870644", "", 19.45f, "", "", 0, "", "Guia para lésbicas num colégio católico" },
                    { "9789897872303", "", "", "9789897872303", "", 14.95f, "", "", 0, "", "O que é ser uma escritora negra hoje, de acordo comigo" },
                    { "9789897872365", "", "", "9789897872365", "", 18.85f, "", "", 0, "", "Maus hábitos" },
                    { "9789897872518", "Virginie Despentes", "", "9789897872518", "Português", 20.95f, "Elsinore", "2023-01-01", 1, "", "Caro idiota" },
                    { "9789897875472", "", "", "9789897875472", "", 10.95f, "", "", 0, "", "A revolução russa" },
                    { "9789897876226", "", "", "9789897876226", "", 18.45f, "", "", 2, "", "Notas de um filho da terra" },
                    { "9789897876530", "", "", "9789897876530", "", 10.95f, "", "", 1, "", "Dom Casmurro" },
                    { "9789897877544", "Jeferson Tenório", "", "9789897877544", "Português", 15.95f, "Companhia das Letras", "2024-01-01", 0, "", "Estela sem Deus" },
                    { "9789898093110", "John Cheever", "", "9789898093110", "", 15.5f, "Sextante", "2007-01-01", 1, "", "Falconer" },
                    { "9789898139788", "", "", "9789898139788", "Português", 12.72f, "Húmus", "2011-01-01", 1, "", "Género, cultura visual e performance" },
                    { "9789898145048", "Isabel Minhós Martins", "", "9789898145048", "Português", 11.9f, "Planeta Tangerina", "2008-01-01", 2, "", "Coração de mãe" },
                    { "9789898145222", "Isabel Minhós Martins", "", "9789898145222", "Português", 12.5f, "Planeta Tangerina", "2010-01-01", 1, "", "A manta" },
                    { "9789898145307", "Chloé Wary", "", "9789898145307", "Português", 18.9f, "Planeta Tangerina", "2020-01-01", 1, "", "A época das rosas" },
                    { "9789898145314", "Isabel Minhós Martins", "", "9789898145314", "Português", 12.5f, "Planeta Tangerina", "2011-01-01", 1, "", "Obrigado a todos!" },
                    { "9789898145321", "Bernardo P. Carvalho", "", "9789898145321", "", 15f, "Planeta Tangerina", "2011-01-01", 2, "", "Praia-mar" },
                    { "9789898145352", "Isabel Minhós Martins", "", "9789898145352", "Português", 12.5f, "Tangerina", "2014-01-01", 1, "", "Para onde vamos quando desaparecemos?" },
                    { "9789898145383", "Madalena Matoso", "", "9789898145383", "Português", 12.9f, "Planeta Tangerina", "2011-01-01", 0, "", "Todos fazemos tudo" },
                    { "9789898145390", "Joana Estrela", "", "9789898145390", "Português", 12.9f, "Planeta Tangerina", "2020-01-01", 3, "", "Menino, menina" },
                    { "9789898145406", "Isabel Minhós Martins", "https://covers.openlibrary.org/b/isbn/9789898145406-L.jpg", "9789898145406", "Português", 11.9f, "Planeta Tangerina", "2014-01-01", 1, "", "Um livro para todos os dias" },
                    { "9789898145451", "Ana Pessoa", "", "9789898145451", "", 14f, "Planeta Tangerina", "2014-01-01", 0, "", "O caderno vermelho da rapariga karateca" },
                    { "9789898145482", "Isabel Meira", "", "9789898145482", "Português", 17.9f, "Planeta Tangerina", "2020-01-01", 0, "", "Gosto, logo existo" },
                    { "9789898145499", "Isabel Minhós Martins", "", "9789898145499", "Português", 16.9f, "Planeta Tangerina", "2012-01-01", 1, "", "O que há" },
                    { "9789898145512", "Manuela Castro Neves", "", "9789898145512", "Português", 12.9f, "Planeta Tangerina", "2013-01-01", 0, "", "Tantos animais e outras lengalengas de contar" },
                    { "9789898145529", "Ana Pessoa", "", "9789898145529", "Português", 13.9f, "Planeta Tangerina", "2020-01-01", 1, "", "O gnu e o texugo" },
                    { "9789898145581", "Maria Ana Peixe Dias", "", "9789898145581", "Português", 26.8f, "Planeta Tangerina", "2014-01-01", 0, "", "Lá fora" },
                    { "9789898145604", "Isabel Minhós Martins", "", "9789898145604", "Português", 12.9f, "Planeta Tangerina", "2014-01-01", 1, "", "Com o tempo" },
                    { "9789898145611", "Isabel Minhós Martins", "", "9789898145611", "Português", 12.5f, "Planeta Tangerina", "2014-01-01", 2, "", "ABZZZZ..." },
                    { "9789898145628", "Isabel Minhós Martins", "", "9789898145628", "Português", 13.5f, "Planeta Tangerina", "2014-01-01", 1, "", "Daqui ninguém passa!" },
                    { "9789898145635", "Madalena Matoso", "", "9789898145635", "Português", 16.9f, "Planeta Tangerina", "2016-01-01", 1, "", "Livro Clap" },
                    { "9789898145642", "pseud. ATAK", "", "9789898145642", "Português", 13.5f, "Planeta Tangerina", "2015-01-01", 0, "", "O mundo ao contrário" },
                    { "9789898145666", "Mariko Tamaki", "", "9789898145666", "Português", 18.9f, "Planeta Tangerina", "2015-01-01", 0, "", "Finalmente o verão" },
                    { "9789898145680", "", "", "9789898145680", "", 18.9f, "", "", 0, "", "Era uma vez (e muitas outras serão)" },
                    { "9789898145697", "Gonçalo M. Tavares", "", "9789898145697", "Português", 13.9f, "Planeta Tangerina", "2015-01-01", 1, "", "O dicionário do menino Andersen" },
                    { "9789898145727", "Joana Estrela", "", "9789898145727", "Português", 13.5f, "Planeta Tangerina", "2016-01-01", 2, "", "Mana" },
                    { "9789898145758", "", "", "9789898145758", "", 10.9f, "", "", 1, "", "Dobra letras" },
                    { "9789898145765", "Yara Kono", "", "9789898145765", "Português", 16.9f, "Planeta Tangerina", "2016-01-01", 1, "", "Batata chaca chaca" },
                    { "9789898145789", "Daniel Fehr", "", "9789898145789", "Português", 16.9f, "Planeta Tangerina", "2017-01-01", 1, "", "A bola amarela" },
                    { "9789898145796", "Joana Estrela", "", "9789898145796", "Português", 13.9f, "Planeta Tangerina", "2017-01-01", 2, "", "A rainha do Norte" },
                    { "9789898145802", "Isabel Minhós Martins", "", "9789898145802", "Português", 12.5f, "Planeta Tangerina", "2017-01-01", 1, "", "Cem sementes que voaram" },
                    { "9789898145819", "Isabel Minhós Martins", "https://covers.openlibrary.org/b/isbn/9789898145819-L.jpg", "9789898145819", "Português", 24.6f, "Planeta Tangerina", "2018-01-01", 1, "", "Cá dentro" },
                    { "9789898145826", "Isabel Minhós Martins", "", "9789898145826", "Português", 17.5f, "Planeta Tangerina", "2017-01-01", 1, "", "Um ano inteiro: Almanaque da natureza" },
                    { "9789898145857", "Chloé Perarnau", "", "9789898145857", "Português", 15.9f, "Planeta Tangerina", "2018-01-01", 1, "", "A orquestra" },
                    { "9789898145888", "Ana Pessoa", "", "9789898145888", "Português", 12.9f, "Planeta Tangerina", "2018-01-01", 2, "", "Eu sou, eu sei" },
                    { "9789898145895", "Yara Kono", "", "9789898145895", "Português", 12.5f, "Planeta Tangerina", "2018-01-01", 1, "", "Telefone sem fio" },
                    { "9789898145901", "Ana Pêgo", "", "9789898145901", "Português", 17.9f, "Planeta Tangerina", "2018-01-01", 2, "", "Plasticus maritimus: uma espécie invasora" },
                    { "9789898145918", "Bernardo P. Carvalho", "", "9789898145918", "Português", 12.5f, "Planeta Tangerina", "2019-01-01", 1, "", "Banana!" },
                    { "9789898145925", "Isabel Minhós Martins", "", "9789898145925", "Português", 12.5f, "Planeta Tangerina", "2019-01-01", 1, "", "Metade metade" },
                    { "9789898145932", "Ana Pessoa", "", "9789898145932", "Português", 18.9f, "Planeta Tangerina", "2019-01-01", 2, "", "Aqui é um bom lugar" },
                    { "9789898145970", "Ana Pessoa", "", "9789898145970", "Português", 18.9f, "Planeta Tangerina", "2020-01-01", 0, "", "Desvio" },
                    { "9789898145987", "José Maria Vieira Mendes", "", "9789898145987", "Português", 13.9f, "Planeta Tangerina", "2020-01-01", 1, "", "Para que serve?" },
                    { "9789898146410", "Raquel Lito", "", "9789898146410", "", 7.5f, "Humanity's Friends Books", "2010-01-01", 0, "", "3.º Sexo: Histórias de 12 homossexuais portugueses" },
                    { "9789898166005", "Shel Silverstein", "", "9789898166005", "Português", 13.93f, "Bruaá", "2008-01-01", 1, "", "A árvore generosa" },
                    { "9789898166012", "Davide Cali", "", "9789898166012", "Português", 13.73f, "Bruaá", "2008-01-01", 1, "", "Eu espero" },
                    { "9789898166036", "Peter H. Reynolds", "", "9789898166036", "Português", 13.12f, "Bruaá", "2009-01-01", 1, "", "O ponto" },
                    { "9789898166159", "Vários Autores", "https://covers.openlibrary.org/b/isbn/9789898166159-L.jpg", "9789898166159", "Português", 14f, "Bruaá", "2012-01-01", 0, "", "O tigre na rua e outros poemas" },
                    { "9789898166197", "Ivan Chermayeff", "", "9789898166197", "Português", 13f, "Bruaá", "2013-01-01", 3, "", "Um nome para o cão" },
                    { "9789898166203", "Sandol Stoddard", "", "9789898166203", "Português", 14f, "Bruaá", "2013-01-01", 2, "", "Guarda como um segredo" },
                    { "9789898166210", "Sandol Stoddard", "https://covers.openlibrary.org/b/isbn/9789898166210-L.jpg", "9789898166210", "Português", 14f, "Bruaá", "2014-01-01", 2, "", "Estava a pensar" },
                    { "9789898166258", "Chernysheva Natalia", "", "9789898166258", "Português", 12.5f, "Bruaá", "2014-01-01", 1, "", "O regresso" },
                    { "9789898166296", "Frank Tashlin", "", "9789898166296", "Português", 13.5f, "Bruaá", "2016-01-01", 2, "", "O urso que não era" },
                    { "9789898166326", "Shirley Glaser", "", "9789898166326", "Português", 14f, "Bruaá", "2017-01-01", 2, "", "Se as maçãs tivessem dentes" },
                    { "9789898166371", "Kjell Ringi", "", "9789898166371", "Português", 13f, "Bruaá", "2018-01-01", 0, "", "O estranho" },
                    { "9789898166388", "Kjell Ringi", "", "9789898166388", "Português", 11.95f, "Bruaá", "2019-01-01", 1, "", "O vencedor" },
                    { "9789898166395", "Luís Correia Carmelo", "", "9789898166395", "Português", 14.5f, "Bruaá", "2018-01-01", 0, "", "Pergunta ao teu pai e outras frases misteriosas dos adultos" },
                    { "9789898166425", "", "", "9789898166425", "Português", 14f, "Bruaá", "2019-01-01", 1, "", "A canção do jardineiro louco e outros poemas" },
                    { "9789898166449", "Miguel Gouveia", "", "9789898166449", "Português", 14f, "Bruaá", "2019-01-01", 2, "", "A manta do José" },
                    { "9789898166470", "Aurore Petit", "", "9789898166470", "Português", 14f, "Bruaá", "2021-01-01", 1, "", "Uma mãe é como uma casa" },
                    { "9789898166487", "Patrícia Portela", "", "9789898166487", "Português", 14.9f, "Bruaá", "2021-01-01", 1, "", "Seis histórias de tamanhos diferentes" },
                    { "9789898166500", "Leonor Santa-Rita", "", "9789898166500", "Português", 11.9f, "Bruaá", "2021-01-01", 0, "", "Gosto de ti" },
                    { "9789898166517", "Jacinto Lucas Pires", "", "9789898166517", "Português", 15.5f, "Bruaá", "2022-01-01", 0, "", "Faz diferença" },
                    { "9789898166548", "", "", "9789898166548", "", 17.95f, "", "", 0, "", "O rato que levava uma casa às costas" },
                    { "9789898205117", "Iela Mari", "", "9789898205117", "Português", 12.5f, "Kalandraka", "2009-01-01", 1, "", "As estações" },
                    { "9789898205315", "Maurice Sendak", "", "9789898205315", "Português", 16f, "Kalandraka", "2009-01-01", 1, "", "Onde vivem os monstros" },
                    { "9789898205483", "pseud. Janosch", "", "9789898205483", "Português", 15f, "Kalandraka", "2010-01-01", 1, "", "Oh, que lindo que é o Panamá" },
                    { "9789898205667", "Arnold Lobel", "", "9789898205667", "Português", 14f, "Kalandraka", "2011-01-01", 0, "", "O tio elefante" },
                    { "9789898205674", "pseud. Janosch", "", "9789898205674", "Português", 15f, "Kalandraka", "2011-01-01", 1, "", "Correio para o tigre" },
                    { "9789898205704", "Tomi Ungerer", "", "9789898205704", "Português", 14f, "Kalandraka", "2011-01-01", 1, "", "Crictor" },
                    { "9789898205827", "Leo Lionni", "", "9789898205827", "Português", 15f, "Kalandraka", "2013-01-01", 1, "", "O sonho de Mateus" },
                    { "9789898205988", "Arnold Lobel", "", "9789898205988", "Português", 14f, "Kalandraka", "2013-01-01", 1, "", "Histórias de ratinhos" },
                    { "9789898205995", "Arnold Lobel", "", "9789898205995", "Português", 14f, "Kalandraka", "2013-01-01", 0, "", "Sopa de rato" },
                    { "9789898268211", "Zetho Cunha Gonçalves", "", "9789898268211", "Português", 14f, "Letra Livre", "2014-01-01", 0, "", "Notícia do Maior Escândalo Erótico-Social do Século XX" },
                    { "9789898268334", "", "", "9789898268334", "Português", 15f, "Letra Livre", "2016-01-01", 0, "", "A literatura e o mal" },
                    { "9789898268396", "Frantz Fanon", "", "9789898268396", "Português", 15f, "Letra Livre", "2017-01-01", 1, "", "Pele negra, máscaras brancas" },
                    { "9789898268471", "Emma Goldman", "", "9789898268471", "Português", 13f, "Livraria Letra Livre", "2020-01-01", 0, "", "Anarquismo e outros ensaios" },
                    { "9789898268488", "Frantz Fanon", "", "9789898268488", "Português", 16f, "Letra Livre", "2021-01-01", 1, "", "Os condenados da Terra" },
                    { "9789898268563", "Mário Domingues", "", "9789898268563", "Português", 16f, "Falas Afrikanas", "2023-01-01", 1, "", "A liberdade não se concede, conquista-se. Que a conquistem os negros!" },
                    { "9789898268587", "Ana Clotilde Correia", "", "9789898268587", "Português", 16f, "Letra Livre", "2024-01-01", 1, "", "Dissidências e resistências homossexuais no século XX português" },
                    { "9789898306050", "Witold Gombrowicz", "", "9789898306050", "Português", 19f, "7Nós", "2011-01-01", 1, "", "Ferdydurke" },
                    { "9789898306159", "Ghérasim Luca", "", "9789898306159", "Português", 12f, "7 Nós", "2014-01-01", 0, "", "O vampiro passivo" },
                    { "9789898327109", "Gilles Deleuze", "", "9789898327109", "Português", 16f, "Orfeu Negro", "2011-01-01", 1, "", "Francis Bacon: Lógica da sensação" },
                    { "9789898327383", "Hilda Hilst", "", "9789898327383", "Português", 15f, "Orfeu Negro", "2014-01-01", 2, "", "Obscénica" },
                    { "9789898327444", "Lemony Snicket", "", "9789898327444", "Português", 15f, "Orfeu Negro", "2014-01-01", 1, "", "O escuro" },
                    { "9789898327529", "Simona Ciraolo", "", "9789898327529", "Português", 15f, "Orfeu Negro", "2015-01-01", 1, "", "Quero um abraço" },
                    { "9789898327581", "Sabine Melchior-Bonnet", "", "9789898327581", "Português", 17f, "Orfeu Negro", "2016-01-01", 0, "", "História do espelho" },
                    { "9789898327666", "Peter Brown", "", "9789898327666", "Português", 14.5f, "Orfeu Negro", "2016-01-01", 1, "", "O Sr. Tigre torna-se selvagem" },
                    { "9789898327697", "Catarina Sobral", "", "9789898327697", "Português", 13.5f, "Orfeu Negro", "2016-01-01", 1, "", "Tão TÃO grande" },
                    { "9789898327765", "", "", "9789898327765", "Português", 14.5f, "Orfeu Negro", "2016-01-01", 2, "", "Livros para o amanhã: 4 – As mulheres e os homens" },
                    { "9789898327772", "", "", "9789898327772", "Português", 14.5f, "Orfeu Negro", "2016-01-01", 2, "", "Livros para o amanhã: 3 – Há classes sociais" },
                    { "9789898327789", "", "", "9789898327789", "", 7f, "", "", 1, "", "Rio acima" },
                    { "9789898327796", "Manuel Marsol", "", "9789898327796", "Português", 10f, "Orfeu Negro", "2016-01-01", 0, "", "Ahab e a baleia branca" },
                    { "9789898327802", "Hans-Thies Lehmann", "", "9789898327802", "Português", 10f, "Orfeu Negro", "2017-01-01", 1, "", "Teatro pós-dramático" },
                    { "9789898327871", "Tiago Bartolomeu Costa", "", "9789898327871", "Português", 5f, "Orfeu Negro", "2016-01-01", 1, "", "O cego que atravessou montanhas: Conversas com Luis Miguel Cintra" },
                    { "9789898327918", "Kelly Dipucchio", "", "9789898327918", "Português", 7f, "Orfeu Negro", "2017-01-01", 0, "", "Gaston" },
                    { "9789898327932", "", "", "9789898327932", "Português", 14.5f, "Orfeu Negro", "2017-01-01", 2, "", "Livros para o amanhã: 2 – É assim a ditadura" },
                    { "9789898327949", "", "", "9789898327949", "Português", 14.5f, "Orfeu Negro", "2017-01-01", 1, "", "Livros para o amanhã: 1 – Como pode ser a democracia" },
                    { "9789898349071", "André Murraças", "", "9789898349071", "Português", 9.5f, "Bicho do Mato", "2009-01-01", 1, "", "Film noir" },
                    { "9789898349088", "Bernard Pomerance", "", "9789898349088", "Português", 9.5f, "Bicho do Mato", "2010-01-01", 1, "", "O homem elefante" },
                    { "9789898349118", "Ronald Harwood", "", "9789898349118", "Português", 9.5f, "Bicho do Mato", "2010-01-01", 2, "", "O camareiro" },
                    { "9789898349200", "Edward Albee", "", "9789898349200", "Português", 13f, "Bicho do Mato", "2011-01-01", 1, "", "Quem tem medo de Virginia Woolf?" },
                    { "9789898349231", "Peter Shaffer", "", "9789898349231", "Português", 13f, "Bicho do Mato", "2011-01-01", 1, "", "Amadeus" },
                    { "9789898349293", "Cláudia Lucas Chéu", "", "9789898349293", "Português", 10f, "Bicho do Mato", "2013-01-01", 1, "", "Violência: Fetiche do homem bom" },
                    { "9789898349323", "Edward Albee", "", "9789898349323", "Português", 11f, "Bicho do Mato", "2014-01-01", 1, "", "Três mulheres altas" },
                    { "9789898349392", "Ricardo Neves Neves", "", "9789898349392", "Português", 11f, "Teatro Nacional D. Maria II", "2015-01-01", 1, "", "Entraria nesta sala..." },
                    { "9789898349552", "Davide Carnevali", "", "9789898349552", "Português", 10f, "Teatro Nacional D. Maria", "2018-01-01", 1, "", "Sweet Home Europa" },
                    { "9789898349675", "Cláudia Lucas Chéu", "", "9789898349675", "Português", 11f, "Teatro Nacional D. Maria II", "2022-01-01", 2, "", "Orlando: Um tratado sobre a dignidade humana" },
                    { "9789898349712", "Pedro Penim", "", "9789898349712", "Português", 10f, "Teatro Nacional D. Maria II", "2022-01-01", 0, "", "Casa portuguesa" },
                    { "9789898363367", "Rui Eduardo Pais", "", "9789898363367", "Português", 10f, "Chili Com Carne", "2016-01-01", 0, "", "Anarco-queer? Queercore" },
                    { "9789898443106", "", "", "9789898443106", "", 3f, "", "", 1, "", "Livro ruído (Usado)" },
                    { "9789898566041", "Jean Lorrain", "", "9789898566041", "Português", 11f, "Sistema Solar", "2012-01-01", 1, "", "O senhor de Bougrelon" },
                    { "9789898566089", "Jean Genet", "", "9789898566089", "Português", 14f, "Sistema Solar", "2012-01-01", 1, "", "No sentido da noite" },
                    { "9789898566096", "Georges Bataille", "", "9789898566096", "", 12f, "Sistema Solar", "2012-01-01", 0, "", "As lágrimas de Eros" },
                    { "9789898566102", "Henry James", "", "9789898566102", "Português", 16f, "Sistema Solar", "2013-01-01", 2, "", "O aperto do parafuso" },
                    { "9789898566201", "Guillaume Apollinaire", "", "9789898566201", "Português", 14f, "Sistema Solar", "2012-01-01", 1, "", "As mamas de Tirésias" },
                    { "9789898566225", "DuBose Heyward", "", "9789898566225", "Português", 14f, "Sistema Solar", "2013-01-01", 1, "", "Porgy e Bess" },
                    { "9789898566324", "Herman Melville", "", "9789898566324", "Português", 14f, "Sistema Solar", "2013-01-01", 2, "", "Billy Budd, marinheiro" },
                    { "9789898566515", "Emmanuel Rhoides", "", "9789898566515", "Português", 15f, "Sistema Solar", "2014-01-01", 1, "", "A Papisa Joana" },
                    { "9789898566652", "René Crevel", "", "9789898566652", "Português", 12f, "Sistema Solar", "2014-01-01", 2, "", "O meu corpo e eu" },
                    { "9789898566669", "Adolfo Caminha", "", "9789898566669", "Português", 14f, "Sistema Solar", "2014-01-01", 2, "", "Bom crioulo" },
                    { "9789898566836", "Mário Cesariny", "", "9789898566836", "Português", 19f, "Fundação Cupertino de Miranda", "2014-01-01", 1, "", "Cartas de Mário Cesariny para Cruzeiro Seixas" },
                    { "9789898580528", "Annemarie Schwarzenbach", "", "9789898580528", "Português", 14f, "Teodolito", "2017-01-01", 1, "", "O vale feliz" },
                    { "9789898580696", "Annemarie Schwarzenbach", "", "9789898580696", "Português", 11f, "Teodolito", "2019-01-01", 1, "", "Novela lírica" },
                    { "9789898618399", "António Fernando Cascais", "", "9789898618399", "Português", 16f, "Documenta", "2016-01-01", 0, "", "Hospital Miguel Bombarda: 1968" },
                    { "9789898618825", "Jean Cocteau", "", "9789898618825", "", 12f, "Sistema Solar", "2015-01-01", 0, "", "O livro branco, seguido de O fantasma de Marselha" },
                    { "9789898618863", "Mário Cesariny", "", "9789898618863", "Português", 14f, "Fundação Cupertino de Miranda ;", "2015-01-01", 2, "", "Um sol esplendente nas coisas: Cartas de Mário Cesariny para Alberto de Lacerda" },
                    { "9789898618955", "Guy de Pourtalès", "", "9789898618955", "Português", 15f, "Sistema Solar", "2015-01-01", 1, "", "Hamlet-Rei (Luís II da Baviera)" },
                    { "9789898688163", "León de Greiff", "", "9789898688163", "Português", 16f, "Abysmo", "2014-01-01", 0, "", "Troco a minha vida por candeeiros velhos" },
                    { "9789898688453", "", "", "9789898688453", "", 12f, "", "", 1, "", "Odes olímpicas" },
                    { "9789898688583", "Fernanda Botelho", "", "9789898688583", "Português", 17f, "Abysmo", "2018-01-01", 0, "", "A gata e a fábula" },
                    { "9789898688972", "Paulo José Miranda", "", "9789898688972", "Português", 18f, "Abysmo", "2019-01-01", 1, "", "Um prego no coração: Trilogia" },
                    { "9789898800237", "João Gilberto Noll", "", "9789898800237", "Português", 13.99f, "Elsinore", "2015-01-01", 2, "", "Lorde" },
                    { "9789898831989", "pseud. Dr. Seuss", "https://covers.openlibrary.org/b/isbn/9789898831989-L.jpg", "9789898831989", "Português", 14.39f, "Booksmile", "2016-01-01", 1, "", "Ovos verdes e presunto" },
                    { "9789898833051", "Jean Cocteau", "", "9789898833051", "Português", 15f, "Sistema Solar", "2016-01-01", 1, "", "Visão invisível" },
                    { "9789898833112", "James Hogg", "", "9789898833112", "Português", 24f, "Sistema Solar", "2016-01-01", 1, "", "Memórias íntimas e confissões de um pecador justificado" },
                    { "9789898833129", "Arthur Rimbaud", "", "9789898833129", "Português", 15f, "Sistema Solar", "2017-01-01", 1, "", "Rimbaud-Verlaine: O estranho casal" },
                    { "9789898833136", "", "", "9789898833136", "", 16f, "", "", 2, "", "Perceptores: Gabrielle de Bergerac, seguido de O discípulo" },
                    { "9789898833143", "Ambrose Gwinnett Bierce", "", "9789898833143", "Português", 15f, "Sistema Solar", "2016-01-01", 0, "", "O dicionário do diabo" },
                    { "9789898833174", "Visconde de Vila Moura", "", "9789898833174", "Português", 15f, "Sistema Solar", "2017-01-01", 0, "", "Nova Safo: Tragédia estranha – romance de patologia sensual" },
                    { "9789898833273", "", "", "9789898833273", "", 15f, "", "", 2, "", "A minha amiga Nane" },
                    { "9789898833280", "Joris Karl Huysmans", "", "9789898833280", "Português", 13f, "Sistema Solar", "2018-01-01", 0, "", "O castelo do homem ancorado" },
                    { "9789898833303", "Joseph Conrad", "", "9789898833303", "Português", 12f, "Sistema Solar", "2018-01-01", 1, "", "Tufão" },
                    { "9789898833334", "Antonin Artaud", "", "9789898833334", "Português", 12f, "Sistema Solar", "2018-01-01", 1, "", "Heliogábalo ou O anarquista coroado" },
                    { "9789898833358", "René Crevel", "", "9789898833358", "Português", 14f, "Sistema Solar", "2018-01-01", 1, "", "A morte difícil" },
                    { "9789898833365", "Marina Tsvétaeva", "", "9789898833365", "Português", 12f, "Sistema Solar", "2020-01-01", 1, "", "Meu irmão feminino e “Noites florentinas”" },
                    { "9789898833372", "Aphra Behn", "", "9789898833372", "Português", 12f, "Sistema Solar", "2019-01-01", 2, "", "Orunoko ou o escravo real" },
                    { "9789898833402", "", "", "9789898833402", "", 12f, "", "", 1, "", "As portas do Paraíso" },
                    { "9789898833426", "Georges Bernanos", "", "9789898833426", "Português", 14f, "Sistema Solar", "2019-01-01", 1, "", "Diálogos das Carmelitas" },
                    { "9789898833471", "Ronald Firbank", "", "9789898833471", "Português", 12f, "Sistema Solar", "2020-01-01", 0, "", "Das excentricidades do Cardeal Pirelli" },
                    { "9789898833488", "", "", "9789898833488", "", 13f, "", "", 2, "", "Paludes" },
                    { "9789898833532", "", "", "9789898833532", "", 14f, "", "", 1, "", "Sol" },
                    { "9789898833549", "André Gide", "", "9789898833549", "", 14f, "Sistema Solar", "2020-01-01", 1, "", "Os meus Oscar Wilde" },
                    { "9789898833693", "", "", "9789898833693", "", 16f, "", "", 2, "", "A dificuldade de ser" },
                    { "9789898833709", "", "", "9789898833709", "", 14f, "", "", 1, "", "Má sorte que ela fosse puta" },
                    { "9789898833730", "", "", "9789898833730", "", 12f, "", "", 2, "", "Casa de incesto" },
                    { "9789898833822", "Mário Cesariny", "", "9789898833822", "Português", 26f, "Documenta ;", "1921-01-01", 1, "", "Textos de afirmação e de combate do movimento surrealista mundial" },
                    { "9789898834454", "Fernando Cabral Martins", "", "9789898834454", "Português", 14f, "Documenta", "2016-01-01", 1, "", "Mário Cesariny e O Virgem Negra" },
                    { "9789898839053", "Sara Pennypacker", "", "9789898839053", "Português", 16.59f, "Booksmile", "2016-01-01", 0, "", "Pax" },
                    { "9789898839381", "", "", "9789898839381", "", 17.69f, "", "", 1, "", "Crash" },
                    { "9789898843555", "Megan Bradbury", "", "9789898843555", "Português", 18.79f, "Elsinore", "2016-01-01", 1, "", "Onde todos observam" },
                    { "9789898849779", "Marina Perezagua", "", "9789898849779", "Português", 20.99f, "Elsinore", "2016-01-01", 0, "", "Yoro" },
                    { "9789898858405", "José Régio", "", "9789898858405", "Português", 15.9f, "Opera Omnia", "2019-01-01", 0, "", "Histórias de mulheres" },
                    { "9789898858443", "José Régio", "", "9789898858443", "Português", 15.9f, "Opera Omnia", "2019-01-01", 2, "", "Jogo da cabra cega" },
                    { "9789898858467", "José Régio", "", "9789898858467", "Português", 10f, "Opera Omnia", "2019-01-01", 2, "", "Três peças em um ato" },
                    { "9789898860712", "Alice Oseman", "", "9789898860712", "Português", 19.95f, "Desrotina", "2023-01-01", 1, "", "Rádio silêncio" },
                    { "9789898864031", "Ali Smith", "", "9789898864031", "Português", 17.76f, "Elsinore", "2017-01-01", 1, "", "Outono" },
                    { "9789898864062", "Paul Beatty", "", "9789898864062", "Português", 21.95f, "Elsinore", "2017-01-01", 1, "", "O vendido" },
                    { "9789898864116", "Helen Oyeyemi", "", "9789898864116", "Português", 19.99f, "Elsinore", "2017-01-01", 1, "", "Rapaz, neve, ave" },
                    { "9789898864154", "Rose Tremain", "", "9789898864154", "Português", 19.99f, "Elsinore", "2017-01-01", 2, "", "Sonata a Gustav" },
                    { "9789898864222", "Ali Smith", "", "9789898864222", "Português", 19.99f, "Elsinore", "2017-01-01", 1, "", "Como ser uma e outra" },
                    { "9789898864253", "Paul Beatty", "", "9789898864253", "Português", 18.79f, "Elsinore", "2018-01-01", 1, "", "A dança do rapaz branco" },
                    { "9789898864277", "Eka Kurniawan", "", "9789898864277", "Português", 16.99f, "Elsinore", "2018-01-01", 1, "", "Homem-tigre" },
                    { "9789898864451", "Ali Smith", "", "9789898864451", "Português", 20.45f, "Elsinore", "2018-01-01", 2, "", "Inverno" },
                    { "9789898864543", "Virginie Despentes", "", "9789898864543", "Português", 21.45f, "Elsinore", "2019-01-01", 1, "", "Vernon Subutex: 1" },
                    { "9789898864598", "Jamel Brinkley", "", "9789898864598", "Português", 20.99f, "Elsinore", "2019-01-01", 1, "", "Um homem de sorte" },
                    { "9789898864611", "Ali Smith", "", "9789898864611", "Português", 16.59f, "Elsinore", "2019-01-01", 0, "", "Rapariga encontra rapaz" },
                    { "9789898864925", "Ana de Castro Osório", "", "9789898864925", "Português", 11.99f, "Terramar", "2019-01-01", 0, "", "O esperto e outras histórias" },
                    { "9789898866264", "Maria Judite de Carvalho", "", "9789898866264", "Português", 17.9f, "Minotauro", "2018-01-01", 0, "", "Obras completas: 2 – Paisagem sem barcos / Os armários vazios / O seu amor por Etel" },
                    { "9789898866660", "Maria Judite de Carvalho", "", "9789898866660", "Português", 17.9f, "Minotauro", "2019-01-01", 0, "", "Obras completas: 5 – Este tempo / Seta despedida / A flor que havia na água parada / Havemos de rir!" },
                    { "9789898866677", "Thomas Bernhard", "", "9789898866677", "Português", 16.9f, "Minotauro", "2019-01-01", 0, "", "Betão" },
                    { "9789898868015", "Pierre Pratt", "", "9789898868015", "Português", 5f, "Orfeu Negro", "2017-01-01", 1, "", "Boa noite!" },
                    { "9789898868091", "Judith Butler", "", "9789898868091", "Português", 18f, "Orfeu Negro", "2017-01-01", 2, "", "Problemas de género: Feminismo e subversão da identidade" },
                    { "9789898868152", "Ezra Jack Keats", "", "9789898868152", "Português", 10f, "Orfeu Negro", "2018-01-01", 0, "", "Um dia de neve" },
                    { "9789898868312", "Madalena Moniz", "", "9789898868312", "Português", 10f, "Orfeu Negro", "2018-01-01", 2, "", "João Timoneiro" },
                    { "9789898868336", "Romana Romanyshyn", "", "9789898868336", "Português", 10f, "Orfeu Negro", "2018-01-01", 1, "", "Alto, baixo, num sussurro" },
                    { "9789898868343", "Bell Hooks", "", "9789898868343", "Português", 18f, "Orfeu Negro", "2018-01-01", 1, "", "Não serei eu mulher?: As mulheres negras e o feminismo" },
                    { "9789898868374", "Élisabeth Bellas", "", "9789898868374", "Português", 10f, "Orfeu Negro", "2018-01-01", 1, "", "História da virilidade: 1 – A invenção da virilidade, da Antiguidade às Luzes" },
                    { "9789898868459", "", "", "9789898868459", "Português", 7.5f, "Orfeu Negro", "2019-01-01", 0, "", "Confissões de um travesti" },
                    { "9789898868510", "Joan Negrescolor", "", "9789898868510", "Português", 10f, "Orfeu Negro", "2019-01-01", 1, "", "Eu, Alfonsina" },
                    { "9789898868541", "Susana Monteagudo", "", "9789898868541", "Português", 20f, "Orfeu Negro", "2019-01-01", 0, "", "História ilustrada do Rock" },
                    { "9789898868558", "Catarina Sobral", "", "9789898868558", "", 13f, "Orfeu Negro", "2019-01-01", 0, "", "Greve" },
                    { "9789898868596", "Erika Fischer Lichte", "", "9789898868596", "Português", 15f, "Orfeu Negro", "2019-01-01", 0, "", "Estética do performativo" },
                    { "9789898868619", "Javier Sáez-Castán", "", "9789898868619", "Português", 14f, "Orfeu Negro", "2019-01-01", 1, "", "MVSEVM" },
                    { "9789898868626", "Paul B. Preciado", "https://covers.openlibrary.org/b/isbn/9789898868626-L.jpg", "9789898868626", "Português", 17f, "Orfeu Negro", "2019-01-01", 1, "", "Manifesto contra-sexual" },
                    { "9789898868633", "Christian Robinson", "", "9789898868633", "Português", 10f, "Orfeu Negro", "2020-01-01", 0, "", "Outro" },
                    { "9789898868671", "Gonçalo Viana", "", "9789898868671", "Português", 15f, "Orfeu Negro", "2019-01-01", 1, "", "Troca-tintas" },
                    { "9789898868756", "", "", "9789898868756", "Português", 10f, "Orfeu Negro", "2020-01-01", 1, "", "História da virilidade: 2 – O triunfo da virilidade, o Século XIX" },
                    { "9789898868794", "Silvia Federici", "", "9789898868794", "Português", 22f, "Orfeu Negro", "2020-01-01", 1, "", "Calibã e a Bruxa: As mulheres, o corpo e a acumulação original" },
                    { "9789898868824", "Eduarda Lima", "", "9789898868824", "Português", 14f, "Orfeu Negro", "2020-01-01", 0, "", "O protesto" },
                    { "9789898868831", "Matthew Forsythe", "", "9789898868831", "Português", 15.9f, "Orfeu Negro", "2020-01-01", 1, "", "Pokko e o tambor" },
                    { "9789898868848", "Taro Gomi", "", "9789898868848", "Português", 13.5f, "Orfeu Negro", "2020-01-01", 1, "", "Todos fazemos cocó" },
                    { "9789898868855", "Christian Robinson", "", "9789898868855", "Português", 15f, "Orfeu Negro", "2020-01-01", 1, "", "És importante" },
                    { "9789898868923", "Simona Ciraolo", "", "9789898868923", "Português", 15f, "Orfeu Negro", "2021-01-01", 0, "", "Tímidos" },
                    { "9789898868947", "Taro Gomi", "", "9789898868947", "Português", 13.5f, "Orfeu Negro", "2021-01-01", 1, "", "Os meus amigos" },
                    { "9789898868954", "Gayatri Chakravorty Spivak", "", "9789898868954", "Português", 14f, "Orfeu Negro", "2021-01-01", 1, "", "Pode a subalterna tomar a palavra?" },
                    { "9789898868961", "Carl Einstein", "", "9789898868961", "Português", 15f, "Orfeu Negro", "2021-01-01", 1, "", "Escultura negra" },
                    { "9789898868978", "Issa Watanabe", "", "9789898868978", "Português", 14.9f, "Orfeu Negro", "2021-01-01", 1, "", "Migrantes" },
                    { "9789898872111", "Marcel Proust", "", "9789898872111", "Português", 17.9f, "E-Primatur", "2018-01-01", 0, "", "Contos completos e outros textos" },
                    { "9789898872241", "", "", "9789898872241", "Português", 22f, "E-Primatur", "2017-01-01", 1, "", "As mil e uma noites: 2" },
                    { "9789898872265", "Judite Teixeira", "", "9789898872265", "Português", 11.9f, "Livro B", "2018-01-01", 1, "", "Satânia: novelas, seguidas de De mim: conferência" },
                    { "9789898872302", "Thomas Edward Lawrence", "", "9789898872302", "Português", 24.9f, "E-Primatur", "2020-01-01", 0, "", "Os sete pilares da sabedoria" },
                    { "9789898872340", "Hermann Ungar", "", "9789898872340", "Português", 13.9f, "Livro B", "2020-01-01", 0, "", "Os mutilados" },
                    { "9789898872357", "", "", "9789898872357", "Português", 19.9f, "E-Primatur", "2017-01-01", 1, "", "As mil e uma noites: 3" },
                    { "9789898872371", "Thea Von Harbou", "", "9789898872371", "Português", 16.9f, "Livro B", "2021-01-01", 1, "", "Metrópolis" },
                    { "9789898872470", "", "", "9789898872470", "Português", 22f, "Letras Errantes", "2020-01-01", 0, "", "A dança dos ossos: antologia do conto gótico luso-brasileiro" },
                    { "9789898872661", "Maurice Blanchot", "", "9789898872661", "Português", 13.9f, "E-Primatur", "2021-01-01", 0, "", "Thomas, o obscuro" },
                    { "9789898872692", "Bernardo Santareno", "", "9789898872692", "Português", 24.9f, "E-Primatur", "2021-01-01", 1, "", "Obra completa: Teatro I" },
                    { "9789898872845", "Bernardo Santareno", "", "9789898872845", "Português", 24.9f, "E-Primatur", "2022-01-01", 1, "", "Obra completa: Teatro II" },
                    { "9789898881151", "", "", "9789898881151", "Português", 24.4f, "Ponto de Fuga", "2019-01-01", 0, "", "Antologia de poesia portuguesa erótica e satírica" },
                    { "9789898881526", "", "", "9789898881526", "Português", 24.4f, "Avesso", "2022-01-01", 0, "", "O tamanho do nosso sonho é difícil de descrever: antologia do homoerotismo na poesia portuguesa" },
                    { "9789898886606", "Jill Twiss", "", "9789898886606", "Português", 15f, "Cultura", "2018-01-01", 1, "", "Um dia na vida de Marlon Bundo" },
                    { "9789898892218", "Adelino Cunha", "", "9789898892218", "Português", 17.7f, "Desassossego", "2018-01-01", 1, "", "Júlio de Melo Fogaça" },
                    { "9789898902160", "Anna Klobucka", "", "9789898902160", "Português", 18f, "Documenta", "2018-01-01", 1, "", "O mundo gay de António Botto" },
                    { "9789898902283", "Golgona Anghel", "", "9789898902283", "Português", 11f, "Documenta", "2018-01-01", 0, "", "A forma custa caro" },
                    { "9789898902337", "Vasco Araújo", "", "9789898902337", "Português", 18f, "Documenta ;", "2018-01-01", 2, "", "Notebook: La morte del desiderio" },
                    { "9789898902436", "Alexandre Melo", "", "9789898902436", "Português", 12f, "Atelier-Museu Júlio Pomar", "2018-01-01", 3, "", "Cúmplice dos artistas: Conversas" },
                    { "9789898902603", "", "", "9789898902603", "", 15f, "", "", 1, "", "A mulher 100 cabeças" },
                    { "9789898902665", "", "", "9789898902665", "Português", 18f, "Sistema Solar", "2019-01-01", 1, "", "Ameríndias: Performances do cinema indígena no Brasil" },
                    { "9789898902719", "José Bértolo", "", "9789898902719", "Português", 20f, "Documenta", "2019-01-01", 1, "", "Sobreimpressões: Leituras de filmes" },
                    { "9789898917997", "Adam Silvera", "", "9789898917997", "Português", 18.79f, "Topseller", "2019-01-01", 1, "", "No final, morrem os dois" },
                    { "9789898973016", "THOMAS MORE", "", "9789898973016", "", 14.9f, "BookBuilders", "Sep 20, 2019", 1, "", "Utopia" },
                    { "9789898973375", "Frantz Fanon", "", "9789898973375", "Português", 23.9f, "Letras Errantes", "2021-01-01", 0, "", "Escritos políticos e psiquiátricos" },
                    { "9789898979377", "Faridah Àbiké-Íyímidé", "", "9789898979377", "Português", 19.5f, "Desrotina", "2022-01-01", 0, "", "Ás de Espadas" },
                    { "9789898980151", "Jorge Silva", "", "9789898980151", "Português", 18f, "Arranha-Céus ;", "2021-01-01", 0, "", "Eva: Ilustradoras portuguesas do século XX" },
                    { "9789899006317", "Joacine Katar Moreira", "https://covers.openlibrary.org/b/isbn/9789899006317-L.jpg", "9789899006317", "Português", 16f, "Sistema Solar", "2020-01-01", 1, "", "Matchundadi: Género, Performance e Violência Política na Guiné-Bissau" },
                    { "9789899006447", "Vasco Araújo", "", "9789899006447", "Português", 22f, "Universidade Católica Portuguesa - School of Arts, Escola das Artes - CITAR ;", "2021-01-01", 1, "", "Pathosformel" },
                    { "9789899006515", "Suely Rolnik", "", "9789899006515", "Português", 15f, "Sistema Solar", "2020-01-01", 2, "", "Esferas da Insurreição: Notas para uma vida não chulada" },
                    { "9789899006539", "Alberto Tota", "", "9789899006539", "Português", 18f, "Sistema Solar", "2022-01-01", 1, "", "Recordações d'uma colonial: Memorias da preta Fernanda" },
                    { "9789899006584", "Mário Cesariny", "", "9789899006584", "Português", 24f, "Documenta", "2020-01-01", 2, "", "Uma última pergunta: Entrevistas com Mário Cesariny" },
                    { "9789899006591", "José Bértolo", "", "9789899006591", "Português", 20f, "Documenta", "2020-01-01", 1, "", "Espectros do cinema: Manoel de Oliveira e João Pedro Rodrigues" },
                    { "9789899006652", "João Pedro Vale", "", "9789899006652", "Português", 16f, "Sistema Solar", "2020-01-01", 2, "", "Impasse" },
                    { "9789899006768", "Diana Niepce", "", "9789899006768", "Português", 16f, "Sistema Solar", "2021-01-01", 1, "", "Anda, Diana: Diário ficcional" },
                    { "9789899006850", "", "", "9789899006850", "", 14f, "", "", 1, "", "Erotika Biblion" },
                    { "9789899014046", "Fernanda Botelho", "", "9789899014046", "Português", 17f, "Abysmo", "2020-01-01", 1, "", "Lourenço é nome de jogral" },
                    { "9789899027961", "Madeline Miller", "", "9789899027961", "Português", 18.9f, "Minotauro", "2022-01-01", 0, "", "O canto de Aquiles" },
                    { "9789899039216", "Alice Oseman", "", "9789899039216", "Português", 17.5f, "Cultura", "2021-01-01", 1, "", "Heartstopper: 1 – Rapaz conhece rapaz" },
                    { "9789899039612", "Alice Oseman", "", "9789899039612", "Português", 17.5f, "Cultura", "2021-01-01", 1, "", "Heartstopper: 2 – O nosso segredo" },
                    { "9789899039858", "Alice Oseman", "", "9789899039858", "Português", 18.5f, "Cultura", "2021-01-01", 0, "", "Heartstopper: 3 – Uma viagem a Paris" },
                    { "9789899061019", "Isabel Minhós Martins", "", "9789899061019", "Português", 12.5f, "Planeta Tangerina", "2021-01-01", 1, "", "Tudo tão grande" },
                    { "9789899061026", "Isabel Minhós Martins", "", "9789899061026", "Português", 12.5f, "Planeta Tangerina", "2021-01-01", 2, "", "Daqui ali" },
                    { "9789899061033", "Isabel Minhós Martins", "", "9789899061033", "Português", 24.6f, "Planeta Tangerina", "2021-01-01", 0, "", "Como ver coisas invisíveis" },
                    { "9789899061040", "Richard Zimler", "", "9789899061040", "Português", 12.5f, "Planeta Tangerina", "2021-01-01", 1, "", "Dança quando chegares ao fim" },
                    { "9789899061057", "Joana Estrela", "", "9789899061057", "Português", 18.9f, "Planeta Tangerina", "2021-01-01", 1, "", "Pardalita" },
                    { "9789899061064", "Isabel Minhós Martins", "", "9789899061064", "Português", 15.9f, "Planeta Tangerina", "2022-01-01", 1, "", "Apanhar ar, apanhar sol" },
                    { "9789899061071", "Ana Pessoa", "", "9789899061071", "Português", 12.5f, "Planeta Tangerina", "2022-01-01", 0, "", "O gnu e o texugo: Está a chover" },
                    { "9789899061088", "Ana Pessoa", "", "9789899061088", "Português", 12.5f, "Planeta Tangerina", "2022-01-01", 1, "", "A luz é grande" },
                    { "9789899061095", "Henrique Coser Moreira", "", "9789899061095", "Português", 12.5f, "Planeta Tangerina", "2022-01-01", 0, "", "O primeiro dia" },
                    { "9789899061101", "Inês Viegas Oliveira", "", "9789899061101", "Português", 13.9f, "Planeta Tangerina", "2022-01-01", 0, "", "O duelo" },
                    { "9789899061118", "Ana Pessoa", "", "9789899061118", "Português", 12.5f, "Planeta Tangerina", "2022-01-01", 2, "", "O que é isto?" },
                    { "9789899061125", "Joana Estrela", "", "9789899061125", "Português", 12.9f, "Planeta Tangerina", "2022-01-01", 2, "", "Miau!" },
                    { "9789899061132", "Madalena Matoso", "", "9789899061132", "Português", 15f, "Planeta Tangerina", "2022-01-01", 1, "", "Tudo o que quiseres" },
                    { "9789899061149", "Noemi Vola", "", "9789899061149", "Português", 17f, "Planeta Tangerina", "2023-01-01", 2, "", "Se choras como uma fonte" },
                    { "9789899061156", "Ana Pessoa", "", "9789899061156", "Português", 22.9f, "Planeta Tangerina", "2023-01-01", 0, "", "Mar negro" },
                    { "9789899061170", "Ana Pessoa", "", "9789899061170", "Português", 17.9f, "Planeta Tangerina", "2023-01-01", 0, "", "Por exemplo, uma rosa" },
                    { "9789899061187", "", "", "9789899061187", "", 17.9f, "", "", 0, "", "Eu quero um cão (e pouco importa qual)" },
                    { "9789899061194", "Isabel Minhós Martins", "", "9789899061194", "Português", 13.9f, "Planeta Tangerina", "2023-01-01", 1, "", "O ponto em que estamos" },
                    { "9789899061200", "", "", "9789899061200", "", 16.9f, "", "", 2, "", "Gato comum" },
                    { "9789899061217", "Henrique Coser Moreira", "", "9789899061217", "Português", 13.9f, "Planeta Tangerina", "2024-01-01", 1, "", "O Sr. Gato Mágico" },
                    { "9789899061231", "", "", "9789899061231", "", 13.9f, "", "", 1, "", "Dentro da tenda" },
                    { "9789899061248", "", "", "9789899061248", "", 13.9f, "", "", 1, "", "Todos juntos" },
                    { "9789899071001", "Marcos Farina", "", "9789899071001", "Português", 14.5f, "Orfeu negro", "2021-01-01", 1, "", "Tu e eu e todos" },
                    { "9789899071056", "Christian Bruel", "", "9789899071056", "Português", 14.5f, "Orfeu Negro", "2021-01-01", 1, "", "A história da Júlia e da sua sombra de menino" },
                    { "9789899071148", "Luci Gutiérrez", "", "9789899071148", "Português", 19.9f, "Orfeu Negro", "2021-01-01", 0, "", "Manual de autodefesa" },
                    { "9789899071155", "Virginie Despentes", "", "9789899071155", "Português", 16f, "Orfeu Negro", "2021-01-01", 2, "", "Teoria King Kong" },
                    { "9789899071179", "Leroi Jones", "", "9789899071179", "Português", 17f, "Orfeu Negro", "2021-01-01", 1, "", "Música negra" },
                    { "9789899071223", "Stéphane Audoin-Rouzeau", "", "9789899071223", "Português", 20f, "Orfeu Negro", "2022-01-01", 1, "", "História da virilidade: 3 – A virilidade em crise? Séculos XX-XXI" },
                    { "9789899071230", "Grada Kilomba", "", "9789899071230", "Português", 18f, "Orfeu Negro", "2022-01-01", 2, "", "Memórias da plantação: Episódios de racismo quotidiano" },
                    { "9789899071278", "Catarina Sobral", "", "9789899071278", "Português", 15f, "Orfeu Negro", "2022-01-01", 1, "", "Toi Toi Toi" },
                    { "9789899071308", "Donna Haraway", "", "9789899071308", "Português", 17f, "Orfeu Negro", "2022-01-01", 1, "", "Um manifesto ciborgue / O manifesto das espécies de companhia" },
                    { "9789899071322", "Marie-José Mondzain", "", "9789899071322", "Português", 17f, "Orfeu Negro", "2022-01-01", 1, "", "K como Kolónia: Kafka e a descolonização do imaginário" },
                    { "9789899071421", "Bell Hooks", "", "9789899071421", "Português", 18f, "Orfeu Negro", "2022-01-01", 0, "", "Teoria feminista: Da margem ao centro" },
                    { "9789899071452", "Jean Dubuffet", "", "9789899071452", "Português", 10f, "Orfeu Negro", "2022-01-01", 1, "", "Asfixiante cultura" },
                    { "9789899071469", "Ken Loach", "", "9789899071469", "Português", 10f, "Orfeu Negro", "2022-01-01", 1, "", "Diálogo sobre arte e política" },
                    { "9789899071506", "Maggie Nelson", "", "9789899071506", "Português", 16f, "Orfeu Negro", "2022-01-01", 1, "", "Argonautas" },
                    { "9789899071575", "Françoise Vergès", "", "9789899071575", "Português", 14f, "Orfeu Negro", "2023-01-01", 1, "", "Um feminismo decolonial" },
                    { "9789899071629", "Angela Y. Davis", "", "9789899071629", "Português", 18f, "Orfeu Negro", "2023-01-01", 2, "", "Mulheres, raça e classe" },
                    { "9789899071711", "Judith Butler", "", "9789899071711", "Português", 22f, "Orfeu Negro", "2023-01-01", 2, "", "Corpos que contam" },
                    { "9789899071742", "", "", "9789899071742", "", 27f, "", "", 1, "", "Herstory: Uma história ilustrada das mulheres" },
                    { "9789899071759", "Bell Hooks", "", "9789899071759", "Português", 18f, "Orfeu Negro", "2023-01-01", 2, "", "Tudo do amor" },
                    { "9789899071797", "Marina Garcés", "https://covers.openlibrary.org/b/isbn/9789899071797-L.jpg", "9789899071797", "Português", 10f, "Orfeu Negro", "2023-01-01", 1, "", "Novo iluminismo radical" },
                    { "9789899071803", "Georgina Orellano", "", "9789899071803", "Português", 17f, "Orfeu Negro", "2023-01-01", 1, "", "Puta feminista" },
                    { "9789899071827", "Audre Lorde", "", "9789899071827", "Português", 18f, "Orfeu Negro", "2023-01-01", 3, "", "Irmã marginal" },
                    { "9789899071834", "", "", "9789899071834", "", 15f, "", "", 1, "", "O camaleão que se achava feio" },
                    { "9789899071865", "Anne Herbauts", "", "9789899071865", "Português", 15f, "Orfeu Negro", "2024-01-01", 1, "", "Quando é que a Hadda volta?" },
                    { "9789899071919", "Judith Butler", "", "9789899071919", "Português", 15f, "Orfeu Negro", "2024-01-01", 1, "", "A pretensão de Antígona" },
                    { "9789899071926", "", "", "9789899071926", "", 15f, "", "", 1, "", "A gigantesca pequena coisa" },
                    { "9789899071933", "Audre Lorde", "", "9789899071933", "Português", 22f, "Orfeu Negro", "2024-01-01", 3, "", "Zami: Assim reescrevo o meu nome" },
                    { "9789899071971", "Françoise Vergès", "", "9789899071971", "Português", 19f, "Orfeu Negro", "2024-01-01", 12, "", "Decolonizar o museu: Programa de desordem absoluta" },
                    { "9789899096448", "Alice Oseman", "", "9789899096448", "Português", 18.5f, "Cultura", "2022-01-01", 0, "", "Heartstopper: 4 – Muito mais do que palavras" },
                    { "9789899096707", "Alexis Hall", "", "9789899096707", "Português", 20.5f, "Desrotina", "2022-01-01", 1, "", "Procura-se namorado" },
                    { "9789899096912", "Alice Oseman", "", "9789899096912", "Português", 15f, "Desrotina", "2022-01-01", 2, "", "Nick e Charlie" },
                    { "9789899096967", "Alice Oseman", "", "9789899096967", "Português", 20.5f, "Desrotina", "2022-01-01", 0, "", "Sem amor" },
                    { "9789899105065", "Pier Paolo Pasolini", "", "9789899105065", "Português", 16f, "VS.", "2022-01-01", 1, "", "Entrevistas corsárias sobre a política e sobre a vida" },
                    { "9789899105119", "Ramón Gómez de la Serna", "", "9789899105119", "Português", 18f, "VS.", "2022-01-01", 2, "", "A quinta de Palmyra" },
                    { "9789899105126", "Manuel da Silva Ramos", "", "9789899105126", "Português", 20f, "V.S.", "2023-01-01", 1, "", "Tuga" },
                    { "9789899105188", "Linda Nochlin", "", "9789899105188", "Português", 17f, "VS.", "2023-01-01", 2, "", "Porque não houve grandes mulheres artistas?" },
                    { "9789899105225", "", "", "9789899105225", "", 13f, "", "", 1, "", "Discurso sobre o colonialismo, seguido de Discurso sobre a negritude" },
                    { "9789899105348", "", "", "9789899105348", "", 12f, "", "", 0, "", "A flor da praia" },
                    { "9789899124127", "Jean Genet", "", "9789899124127", "Português", 18.9f, "Minotauro", "2022-01-01", 1, "", "Diário do ladrão" },
                    { "9789899124844", "William Burroughs", "", "9789899124844", "Português", 17.9f, "Minotauro", "2023-01-01", 2, "", "Junky" },
                    { "9789899130098", "Bernardo Santareno", "", "9789899130098", "Português", 25.9f, "E-Primatur", "2023-01-01", 1, "", "Obra completa: Teatro III" },
                    { "9789899130135", "Gustave Flaubert", "", "9789899130135", "Português", 18.9f, "E-Primatur", "2023-01-01", 2, "", "Bouvard e Pécuchet" },
                    { "9789899150416", "Alice Oseman", "", "9789899150416", "Português", 18.5f, "Desrotina", "2023-01-01", 0, "", "Solitário" },
                    { "9789899150454", "Torrey Peters", "", "9789899150454", "Português", 18.5f, "Aurora", "2023-01-01", 0, "", "Destransição, baby" },
                    { "9789899150690", "Kacen Callender", "https://covers.openlibrary.org/b/isbn/9789899150690-L.jpg", "9789899150690", "Português", 18.5f, "Desrotina", "2023-01-01", 1, "", "Felix para sempre" },
                    { "9789899159075", "William Burroughs", "", "9789899159075", "Português", 19.9f, "Minotauro", "2023-01-01", 0, "", "Almoço nu" },
                    { "9789899225015", "Paul Valéry", "", "9789899225015", "Português", 10f, "Orfeu Negro", "2024-01-01", 2, "", "O governo da máquina" },
                    { "9789899225022", "P. Feijó", "", "9789899225022", "Português", 10f, "Orfeu Negro", "2024-01-01", 2, "", "Episódios de fantasia & violência" },
                    { "9789899556508", "RoseLee Goldberg", "", "9789899556508", "Português", 15f, "Orfeu Negro", "2012-01-01", 1, "", "A arte da performance: Do futurismo ao presente" },
                    { "9789899556539", "Peter Newell", "", "9789899556539", "Português", 15f, "Orfeu Negro", "2009-01-01", 0, "", "O livro inclinado" },
                    { "9789899556584", "Miguel Murugarren", "", "9789899556584", "Português", 14f, "Orfeu Negro", "2009-01-01", 1, "", "Animalário universal do Professor Revillod" },
                    { "9789899735705", "", "", "9789899735705", "", 16.95f, "", "", 2, "", "Apocalipse do Apóstolo S. João" },
                    { "9789899735712", "", "", "9789899735712", "", 16.95f, "", "", 2, "", "Sermão de Quarta-feira de Cinza escrito pelo Padre António Vieira" },
                    { "9789899735729", "", "", "9789899735729", "", 16.95f, "", "", 2, "", "Dez canções de Luís de Camões" },
                    { "9789899735736", "Teresa Forcades I Villa", "", "9789899735736", "Português", 15.9f, "Presente", "2013-01-01", 0, "", "A teologia feminista na História" },
                    { "9789899736283", "René Daumal", "", "9789899736283", "Português", 15f, "Dois Dias", "2016-01-01", 1, "", "A grande bebedeira" },
                    { "9789899771970", "Alexandre Melo", "", "9789899771970", "Português", 13f, "Documenta", "2012-01-01", 1, "", "Império" },
                    { "9789899831155", "", "", "9789899831155", "", 15f, "", "", 3, "", "Blue Kida" },
                    { "9789899847033", "Catarina Sobral", "", "9789899847033", "Português", 13.5f, "Pato Lógico", "2014-01-01", 1, "", "Vazio" },
                    { "9789899892170", "", "", "9789899892170", "", 12.9f, "", "", 1, "", "Palavras bonitas sobre contas" },
                    { "9789899943858", "August Strindberg", "", "9789899943858", "Português", 19.9f, "E-Primatur", "2015-01-01", 0, "", "O salão vermelho" },
                    { "9789899954212", "Patrick White", "", "9789899954212", "Português", 22f, "E-Primatur", "2016-01-01", 1, "", "Voss" },
                    { "9789899954298", "Felix Salten", "", "9789899954298", "Português", 14.9f, "E-Primatur", "2016-01-01", 0, "", "Bambi: uma vida nos bosques" },
                    { "9789899967427", "Julie Maroh", "", "9789899967427", "Português", 19.95f, "Geomais", "2016-01-01", 1, "", "O azul é uma cor quente" },
                    { "9789899967717", "Ricardo Marques", "", "9789899967717", "Português", 8f, "Não (Edições)", "2016-01-01", 0, "", "Ruinenlust" },
                    { "9789899967779", "Sónia Baptista", "", "9789899967779", "Português", 15f, "Não (Edições)", "2017-01-01", 1, "", "Querer do corpo, peso (e outros textos)" },
                    { "9789899971059", "Bruno Schulz", "", "9789899971059", "Português", 18f, "Tédio", "2019-01-01", 1, "", "Sanatório sob o signo da clepsidra" },
                    { "9789899971561", "", "", "9789899971561", "Português", 22f, "E-Primatur", "2017-01-01", 0, "", "As mil e uma noites: 1" },
                    { "9789899975910", "Virginia Woolf", "", "9789899975910", "Português", 18.8f, "Ponto de Fuga", "2017-01-01", 0, "", "Momentos de vida" },
                    { "9789899981409", "João Alfacinha da Silva", "", "9789899981409", "Português", 12f, "Maldoror", "2017-01-01", 0, "", "Cuidado com os rapazes e outras histórias" },
                    { "9789899981423", "António Cândido Franco", "", "9789899981423", "Português", 13f, "Maldoror ;", "2017-01-01", 1, "", "Luiz Pacheco essencial" },
                    { "9789899981461", "Antonin Artaud", "", "9789899981461", "Português", 15f, "Maldoror", "2018-01-01", 0, "", "O teatro e o seu duplo" },
                    { "9789899992153", "Marguerite Duras", "", "9789899992153", "Português", 7f, "Artistas Unidos", "2018-01-01", 0, "", "O teatro da amante inglesa" },
                    { "9789899994409", "Samuel Taylor Coleridge", "", "9789899994409", "Português", 12.8f, "Saguão", "2017-01-01", 2, "", "A balada do velho marinheiro" },
                    { "9789899994430", "Giacomo Leopardi", "", "9789899994430", "Português", 14f, "Saguão", "2018-01-01", 2, "", "Pensamentos" },
                    { "9789899995000", "Anne Carson", "", "9789899995000", "Português", 15f, "Não (edições)", "2017-01-01", 1, "", "Autobiografia do vermelho (um romance em verso)" },
                    { "9789899995062", "José António Almeida", "", "9789899995062", "Português", 16f, "Não (Edições)", "2019-01-01", 1, "", "A angústia da azeitona antes de se transformar em luz" },
                    { "9789899995079", "Anne Carson", "", "9789899995079", "Português", 15f, "Não (edições)", "2019-01-01", 0, "", "A beleza do marido (um ensaio ficcional em 29 tangos)" },
                    { "9789899995086", "Ricardo Marques", "", "9789899995086", "Português", 12f, "Não (edições)", "2019-01-01", 0, "", "Lucidez" },
                    { "9789899997448", "Salete Tavares", "", "9789899997448", "Português", 13f, "Tigre de Papel", "2019-01-01", 2, "", "irrar" },
                    { "9789899997455", "Salete Tavares", "", "9789899997455", "Português", 13f, "Tigre de Papel", "2019-01-01", 3, "", "Outro Outro" },
                    { "9789899997479", "Salete Tavares", "", "9789899997479", "Português", 13f, "Tigre de Papel", "2019-01-01", 1, "", "O Kágado / Baile Mecânico / Anonimatógrafo" },
                    { "9789899997493", "Salete Tavares", "", "9789899997493", "Português", 14.95f, "Tigre de Papel", "2020-01-01", 0, "", "Lex Icon" },
                    { "9789899999817", "Susa Monteiro", "", "9789899999817", "Português", 13.5f, "Pato Lógico", "2018-01-01", 1, "", "Sonho" },
                    { "9791095630661", "", "", "9791095630661", "", 15f, "", "", 1, "", "Un manifeste gay" },
                    { "9798667572978", "", "", "9798667572978", "", 12f, "", "", 1, "", "The House of the Tree of Sores" },
                    { "9798886200171", "Sam Szabo", "", "9798886200171", "inglês", 33.5f, "Silver Sprocket", "2023", 0, "", "Enlightened Transsexual Comix" },
                    { "9798886200225", "Leo Fox", "", "9798886200225", "inglês", 36f, "Silver Sprocket", "2023", 0, "", "Prokaryote Season" },
                    { "9798886200430", "Leo Fox", "", "9798886200430", "inglês", 15f, "Silver Sprocket", "2024", 1, "", "My Body Unspooling" },
                    { "9798891700772", "", "", "9798891700772", "", 27.8f, "", "", 2, "", "The Holy Hour: An Anthology on Sex Work, Magic, and the Divine" },
                    { "9798987019979", "Oliver Radclyffe", "", "9798987019979", "inglês", 29.5f, "Unbound Edition Press", "2023", 1, "", "Adult Human Male" },
                    { "9798989378067", "McKenzie Wark", "", "9798989378067", "inglês", 21.4f, "Hanuman Editions", "2024", 2, "", "Life Story" },
                    { "9899898866219", "", "", "9899898866219", "", 17.9f, "", "", 0, "", "Obras completas: 1 – Tanta gente, Mariana / As palavras poupadas" },
                    { "alambiquemouracruzes", "", "", "alambiquemouracruzes", "", 10f, "", "", 0, "", "Cruzes" },
                    { "anfisbenatique", "", "", "anfisbenatique", "", 4f, "", "", 0, "", "O tique" },
                    { "antoniomv", "", "", "antoniomv", "", 20f, "", "", 1, "", "MV" },
                    { "avernoargel33", "", "", "avernoargel33", "", 10f, "", "", 0, "", "33 rotações" },
                    { "avernoargelinferno", "", "", "avernoargelinferno", "", 10f, "", "", 0, "", "Fui ao inferno e lembrei-me de ti" },
                    { "avernolareopais", "", "", "avernolareopais", "", 12f, "", "", 1, "", "Os meus pais: Romeu e Julieta" },
                    { "avernopivaparanóia", "", "", "avernopivaparanóia", "", 15f, "", "", 2, "", "Paranóia" },
                    { "avernorilkenotas", "", "", "avernorilkenotas", "", 10f, "", "", 0, "", "Notas sobre a melodia das coisas" },
                    { "barcobernsteincavalos", "", "", "barcobernsteincavalos", "", 20f, "", "", 3, "", "Todos os cavalos do rei" },
                    { "barcoburroughsgeração", "", "", "barcoburroughsgeração", "", 10f, "", "", 2, "", "A geração invisível" },
                    { "barcocorsogasolina", "", "", "barcocorsogasolina", "", 15f, "", "", 1, "", "Gasolina" },
                    { "barcodeleuzeproust", "", "", "barcodeleuzeproust", "", 22f, "", "", 2, "", "Proust e os signos" },
                    { "barcodomingoscarmes", "", "", "barcodomingoscarmes", "", 27f, "", "", 1, "", "Urbe Sub Rosa: Carmes 1972-2021" },
                    { "barcohunckediário", "", "", "barcohunckediário", "", 20f, "", "", 0, "", "O diário de Huncke" },
                    { "barcolamborginifiorde", "", "", "barcolamborginifiorde", "", 20f, "", "", 2, "", "O fiorde" },
                    { "barcoleviliberdade", "", "", "barcoleviliberdade", "", 18f, "", "", 1, "", "Medo da liberdade" },
                    { "barcopasolinipoeta", "", "", "barcopasolinipoeta", "", 20f, "", "", 1, "", "Who Is Me: Poeta das cinzas" },
                    { "barcoricarddeus", "", "", "barcoricarddeus", "", 17f, "", "", 2, "", "Deus de revólver" },
                    { "barcovestrinivirtudes", "", "", "barcovestrinivirtudes", "", 20f, "", "", 3, "", "Poucas virtudes / Cidadão valente" },
                    { "barcovischertrespasse", "", "", "barcovischertrespasse", "", 18f, "", "", 2, "", "Trespasse instantâneo do cérebro: Um romance de inquietante alta rotação" },
                    { "barcowalkerpoemas", "", "", "barcowalkerpoemas", "", 19f, "", "", 2, "", "Poemas escolhidos" },
                    { "barcowilsonniilismo", "", "", "barcowilsonniilismo", "", 17f, "", "", 0, "", "O novo niilismo" },
                    { "barcowojnarowiczmemórias", "", "", "barcowojnarowiczmemórias", "", 30f, "", "", 2, "", "Memórias com cheiro a gasolina" },
                    { "belamonstrohatherlymestre", "", "", "belamonstrohatherlymestre", "", 5f, "", "", 0, "", "O mestre" },
                    { "bestiáriojoaquimpoesia", "", "", "bestiáriojoaquimpoesia", "", 38f, "", "", 1, "", "Poesia portuguesa contemporânea" },
                    { "biakostadhab", "", "", "biakostadhab", "", 20f, "", "", 3, "", "Dog Horse Apple Banana" },
                    { "bl", "", "", "bl", "", 424f, "", "", 0, "", "Bairro dos Livros" },
                    { "bl1", "", "", "bl1", "", 159f, "", "", 0, "", "Luís Miguel Nava (Viseu)" },
                    { "bl2", "", "", "bl2", "", 243.8f, "", "", 0, "", "Agustina Bessa-Luís (Porto)" },
                    { "bl3", "", "", "bl3", "", 159f, "", "", 0, "", "Raquel Patriarca e Rafaela Jacinto (Maia)" },
                    { "bonnevillecâmara", "", "", "bonnevillecâmara", "", 15f, "", "", 4, "", "Câmara escura" },
                    { "bonnevilleciborgue", "", "", "bonnevilleciborgue", "", 20f, "", "", 1, "", "Lamento do ciborgue" },
                    { "bonnevillecisne", "", "", "bonnevillecisne", "", 20f, "", "", 1, "", "Dissecação de um cisne" },
                    { "bonnevillecorpo", "", "", "bonnevillecorpo", "", 10f, "", "", 2, "", "Recuperar o corpo" },
                    { "bonnevillejerome", "", "", "bonnevillejerome", "", 20f, "", "", 2, "", "Jérôme, Olivier et moi" },
                    { "bonnevillesantidade", "", "", "bonnevillesantidade", "", 15f, "", "", 0, "", "Ensaios de santidade" },
                    { "carinhasimprudente", "", "", "carinhasimprudente", "", 12f, "", "", 4, "", "Imprudente luto" },
                    { "cassandrariosmulheres", "", "", "cassandrariosmulheres", "", 5f, "", "", 0, "", "As mulheres dos cabelos de metal (Usado)" },
                    { "cassandrariosmutreta", "", "", "cassandrariosmutreta", "", 7.5f, "", "", 0, "", "Mutreta (Usado)" },
                    { "cavolotarotfuego", "", "", "cavolotarotfuego", "", 16f, "", "", 1, "", "Tarot del Fuego" },
                    { "contracapapoesiaárabe", "", "", "contracapapoesiaárabe", "", 6f, "", "", 0, "", "Um árabe é um árabe é um árabe, um árabe: Breve antologia de poesia árabe" },
                    { "contracapapoesiabrasileira", "", "", "contracapapoesiabrasileira", "", 8f, "", "", 0, "", "Um Brasil ainda em chamas: Antologia de poesia brasileira contemporânea" },
                    { "contracapapoesiadinamarquesa", "", "", "contracapapoesiadinamarquesa", "", 9f, "", "", 0, "", "Os teus lábios a tua língua: antologia de poesia dinamarquesa" },
                    { "contracapapoesiafinlandesa", "", "", "contracapapoesiafinlandesa", "", 9f, "", "", 1, "", "O mundo adormecido espera impaciente: antologia de poesia finlandesa" },
                    { "contracapapoesiafrancesa", "", "", "contracapapoesiafrancesa", "", 10f, "", "", 1, "", "Sonhador definitivo e perpétua insónia: Uma antologia de poemas surrealistas escritos em língua francesa" },
                    { "contracapapoesiahispanoamericana", "", "", "contracapapoesiahispanoamericana", "", 8f, "", "", 1, "", "Iluminação do eu: Antologia de poesia hispano-americana" },
                    { "contracapapoesiaislandesa", "", "", "contracapapoesiaislandesa", "", 9f, "", "", 1, "", "Pelos nossos corações passa a linha de fogo: Antologia de poesia islandesa" },
                    { "contracapapoesiaitaliana", "", "", "contracapapoesiaitaliana", "", 8f, "", "", 3, "", "Um pouco do meu sangue: Antologia de poesia italiana" },
                    { "contracapapoesianorteamericana", "", "", "contracapapoesianorteamericana", "", 8f, "", "", 0, "", "Trocando dólares por cêntimos: Alguma poesia norte-americana" },
                    { "contracapapoesianorueguesa", "", "", "contracapapoesianorueguesa", "", 11f, "", "", 2, "", "E nenhuma vertigem nos afecta: antologia de poesia norueguesa" },
                    { "contracapapoesiapalestiniana", "", "", "contracapapoesiapalestiniana", "", 9f, "", "", 0, "", "As pedras têm entranhas: Antologia de poemas palestinianos" },
                    { "contracapapoesiaportuguesa", "", "", "contracapapoesiaportuguesa", "", 8f, "", "", 1, "", "Transversões: Poemas reescritos em português" },
                    { "contracapapoesiaprovençal", "", "", "contracapapoesiaprovençal", "", 8f, "", "", 2, "", "Trobairitz: Vozes femininas da poesia provençal" },
                    { "contracapapoesiarussa", "", "", "contracapapoesiarussa", "", 10f, "", "", 1, "", "É por isso que a alegria é mais alta: poemas russos dos séculos XX e XXI" },
                    { "contracapapoesiasueca", "", "", "contracapapoesiasueca", "", 8f, "", "", 1, "", "O destino da árvore é transformar-se em papel: Antologia de poesia sueca" },
                    { "contracapapoesiasuica", "", "", "contracapapoesiasuica", "", 9f, "", "", 2, "", "Descida brusca de temperatura: Alguma poesia suíça" },
                    { "correioenvio", "", "", "correioenvio", "", 1f, "", "", 15, "", "C." },
                    { "costaflesh", "", "", "costaflesh", "", 15f, "", "", 0, "", "Tired flesh" },
                    { "cruzine", "", "", "cruzine", "", 7f, "", "", 0, "", "1. Science / 2. Transsexuals / 3. Fire / 4. Emobots" },
                    { "cuteloalmeidajogo", "", "", "cuteloalmeidajogo", "", 8f, "", "", 0, "", "O jogo mais perigoso" },
                    { "cutelobrainardlembro", "", "", "cutelobrainardlembro", "", 15f, "", "", 2, "", "Lembro-me" },
                    { "cutelogiorgiomemorial", "", "", "cutelogiorgiomemorial", "", 10f, "", "", 1, "", "Passagens de um memorial" },
                    { "daysoflove2", "", "", "daysoflove2", "", 12f, "", "", 0, "", "Days of Love: 2" },
                    { "daysoflove3", "", "", "daysoflove3", "", 12f, "", "", 0, "", "Days of Love: 3" },
                    { "destraussguyotatéden", "", "", "destraussguyotatéden", "", 19f, "", "", 1, "", "Éden, Éden, Éden" },
                    { "destrausswarkmanifesto", "", "", "destrausswarkmanifesto", "", 17f, "", "", 2, "", "Um manifesto hacker" },
                    { "doudabonnevillepessoal", "", "", "doudabonnevillepessoal", "", 15f, "", "", 1, "", "O pessoal é político" },
                    { "doudadiacovninguem", "", "", "doudadiacovninguem", "", 8f, "", "", 1, "", "Ninguém vai poder dizer que eu não disse" },
                    { "doudadomeneckmanual", "", "", "doudadomeneckmanual", "", 8f, "", "", 0, "", "Manual para melodrama" },
                    { "doudafreitasrilke", "", "", "doudafreitasrilke", "", 10f, "", "", 0, "", "Rilke Shake" },
                    { "doudahalpernvazios", "", "", "doudahalpernvazios", "", 10f, "", "", 7, "", "Tocar vazios no sentido" },
                    { "doudahansencantos", "", "", "doudahansencantos", "", 10f, "", "", 0, "", "cantos de estima" },
                    { "doudajacintoregime", "", "", "doudajacintoregime", "", 12f, "", "", 2, "", "Regime" },
                    { "doudakeiserurano", "", "", "doudakeiserurano", "", 10f, "", "", 0, "", "Mistérios da castração de Úrano" },
                    { "doudaloureirobarreiro", "", "", "doudaloureirobarreiro", "", 10f, "", "", 0, "", "Confissões de um exilado no Barreiro" },
                    { "doudamarqueshomo", "", "", "doudamarqueshomo", "", 8f, "", "", 1, "", "Homo Sapiens (Diário de uma drag)" },
                    { "doudamarqueslinha", "", "", "doudamarqueslinha", "", 12f, "", "", 0, "", "Linha de rebentação" },
                    { "doudamesquitaacordo", "", "", "doudamesquitaacordo", "", 10f, "", "", 1, "", "Sempre que acordo" },
                    { "doudapinacoelhotudo", "", "", "doudapinacoelhotudo", "", 10f, "", "", 1, "", "Tudo é um nada novo: Textos para espectáculos na era da economia da atenção" },
                    { "doudarafaelamá", "", "", "doudarafaelamá", "", 12f, "", "", 0, "", "Fiz uma coisa má" },
                    { "doudargbmonstres", "", "", "doudargbmonstres", "", 10f, "", "", 0, "", "Querides monstres" },
                    { "doudariveradesdominios", "", "", "doudariveradesdominios", "", 8f, "", "", 2, "", "Desdomínios" },
                    { "doudateodosionova", "", "", "doudateodosionova", "", 8f, "", "", 1, "", "Super nova" },
                    { "doudawienerspoemas", "", "", "doudawienerspoemas", "", 8f, "", "", 1, "", "Poemas do Hotel Wentley" },
                    { "doudoteodosiogorila", "", "", "doudoteodosiogorila", "", 8f, "", "", 0, "", "Super gorila" },
                    { "eagenetquerelle", "", "", "eagenetquerelle", "", 7.5f, "", "", 0, "", "Querelle: Amar e matar (Usado)" },
                    { "enfermariamantovaniesqueceu", "", "", "enfermariamantovaniesqueceu", "", 10f, "", "", 0, "", "Você esqueceu uma coisa aqui" },
                    { "estrelapropaganda", "", "", "estrelapropaganda", "", 10.6f, "", "", 0, "", "Propaganda" },
                    { "estrelavestidostiago", "", "", "estrelavestidostiago", "", 6.89f, "", "", 1, "", "Os vestidos do Tiago" },
                    { "flanbaptistasodio", "", "", "flanbaptistasodio", "", 8f, "", "", 1, "", "Sódio" },
                    { "flancostaoxigénio", "", "", "flancostaoxigénio", "", 8f, "", "", 1, "", "Oxigénio" },
                    { "flandireitoresposta", "", "", "flandireitoresposta", "", 12f, "", "", 1, "", "Direito de resposta" },
                    { "flanduraditatura", "", "", "flanduraditatura", "", 12f, "", "", 1, "", "Dura ditadura" },
                    { "flanelo", "", "", "flanelo", "", 12f, "", "", 1, "", "ELO" },
                    { "flangabrielacloro", "", "", "flangabrielacloro", "", 8f, "", "", 1, "", "Cloro" },
                    { "flanguimarãestitânio", "", "", "flanguimarãestitânio", "", 8f, "", "", 1, "", "Titânio" },
                    { "flanmarqueschumbo", "", "", "flanmarqueschumbo", "", 8f, "", "", 3, "", "Chumbo" },
                    { "flanmodernoseis", "", "", "flanmodernoseis", "", 12f, "", "", 1, "", "Já não dá para ser moderno: Seis poetas de agora" },
                    { "flanmouraestrôncio", "", "", "flanmouraestrôncio", "", 8f, "", "", 0, "", "Estrôncio" },
                    { "flanoliveiracriptónio", "", "", "flanoliveiracriptónio", "", 8f, "", "", 2, "", "Criptónio" },
                    { "flanpalerma", "", "", "flanpalerma", "", 12f, "", "", 1, "", "Um palerma entra num bar e não vê o elefante" },
                    { "flanpessoafosforo", "", "", "flanpessoafosforo", "", 8f, "", "", 2, "", "Fósforo" },
                    { "flanpoemanifesto", "", "", "flanpoemanifesto", "", 8f, "", "", 1, "", "Poemanifesto 2.0.18" },
                    { "flopartaudacabar", "", "", "flopartaudacabar", "", 15.5f, "", "", 0, "", "Para acabar de vez com o juízo de Deus e outros textos finais (1946-1948)" },
                    { "flopeirasregras", "", "", "flopeirasregras", "", 18.5f, "", "", 0, "", "Regras para a direcção do espírito" },
                    { "flopguimaraesembriagaivos", "", "", "flopguimaraesembriagaivos", "", 18.5f, "", "", 0, "", "Embriagai-vos: Antologia de poemas em prosa de autores franceses" },
                    { "flopkavafispoemas", "", "", "flopkavafispoemas", "", 18f, "", "", 0, "", "145 Poemas" },
                    { "flopoutonooitocentos", "", "", "flopoutonooitocentos", "", 16f, "", "", 1, "", "O outono de oitocentos" },
                    { "hienabarnescavalos", "", "", "hienabarnescavalos", "", 12f, "", "", 0, "", "Uma noite entre os cavalos" },
                    { "hienabatailleratos", "", "", "hienabatailleratos", "", 12f, "", "", 0, "", "História de ratos" },
                    { "hienagenetcondenado", "", "", "hienagenetcondenado", "", 12f, "", "", 1, "", "Genet / O condenado à morte" },
                    { "hienajouhandeautirésias", "", "", "hienajouhandeautirésias", "", 10f, "", "", 1, "", "Tirésias (escrito secreto)" },
                    { "hienakavafispáginas", "", "", "hienakavafispáginas", "", 10f, "", "", 0, "", "Páginas íntimas" },
                    { "hienalealsodoma", "", "", "hienalealsodoma", "", 14f, "", "", 1, "", "Sodoma divinizada" },
                    { "hienamooresexo", "", "", "hienamooresexo", "", 12f, "", "", 2, "", "O outro sexo de Albert Nobbs" },
                    { "hienarimbaudbarco", "", "", "hienarimbaudbarco", "", 10f, "", "", 0, "", "O barco bêbado" },
                    { "hienawildecárcere", "", "", "hienawildecárcere", "", 14f, "", "", 1, "", "A balada do Cárcere de Reading" },
                    { "ignotacocteausegredos", "", "", "ignotacocteausegredos", "", 10f, "", "", 4, "", "Segredos de beleza" },
                    { "ignotacopipéron", "", "", "ignotacopipéron", "", 9f, "", "", 5, "", "Eva Péron" },
                    { "ignotamillermishima", "", "", "ignotamillermishima", "", 10f, "", "", 0, "", "Reflexões sobre a morte de Mishima" },
                    { "ignotapersepássaros", "", "", "ignotapersepássaros", "", 10f, "", "", 2, "", "Pássaros" },
                    { "lamasboeing", "", "", "lamasboeing", "", 5.3f, "", "", 3, "", "Boeing n.º 737-800 em Fá # menor" },
                    { "lavanduladuaspoetas", "", "", "lavanduladuaspoetas", "", 15f, "", "", 3, "", "Duas poetas modernistas: Amy Lowell / Edith Södergran" },
                    { "lincedante", "", "", "lincedante", "", 20f, "", "", 0, "", "Dante" },
                    { "livro", "", "", "livro", "", 20f, "", "", 0, "", "Livro" },
                    { "maiocostadesencapados", "", "", "maiocostadesencapados", "", 10f, "", "", 0, "", "desencapados" },
                    { "maiofeijóbichxs", "", "", "maiofeijóbichxs", "", 8f, "", "", 0, "", "Bichxs de Merda: Aristóteles, fêmeas e outros monstros de-generativos" },
                    { "maionealonvitoriosos", "", "", "maionealonvitoriosos", "", 8f, "", "", 2, "", "Os vitoriosos" },
                    { "marinhoycontos", "", "", "marinhoycontos", "", 10f, "", "", 1, "", "Y: Contos" },
                    { "masmorra2023", "", "", "masmorra2023", "", 8f, "", "", 0, "", "Masmorra" },
                    { "montanhaartesperformativas", "", "", "montanhaartesperformativas", "", 12f, "", "", 0, "", "Artes performativas e cultura digital" },
                    { "obrahilda01", "", "", "obrahilda01", "", 20f, "", "", 1, "", "Hilda de Paulo #01" },
                    { "obratales01", "", "", "obratales01", "", 20f, "", "", 26, "", "Tales Frey #01" },
                    { "odeteesboço", "", "", "odeteesboço", "", 7f, "", "", 0, "", "Um esboço do método ao qual chamei arqueologia paranóica" },
                    { "oliveirajoãoalves", "", "", "oliveirajoãoalves", "", 8f, "", "", 0, "", "João Alves" },
                    { "pinhoparadoxplenty", "", "", "pinhoparadoxplenty", "", 24f, "", "", 0, "", "Paradox of Plenty" },
                    { "poetriafrescamae", "", "", "poetriafrescamae", "", 12f, "", "", 0, "", "Língua-mãe" },
                    { "poetriafrescamaeespecial", "", "", "poetriafrescamaeespecial", "", 20f, "", "", 0, "", "Língua-mãe (Edição especial)" },
                    { "presente1000", "", "", "presente1000", "", 10f, "", "", 0, "", "Presente" },
                    { "presente1250", "", "", "presente1250", "", 12.5f, "", "", 0, "", "Presente" },
                    { "presente1500", "", "", "presente1500", "", 15f, "", "", 0, "", "Presente" },
                    { "presente1750", "", "", "presente1750", "", 17.5f, "", "", 0, "", "Presente" },
                    { "presente2000", "", "", "presente2000", "", 20f, "", "", 0, "", "Presente" },
                    { "rabiscoheart", "", "", "rabiscoheart", "", 15f, "", "", 0, "", "After a Broken Heart, a Horny Heart" },
                    { "renatochorãoromania", "", "", "renatochorãoromania", "", 25f, "", "", 2, "", "Souvenirs from Romania" },
                    { "renaud1", "", "", "renaud1", "", 15.9f, "", "", 3, "", "Vers le monde bleu" },
                    { "renaud2", "", "", "renaud2", "", 50f, "", "", 3, "", "Kinshasa 1974" },
                    { "renaud3", "", "", "renaud3", "", 100f, "", "", 4, "", "La garde de nuit" },
                    { "ribmulherló", "", "", "ribmulherló", "", 15f, "", "", 2, "", "a mulher de Ló" },
                    { "rolimcarneiroincesto", "", "", "rolimcarneiroincesto", "", 2f, "", "", 0, "", "O incesto (Usado)" },
                    { "salomélábioabril", "", "", "salomélábioabril", "", 7f, "", "", 0, "", "Lábio/Abril" },
                    { "snobpiñerabaro", "", "", "snobpiñerabaro", "", 14f, "", "", 1, "", "O Grande Baro e outras histórias" },
                    { "teoremaleavittdança", "", "", "teoremaleavittdança", "", 10f, "", "", 1, "", "Dança de família (Usado)" },
                    { "testealmeidaestrada", "", "", "testealmeidaestrada", "", 10.6f, "", "", 0, "", "A estrada menos viajada" },
                    { "testearendtpoemas", "", "", "testearendtpoemas", "", 11.66f, "", "", 0, "", "Poemas" },
                    { "testebataillemorto", "", "", "testebataillemorto", "", 13f, "", "", 0, "", "O morto" },
                    { "testebataillepequeno", "", "", "testebataillepequeno", "", 11.66f, "", "", 0, "", "O pequeno" },
                    { "testebeatfeminina", "", "", "testebeatfeminina", "", 10.6f, "", "", 0, "", "Easy to Love: Antologia – Poesia Beat Feminina" },
                    { "testeblanchotamizade", "", "", "testeblanchotamizade", "", 17f, "", "", 0, "", "A amizade" },
                    { "testeblanchotcomunidade", "", "", "testeblanchotcomunidade", "", 11.66f, "", "", 0, "", "A comunidade inconfessável" },
                    { "testeblanchotloucura", "", "", "testeblanchotloucura", "", 11.66f, "", "", 0, "", "A loucura do dia" },
                    { "testebonnevilesantidade", "", "", "testebonnevilesantidade", "", 10.6f, "", "", 0, "", "Ensaios de santidade" },
                    { "testebrunovínculos", "", "", "testebrunovínculos", "", 11.66f, "", "", 1, "", "Dos vínculos em geral" },
                    { "testecageconferência", "", "", "testecageconferência", "", 13f, "", "", 1, "", "Conferência sobre nada / Conferência sobre algo" },
                    { "testecahunconfissões", "", "", "testecahunconfissões", "", 16f, "", "", 1, "", "Confissões inconfessas: 1919-1925 " },
                    { "testecernudaquimera", "", "", "testecernudaquimera", "", 10.6f, "", "", 2, "", "Desolação da quimera" },
                    { "testecocteauopio", "", "", "testecocteauopio", "", 13.78f, "", "", 0, "", "O cordão umbilical / Ópio" },
                    { "testecruzsonetos", "", "", "testecruzsonetos", "", 13.78f, "", "", 2, "", "Sonetos" },
                    { "testecummingseróticos", "", "", "testecummingseróticos", "", 14.84f, "", "", 0, "", "Poemas eróticos" },
                    { "testedattasnoite", "", "", "testedattasnoite", "", 11f, "", "", 1, "", "A noite espiritual" },
                    { "testedurasgodard", "", "", "testedurasgodard", "", 14f, "", "", 0, "", "Diálogos" },
                    { "testedurasmorte", "", "", "testedurasmorte", "", 14.84f, "", "", 0, "", "A doença da morte / Escrever" },
                    { "testeéluardmãos", "", "", "testeéluardmãos", "", 12.72f, "", "", 0, "", "As mãos livres" },
                    { "testefariacanto", "", "", "testefariacanto", "", 13f, "", "", 1, "", "Canto do aumento" },
                    { "testegravespoemas", "", "", "testegravespoemas", "", 13f, "", "", 2, "", "Poemas" },
                    { "testehandkecanhota", "", "", "testehandkecanhota", "", 10.6f, "", "", 0, "", "Instrospecção / A mulher canhota" },
                    { "testejuarrozpoesia1", "", "", "testejuarrozpoesia1", "", 11.66f, "", "", 0, "", "Poesia e criação: Diálogos com Guillermo Boido – 1" },
                    { "testejuarrozpoesia2", "", "", "testejuarrozpoesia2", "", 11.66f, "", "", 0, "", "Poesia e criação: Diálogos com Guillermo Boido – 2" },
                    { "testekafkaconsiderações", "", "", "testekafkaconsiderações", "", 10f, "", "", 0, "", "Considerações sobre o pecado, o sofrimento, a esperança e o verdadeiro caminho" },
                    { "testekierkegaardsedutor", "", "", "testekierkegaardsedutor", "", 16.96f, "", "", 0, "", "Diário de um sedutor" },
                    { "testelordenós", "", "", "testelordenós", "", 10.6f, "", "", 0, "", "Entre nós" },
                    { "testenovalisuno", "", "", "testenovalisuno", "", 13f, "", "", 1, "", "Uno como o caos" },
                    { "testepasolinipoesia", "", "", "testepasolinipoesia", "", 12.72f, "", "", 0, "", "A poesia é uma mercadoria inconsumível: poemas e recensões" },
                    { "testepoesiaitaliana", "", "", "testepoesiaitaliana", "", 12.72f, "", "", 1, "", "Antologia de poesia italiana: 13 autoras" },
                    { "testequignardnoite", "", "", "testequignardnoite", "", 13.78f, "", "", 0, "", "A noite sexual" },
                    { "testequignardsolitários", "", "", "testequignardsolitários", "", 14.84f, "", "", 0, "", "Sobre a ideia de uma comunidade de solitários / Sobre a imagem que falta aos nossos dias / Todas as manhãs do mundo" },
                    { "testerossiamor", "", "", "testerossiamor", "", 14.84f, "", "", 2, "", "O amor é uma droga dura" },
                    { "testewalsermundo", "", "", "testewalsermundo", "", 12.72f, "", "", 0, "", "Estou só e fora do mundo: 50 poemas" },
                    { "testeweilamizade", "", "", "testeweilamizade", "", 12.72f, "", "", 0, "", "A amizade / Carta a um religioso" },
                    { "tiagojimbicolour", "", "", "tiagojimbicolour", "", 10f, "", "", 1, "", "bicolour" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "972370806X");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9727951783");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9728423187");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9728423829");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9729013209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9729013756");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780006540441");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780007205011");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780007292363");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780008244125");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780008553807");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780008637569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780022410213");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780060959470");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780061715440");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780061715617");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780061715631");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780062985491");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780063159563");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099222910");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099288719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099388616");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099422471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099474913");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099485162");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099511885");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099561071");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099593379");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099598176");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099598275");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780099757719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140182750");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140184471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140184495");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140185850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140187977");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140187991");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140240801");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140424515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140424744");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140432510");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140433722");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140445626");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140446746");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140447637");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780140448061");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141012377");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141022109");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141022116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141031682");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141035789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141035826");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141045191");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141182209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141182575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141182797");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141182841");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141183282");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141183404");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141184616");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141184760");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141184968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141185385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141185439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141185910");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141186351");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141186375");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141186504");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141187129");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141187655");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141187778");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189109");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189291");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189420");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189567");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189765");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189826");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189833");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189840");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189857");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189864");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189918");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141189932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190051");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190068");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190266");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190273");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141190280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141191089");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141191096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141191102");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141191119");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141191355");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141191836");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141192055");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141192154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141193076");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141195544");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141195551");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141195650");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141198224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141198248");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141396064");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141396118");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141397986");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141398990");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141399010");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141399027");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141439471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141981741");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141984667");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141985985");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141987880");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141990149");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141991252");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141991801");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141993089");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780141998213");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143105978");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143106180");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143106968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143131625");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143131700");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143133384");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143133513");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143133728");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143134220");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143135616");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143136071");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143137078");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143137269");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780143137467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780224069823");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780224080514");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780224087063");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780224101905");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241004623");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241251027");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241252536");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241301197");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241302514");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241312995");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241316757");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241334003");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241337622");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241339145");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241339541");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241339688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241339701");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241339725");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241339800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241342039");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241351086");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241351291");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241352144");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241360637");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241371978");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241388945");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241389010");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241396865");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241408407");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241410509");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241423141");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241435083");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241435090");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241435113");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241436288");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241436301");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241453506");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241472361");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241508718");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241508749");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241514177");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241515037");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241519936");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241528457");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241532683");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241535394");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241537343");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241541388");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241543740");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241543757");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241547991");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241548004");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241548011");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241551271");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241552292");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241575734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241578131");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241586402");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241595824");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241602751");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241618042");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241618257");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241619537");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241631645");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241633977");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241639795");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241707647");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241711187");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241954461");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241982716");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241994573");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780241996843");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780253222039");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780300061633");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780300080889");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780300107890");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780300246315");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780300265842");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780307388902");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780307473134");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780312420307");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780316264372");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780316458733");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780330483216");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349013336");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349015682");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349015897");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349017419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349018485");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349103655");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349106571");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349700588");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780349701073");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780356508191");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780374304249");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780374535957");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780374537692");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780375711480");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780375715181");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780385472043");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780385548410");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780393319729");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780393343144");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780393346008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780393355116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780394738628");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780399579660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780413316806");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780413554802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780413712400");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780413742605");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780465017522");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780486818993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500016565");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500021866");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500023846");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500027233");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500027257");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500204498");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500204566");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500204825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500204863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500239704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500286715");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500292341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500292532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500294024");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500295557");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500296608");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500297032");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500297285");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500297490");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500297902");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500411186");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500516942");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780500517321");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780520292697");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780525510307");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780525560562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780525563433");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780525618645");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780552778404");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780552998765");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780552998772");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780552998789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780552998796");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571162574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571192717");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571224371");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571234134");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571241538");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571244799");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571322862");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571338917");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571340811");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571340828");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571340835");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571340842");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571340859");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571345403");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571347681");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571348046");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571351008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571351411");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571352470");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571354023");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571359868");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571361342");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571362264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571365081");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571366514");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571368860");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571369188");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571370436");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571370863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571378906");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571390403");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780571392612");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780575094208");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780575094994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780575118232");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780575118256");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780578761800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593093689");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593094655");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593133385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593223475");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593223482");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593242681");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593330036");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593420201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593447345");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593469736");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593713037");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780593719695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780615870861");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780679735793");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780679754763");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780679754794");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780679755401");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780691247939");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780691248615");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780711265868");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780711282674");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780714503615");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780738215679");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780743207140");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780743456081");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745337128");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745338743");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745339290");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745340067");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745341125");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745341668");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745345673");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745349954");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780745399515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780746349114");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780749397029");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780751585469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780755390977");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780762467853");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780771003820");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780786716746");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780802136916");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780802157157");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780803218871");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780807006535");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780807014578");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780807014738");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780807079171");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780811222099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780811223171");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780814757130");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780814777268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780815371175");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822313847");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822316633");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822326120");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822347255");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822348047");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822354284");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780822362241");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780823277520");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780824836849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780847864065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780854882427");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780857529299");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780861542840");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780861547425");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780863560927");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780863564789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780872865280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780880103725");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780940322127");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780956251534");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780982767177");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780993414916");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780993563348");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716216");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716223");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716230");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716261");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716278");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780995716292");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9780996421898");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781035007752");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781035017621");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781035034277");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781101973240");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781250794642");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781250849120");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781324075943");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781338540574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781350132290");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781350149175");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781350186842");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781350230729");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781350336698");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781398503212");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781398505247");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781398505278");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781398716360");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781399713221");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781399812184");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781399911269");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781408857335");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781408870587");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781408891384");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781408891575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781419743863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781419749773");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781419755606");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781419766787");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781447241218");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781447257684");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781447280521");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781447294832");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472116154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472119971");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472157577");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472258229");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472263650");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472263667");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472520524");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781472520814");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781473205789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781473221628");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781473230989");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781473613157");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781474620406");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781474620437");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781476700403");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781478001621");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781478008330");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781478011088");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781478019381");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781478030478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781479827770");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781479874569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781487011789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781501312830");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781501759505");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781503612396");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509813865");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509830008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509830022");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509839407");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509857128");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509866175");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509874675");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509874705");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781509885589");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781517900199");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781517911041");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781517911188");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781517913182");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781524748562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781524854010");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781526142825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781526604989");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781527294219");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529007671");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529012590");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529017250");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529020472");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529045260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529068788");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529073119");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529076783");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529077124");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529092066");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529092660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529110760");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529111361");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529111675");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529111705");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529111965");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529113341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529114218");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529114478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529115321");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529115338");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529151145");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529156096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529328059");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529377750");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529377767");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529404869");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529920642");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781529922554");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781541644373");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781541699212");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781549304002");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781551527208");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781551527819");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781551528113");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781551528564");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781551528854");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781551529011");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781556520747");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781556591044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781556596292");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781556596346");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781558612457");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781558618374");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781566895477");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781580056892");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781580469562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781580936286");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781583226988");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584350774");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584350811");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584350989");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351115");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351122");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351641");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351740");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351757");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351948");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781584351993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590170281");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590173787");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590173954");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590176016");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590176658");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590177259");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781590178447");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781592702671");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781593761950");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781593767051");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781595588166");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781597112086");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781597114769");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781597115285");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781598532784");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781606997185");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781611854381");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781611856569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781612194004");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781612196169");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781612197319");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781612197791");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781620975763");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781629637969");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781629639710");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781632061683");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635900170");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635900385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635900408");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901184");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901191");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901375");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901429");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901665");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901764");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901832");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901924");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635901948");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781635902068");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781637150726");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781637680384");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781639442676");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781641293044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781641293754");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643620060");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643620268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643620336");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643620367");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643620749");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621104");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621159");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621487");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621524");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621760");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621784");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643621791");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781643622347");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781644230244");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781644230695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781644230701");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781644230886");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781644231203");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781645036586");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781645036661");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781645679561");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781646142569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781646222230");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781648230349");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781648961571");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "978166801993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781681370767");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781681374314");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781681375410");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781681377629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781681377643");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781681377766");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781683964261");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781683965275");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781683965282");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781685890797");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781685891053");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781728254326");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781736863305");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781737797944");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781737842828");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739123826");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739169763");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739169770");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739220723");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739220747");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739220761");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739220785");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739364922");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739364953");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739364984");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739606763");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739702908");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739702948");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739702960");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739702977");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739784911");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781739784980");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781770461734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781770462243");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781780992266");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781256480");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781257807");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781258682");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781259313");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781259535");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781578049");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781578292");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781578698");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781781683231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781782273608");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781782275121");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781783601691");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781783785834");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781783787029");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781783789290");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784709952");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784742041");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784743055");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784743703");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784744700");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784745738");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784781675");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784784409");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784787691");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784870515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784870546");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784870843");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784870850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784870867");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784870874");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784873875");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784875169");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784876128");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784876135");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784876722");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877330");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877347");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877392");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877415");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877484");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877682");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784877781");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784878757");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781784879020");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785780714");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785784521");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785784903");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785786532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785786914");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785786952");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785788512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781785927461");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786031617");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786074409");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786079244");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786223937");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786225252");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786495259");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786496256");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786632630");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786632661");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786633835");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786637307");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786690685");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786694874");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786890276");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786890887");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786891006");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781786892478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787332263");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787332355");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787333192");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787333383");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787333703");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787333840");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787334045");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787334182");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787334274");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787334595");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787702059");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787704640");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787753396");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781787756182");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788162258");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788163248");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788164504");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788164511");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788165150");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788166539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788166713");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788167734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788168144");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788168397");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788169912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788731577");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788732345");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788732376");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788735339");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788735384");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788737371");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788737838");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788738620");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788738958");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788739825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781788739887");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781797214856");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800172791");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800180567");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800182851");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800183360");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800810129");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800812895");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800814752");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800814813");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800814844");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800818613");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800819849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781800819962");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781802060065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781802061147");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781802061895");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781802062304");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781802062458");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781802065411");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781803287393");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781803367569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781803414300");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804190463");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804191354");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804270400");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804270424");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804270776");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804291283");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804291566");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804292617");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804292945");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804440162");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804440322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804470411");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781804991237");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781805300878");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838110161");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838171629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838390006");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838390020");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838390044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838390082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838664206");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838854317");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838854331");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838858957");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838950101");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838956585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838957223");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781838958848");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839040351");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839760693");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839760969");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839762123");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839762802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839763274");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839763281");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839763342");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839764080");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839764110");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839765711");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839767197");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839767333");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839767951");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839768491");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839768859");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839970436");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839971839");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781839971952");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781840226997");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781841150352");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781843914310");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781843916543");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781844080816");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781844087198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781846143496");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781846687853");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781847083982");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781847088383");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781847771032");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781848426313");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849765039");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849766562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849767156");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849767163");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849767750");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849767774");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781849767842");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781854590909");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781857549478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781857988826");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781860490026");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781890159352");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781890159360");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781907112560");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781908745934");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781908906489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781910312773");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781910695043");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781910695357");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781910924389");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911214373");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911214519");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911214526");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911284635");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911343479");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911547747");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781911717027");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781912339730");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781912489404");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781912489602");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781912489725");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781912489848");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913010799");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913090111");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913097073");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913097172");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913097233");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913097349");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913097585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913111397");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913123031");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913437701");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913462420");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913462482");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913512217");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913513320");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913620493");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781913875398");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914124211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914198144");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914198489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914198861");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914420580");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914484957");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781914502071");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781915368645");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781915590602");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781916355361");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781916355378");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781917008006");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781917008020");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781922754295");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781933227962");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781937658786");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781941360385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781941701546");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781943735457");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781943977444");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781944700829");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781944860370");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781944860530");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781945509629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781946022660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781952177798");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781953861207");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781978820531");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781982106225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781982110215");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781984899422");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781999675998");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9781999922313");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782020094535");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782021312546");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782021483048");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070132553");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070143986");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070263295");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070336371");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070343591");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070361175");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070366569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070367689");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070368006");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070368600");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070368754");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070370412");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070383351");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070387175");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070387199");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070387311");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070389568");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070402670");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070407873");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070416264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070427574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070444342");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070454334");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782070466115");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782072843037");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782072850981");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782072918049");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782072968082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782073014870");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782080420015");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782081218000");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782081231627");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782081270848");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782081515932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782207161814");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782213701479");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782213711997");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782213721590");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782226471055");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782246194828");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782246826514");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782253087557");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782253159711");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782253237563");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782264073730");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782266144322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782267030808");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782267030815");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782290235850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782290385524");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782352702245");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782354801755");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782355220869");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782355221101");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782355221521");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782355221743");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782366247022");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782371001114");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782377390533");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782377390687");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782379165580");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "978241464137");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707300973");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707306111");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707306395");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707306432");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707311030");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707320223");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707345707");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782707348296");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782708704206");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782755507751");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782757821060");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782757896549");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782809849219");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782818014660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782818021309");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782842304782");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782842712419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782906571907");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782908050837");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782912464880");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782919289424");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782919289516");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782919289578");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9782956766261");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783038601890");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783777439921");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783777441085");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836547925");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836550512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836555814");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836570695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836574471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836580922");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836581257");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783836582490");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783954765997");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783956796050");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9783982389400");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786077985341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120006658");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120009178");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120009604");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120010532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120010761");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120010785");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120011225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120011300");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120011379");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120011768");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120012116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120012154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120013212");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120013632");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120014240");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120014738");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120014813");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120016886");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120017289");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120017340");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786120017784");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786550940478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786555320367");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786555530773");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786555875621");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786556910260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786557172476");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786557173343");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786558020745");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559000319");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559001828");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559002634");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559003181");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559004201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559004560");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559004843");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559005031");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559006717");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559007585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559007707");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559052851");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559210312");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559210381");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559210558");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559211548");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559211647");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559212262");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559213498");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559280148");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559281688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559790685");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559791125");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559791309");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786559791415");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786560080010");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786560080270");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786560080317");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786586279146");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786586790122");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587076799");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587113364");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587235127");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587235240");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587235417");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587235776");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587235844");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587529295");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587814117");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587938226");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9786587938585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788409296163");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788410288041");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788411070898");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788411073325");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788411073646");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788411101202");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788411102575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788411102889");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412028355");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412028393");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412047523");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412047554");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412083385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412106503");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412106572");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412106596");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412109153");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412109160");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412142877");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412142884");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412152616");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412152678");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412166095");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412169348");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412169386");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412175301");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412185652");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412185812");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412185843");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412212907");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412212938");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412212990");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412218022");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412224306");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412244090");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412260205");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412260274");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412276626");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412276640");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412276657");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412276688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412292503");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412321227");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412321289");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412330748");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412330786");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412330793");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412349894");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412405583");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412434514");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412441659");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412466539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412466577");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412466584");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412480276");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412511949");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412511963");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412512366");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412520439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412520460");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412520477");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412524215");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412526141");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412526165");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412549294");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412584035");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412584080");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412597585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412628234");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412640069");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412640076");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412640083");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412640090");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412641042");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412652154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412653526");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412653571");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412653595");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412656114");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412699005");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412710748");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412710762");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412713718");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412713756");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412713770");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412716832");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412716856");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412716870");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412765724");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412765731");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412765748");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788412844207");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788413524030");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788413525464");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788413526058");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788413528359");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788413629155");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788415305859");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788415373216");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788415373360");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416205769");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416217601");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416227242");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416227334");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416489695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416491995");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416529421");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788416545452");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788417417772");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788417442859");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788417496524");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788417496777");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788417560751");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788417858407");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418100994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418178559");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418252006");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418283369");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418481147");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418481406");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418501050");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418501142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418501180");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418501517");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418501777");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418501876");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418639340");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418684814");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418690495");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418752704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418782008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418809736");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788418821240");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419047267");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419160270");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419231703");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419323118");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419323170");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419323200");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419323217");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419323224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419387394");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419387615");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419387639");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419387905");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419437365");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419466242");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419558268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419633378");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419728043");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788419990341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788420431444");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788420432595");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788420461106");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788420664439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788420697970");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788423363629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788426409676");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788426420176");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788432242120");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433916228");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433916242");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433916433");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433916594");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433921079");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433924384");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433964533");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433964540");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433964557");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433998644");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433998767");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433999351");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788433999481");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788437602202");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788437608082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788437617763");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788437624433");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788439737612");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788439738909");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788439739173");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788439739180");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788439742883");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788446011964");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788446049029");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788446050780");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788448028916");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788449337918");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788449339776");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788449341403");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788466333665");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788466333887");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788466337465");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788467067316");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788467072532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788467940473");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788472909267");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788475175694");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788475179438");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788475229921");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788476588406");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788478335961");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788478338108");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788478398454");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788481914337");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788483447451");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788483740156");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788483745038");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788483812730");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788484728139");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788487524710");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788488052520");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490020982");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490021033");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490021408");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490021439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490021576");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490022146");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490668061");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788490669112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788491045670");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788491213321");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788491810599");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788491812920");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788492813209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788493108604");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788493664817");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788493868987");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788493993573");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494035364");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494218514");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494218576");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494241314");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494241321");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494241383");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494311550");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494311598");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494355974");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494448850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494504327");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494519932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494519970");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494519994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494520815");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494682452");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494710803");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494710841");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494878459");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494878473");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494941481");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494945441");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494967412");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788494967450");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788495346971");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788495346995");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788495430096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788496614512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497840507");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497931625");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497931632");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497931649");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497932905");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497933346");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497933353");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497936422");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788497936439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788498653557");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788498881455");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788498954111");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788498954272");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788498954500");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788498954562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788499530765");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788499703015");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788499989556");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788499989587");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788501115591");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788520945988");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788522006649");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535915389");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535923629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535927719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535928716");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535928853");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535929812");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535929829");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535930863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535931280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535931501");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535932669");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535933512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535933581");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535933697");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788535935417");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788542223798");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788544107881");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788546901401");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788546904587");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788547000653");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788547000936");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788547001391");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788569433507");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788569433767");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788571051393");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788571051409");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788581280554");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788588808683");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788593115257");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788593115363");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788593115769");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788593115783");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788593115912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788598349688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788598349695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788862086554");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9788874399284");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789569974168");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789587040783");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720030399");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720031570");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720031600");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720031846");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720032492");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720033024");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720033031");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720033048");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720033260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720033659");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720033857");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720034861");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720035226");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720042361");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720044945");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720046543");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720046673");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720047335");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720047342");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720047397");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720047410");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720047472");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720048103");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720048424");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720048547");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720048653");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720048868");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720071491");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720425065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720712776");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720715593");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720715968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720724182");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720724199");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789720793065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722026369");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722028547");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722028615");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722029094");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722030960");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722031325");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722033046");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722034081");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722034098");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722037600");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722038072");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722038676");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722039727");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722040112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722040334");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722044868");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722046527");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722048057");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722053280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722054102");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722054126");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722054386");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722056298");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722057073");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722057431");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722058544");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722059688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722059725");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722064309");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722064736");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722065153");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722065863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722065993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722066983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722067317");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722067331");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722067805");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722069489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722071086");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722071291");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722071734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722072007");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722072151");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722073165");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722074124");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722074162");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722074896");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722080729");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722081313");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722100397");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722115758");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722120753");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722121118");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722121200");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722124478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722127752");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722128162");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722128186");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722128469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722129794");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722130547");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722131377");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722522809");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722523462");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722525121");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722531177");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722532938");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722533867");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722536158");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722536240");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722536257");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722536486");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722537704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722538237");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722538411");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722538688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722538862");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722539524");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722541091");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722541589");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722542647");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722543040");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722544818");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722546621");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722546737");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722723343");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722727259");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722727853");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722728522");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722728881");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722728898");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789722729048");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723308649");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723602210");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723602265");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723603149");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723603194");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723603347");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723603385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723603521");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723603934");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723607581");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723607604");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723609387");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723610901");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723611472");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723611786");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723612455");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723613865");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723615043");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723615050");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723616651");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723617788");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723700305");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723701074");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723702798");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723703203");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723703726");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723703870");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723705089");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723705195");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723707225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723708790");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723708813");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723709117");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723709124");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723709209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723709554");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723709810");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723710021");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723711769");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723711912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723712018");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723712933");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723713084");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723713404");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723713695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723713893");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723714043");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723714623");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723714937");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723715712");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716498");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716504");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716566");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716665");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716672");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716696");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723716894");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717174");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717402");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717655");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717921");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723717938");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718133");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718157");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718263");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718324");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718348");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718447");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718584");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718591");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718836");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718904");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718959");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723718973");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719161");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719451");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719666");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719710");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723719963");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720136");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720402");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720600");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720624");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720631");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720679");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720938");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720952");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723720990");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721294");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721362");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721454");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721560");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721669");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721706");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721744");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721782");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721843");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721935");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723721959");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722253");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722314");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722352");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722475");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722550");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722635");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722673");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723722888");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723723236");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723723496");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723723595");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723723618");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723723632");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723723793");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723729112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723829044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723829419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723830064");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723830361");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723830385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723830521");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789723830811");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724410449");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724410708");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724411033");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724411965");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413181");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413396");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413495");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724413532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724414461");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724415659");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724415956");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724415970");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724416182");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724416533");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724417660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724420660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724422695");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724423081");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724423968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724424200");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724424231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724424651");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724424842");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724425337");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724425757");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724425771");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724427058");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789724427089");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725566391");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725647929");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725648032");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725648414");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725648674");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725649244");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725649312");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725649428");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725649565");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725649855");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789725657065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726080121");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726080138");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726080329");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "978972608069X");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081029");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081067");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081128");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081241");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081494");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081555");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081866");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081890");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081906");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726081944");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082033");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082156");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082248");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082408");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082422");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082446");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082453");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082491");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082507");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082545");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082699");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082712");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082743");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082781");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082835");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082897");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082934");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726082972");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083016");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083023");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083078");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083092");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083108");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083177");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083184");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083191");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083207");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083238");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083245");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083269");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083276");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083290");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083320");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083344");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083351");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083382");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083399");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083405");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083474");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083498");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083511");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083597");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083610");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083634");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083641");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083658");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083689");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083757");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083764");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083788");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083795");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083818");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083832");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083887");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083894");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083900");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083924");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726083986");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084051");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084129");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084136");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084150");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084167");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084228");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084235");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084242");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084266");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084273");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084297");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084303");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084327");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084372");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084396");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084402");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084426");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084440");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084501");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084518");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084549");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084556");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084594");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084600");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084617");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084624");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726084648");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726952425");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726955254");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726955416");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726955769");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789726995094");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727081681");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082094");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082407");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082414");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082421");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082582");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082711");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082750");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727082810");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727083985");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727084142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727084807");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727084869");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727085330");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727085453");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727085484");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727085637");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727085965");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727086146");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727086559");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727086641");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727087198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727087211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727087825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727087922");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727087983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727088256");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727089642");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727089659");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727089994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727933013");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727951048");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727953325");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727953448");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727953585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727953783");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727953806");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789727953950");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728418469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728781309");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728781446");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728781538");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728781590");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728781606");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728781910");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728791902");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728827014");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728827113");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728955656");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728972295");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728972455");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728972639");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728972769");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728972776");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789728972851");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789729013201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789729941078");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789729941085");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789774168758");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789871622849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789873831829");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789878272207");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892049106");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892054643");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892087283");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892087290");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892092614");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892324562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892328553");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892331959");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892346076");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892351872");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892352329");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892352589");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789892357836");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893305539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893311202");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893317198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893319543");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893329047");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893335260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893340868");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893350515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893358726");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893511039");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789893539309");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895307401");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895309658");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895311569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895313013");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895313044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895313068");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895313082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895313099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895328376");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895328383");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339808");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339822");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339839");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339846");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339853");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895339860");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895342938");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349203");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349227");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349234");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349241");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349258");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349265");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349272");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349289");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895349296");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895353828");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895357802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895360505");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895360536");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895360550");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361311");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361328");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361335");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361366");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361809");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361816");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361823");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361830");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361847");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361854");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361861");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895361878");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895382002");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895382446");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895396801");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895396818");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895396825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895396849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895398508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895398515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895398522");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895398546");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895398560");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895398577");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895401390");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895424399");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895428441");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895428458");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895428489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895428496");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895434084");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895434411");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895438013");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895440009");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895440030");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895440047");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895440061");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895440078");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895442973");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895442980");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895453467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895456710");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895456772");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895456796");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895458967");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895470839");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895470860");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895470884");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895470891");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895472260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895472291");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895473571");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895473816");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895479252");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895483105");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895483136");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895483143");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895483181");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895488216");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895489503");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895489510");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895489527");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895489534");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895490943");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895491575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895495528");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895640140");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895640959");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895642328");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895643349");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895643356");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895646050");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895646487");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895647651");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895648122");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895648542");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895649280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895649297");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895649471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680054");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680221");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680283");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680405");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680412");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680429");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680450");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680559");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680665");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895680818");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895681068");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895681099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895681129");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895681495");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895681518");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895681532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895770236");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895770571");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895770731");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789895830473");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896030014");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896229092");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896231194");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232412");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232511");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232535");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232696");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232801");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232870");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896232894");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896233105");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896233112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896233891");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896234621");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896235833");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896236588");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896237660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896237905");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896238391");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896238506");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896239374");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410117");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410179");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410285");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410346");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410476");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896410780");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896411107");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896411206");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896411213");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896411435");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896411527");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896411619");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896412142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896412401");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896413408");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896413590");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896413750");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896414122");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896414207");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896414221");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896414399");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896414405");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896414467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415266");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415433");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415457");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415716");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896415983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416157");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416218");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416249");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416331");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416379");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416386");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416423");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416584");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416614");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416638");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416645");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416690");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416881");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896416935");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417079");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417147");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417208");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417390");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417420");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417581");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417666");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417758");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417871");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417888");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417949");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896417987");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418250");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418403");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418427");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418618");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418748");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418861");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418915");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896418960");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419028");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419240");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419295");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419301");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419684");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419790");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896419929");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896441449");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896441500");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896445683");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896530037");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896530198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896600709");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896602512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896604219");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896605773");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896608088");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896609276");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896617714");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896642830");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896651008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896651244");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896651572");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896651602");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896651800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896652197");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896652692");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896653248");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896653286");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896653354");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896653552");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896653620");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896655211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896655624");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896655976");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896656461");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896657062");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896657086");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896657611");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896658137");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896658373");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896659325");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896661762");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896661816");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896663568");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896685515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896685614");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896685829");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686239");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686291");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686581");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686628");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686857");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896686932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896687427");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896687458");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896687762");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896687786");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896688134");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896688189");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896688684");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896688899");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896710002");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896710262");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896710774");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896710781");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896710965");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896711016");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896711078");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896711467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896711825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896712648");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896713164");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896713911");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896714079");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896714420");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896714574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896714659");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896714994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896715397");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896715458");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896715533");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896715670");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716141");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716165");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716172");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716295");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716325");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716332");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716424");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716448");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716554");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716820");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896716936");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717292");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717308");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717339");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717407");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717483");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896717865");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896718268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896718350");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896721084");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896760397");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896760717");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896761141");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896762438");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789896762674");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897027062");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897074530");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897074585");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897074608");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897074653");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897074837");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897075209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897075216");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897075629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897075667");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897075674");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897076800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897076855");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897077142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897077784");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897077791");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897078019");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897078897");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897079382");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897079399");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110436");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110528");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110566");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110702");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110900");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110962");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897110993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897111099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897111983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897112133");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220098");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220302");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220456");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220531");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220586");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220760");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897220968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897221378");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897221477");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897221934");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897221941");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897222658");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897223013");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897223051");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897223129");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897223198");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897223204");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897223471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224027");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224386");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224492");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224645");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224744");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224751");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224768");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897224799");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897225437");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897225574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897225598");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897225628");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897225796");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897225802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897226328");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897226380");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897226564");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897226892");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897227172");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897227233");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897227462");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897227981");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897228124");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897228322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897228339");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897228902");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897229114");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897229169");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897229343");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897229473");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897244360");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897245213");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897400643");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490002");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490071");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490408");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490637");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490668");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490774");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490781");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490828");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490897");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490941");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897490996");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491122");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491153");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491177");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491238");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491337");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491382");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491504");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491573");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491658");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491672");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491689");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491801");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897491825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897550126");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897550447");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897550980");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897553264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897553462");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897553523");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897553714");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897553943");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897553974");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897554209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897555466");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897555589");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897555596");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897555725");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897556272");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897556418");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897556487");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897556586");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897556968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897557378");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897557439");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897557569");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897558184");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897558337");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897558962");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897558986");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897559136");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897731068");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897764097");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897766343");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897769672");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897769689");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897769719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897830211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897830235");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897830808");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897831270");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897831478");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897831683");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897831904");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897831959");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832109");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832147");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832192");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832239");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832277");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832673");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897832895");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897833106");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897833342");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897833373");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897833540");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897833588");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897840463");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897840968");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897841385");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897841866");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897841934");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897842085");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897843082");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897843310");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897843327");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897843341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897843365");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897845024");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897845154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897845628");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897845635");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897846656");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897847172");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897847189");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897847738");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897847912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897848247");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897849183");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897849619");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897870231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897870392");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897870576");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897870644");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897872303");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897872365");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897872518");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897875472");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897876226");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897876530");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789897877544");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898093110");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898139788");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145048");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145222");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145307");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145314");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145321");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145352");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145383");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145390");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145406");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145451");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145482");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145499");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145512");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145529");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145581");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145604");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145611");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145628");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145635");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145642");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145666");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145680");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145697");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145727");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145758");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145765");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145796");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145819");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145826");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145857");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145888");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145895");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145901");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145918");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145925");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145970");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898145987");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898146410");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166005");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166012");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166036");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166159");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166197");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166203");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166210");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166258");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166296");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166326");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166371");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166388");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166395");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166425");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166449");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166470");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166487");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166500");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166517");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898166548");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205117");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205315");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205483");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205667");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205674");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205827");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205988");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898205995");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268211");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268334");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268396");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268488");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268563");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898268587");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898306050");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898306159");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327109");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327383");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327444");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327529");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327581");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327666");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327697");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327765");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327772");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327796");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327871");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327918");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327932");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898327949");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349071");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349088");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349118");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349200");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349293");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349323");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349392");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349552");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349675");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898349712");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898363367");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898443106");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566041");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566089");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566102");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566324");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566652");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566669");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898566836");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898580528");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898580696");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898618399");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898618825");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898618863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898618955");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898688163");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898688453");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898688583");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898688972");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898800237");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898831989");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833051");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833129");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833136");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833143");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833174");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833273");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833303");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833334");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833358");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833365");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833372");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833402");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833426");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833488");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833549");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833693");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833709");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833730");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898833822");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898834454");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898839053");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898839381");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898843555");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898849779");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898858405");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898858443");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898858467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898860712");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864031");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864062");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864154");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864222");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864253");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864277");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864451");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864543");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864598");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864611");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898864925");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898866264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898866660");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898866677");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868015");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868091");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868152");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868312");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868336");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868343");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868374");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868459");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868510");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868541");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868558");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868596");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868619");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868626");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868633");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868671");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868756");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868794");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868824");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868831");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868848");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868855");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868923");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868947");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868954");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868961");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898868978");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872111");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872241");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872265");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872302");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872340");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872357");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872371");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872470");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872661");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872692");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898872845");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898881151");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898881526");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898886606");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898892218");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902160");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902283");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902337");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902436");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902603");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902665");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898902719");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898917997");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898973016");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898973375");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898979377");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789898980151");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006317");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006447");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006584");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006591");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006652");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006768");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899006850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899014046");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899027961");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899039216");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899039612");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899039858");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061019");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061026");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061033");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061040");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061057");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061064");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061071");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061088");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061095");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061101");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061118");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061125");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061132");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061149");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061156");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061170");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061187");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061194");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061200");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061217");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899061248");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071001");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071056");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071148");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071155");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071179");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071223");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071230");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071278");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071308");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071421");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071452");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071506");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071711");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071742");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071759");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071797");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071803");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071827");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071834");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071865");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071919");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071926");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071933");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899071971");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899096448");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899096707");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899096912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899096967");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899105065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899105119");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899105126");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899105188");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899105225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899105348");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899124127");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899124844");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899130098");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899130135");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899150416");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899150454");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899150690");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899159075");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899225015");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899225022");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899556508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899556539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899556584");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899735705");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899735712");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899735729");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899735736");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899736283");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899771970");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899831155");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899847033");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899892170");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899943858");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899954212");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899954298");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899967427");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899967717");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899967779");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899971059");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899971561");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899975910");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899981409");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899981423");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899981461");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899992153");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899994409");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899994430");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899995000");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899995062");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899995079");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899995086");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899997448");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899997455");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899997479");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899997493");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9789899999817");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9791095630661");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798667572978");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798886200171");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798886200225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798886200430");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798891700772");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798987019979");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9798989378067");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9899898866219");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "alambiquemouracruzes");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "anfisbenatique");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "antoniomv");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "avernoargel33");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "avernoargelinferno");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "avernolareopais");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "avernopivaparanóia");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "avernorilkenotas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcobernsteincavalos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcoburroughsgeração");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcocorsogasolina");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcodeleuzeproust");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcodomingoscarmes");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcohunckediário");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcolamborginifiorde");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcoleviliberdade");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcopasolinipoeta");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcoricarddeus");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcovestrinivirtudes");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcovischertrespasse");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcowalkerpoemas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcowilsonniilismo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "barcowojnarowiczmemórias");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "belamonstrohatherlymestre");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bestiáriojoaquimpoesia");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "biakostadhab");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bl");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bl1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bl2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bl3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bonnevillecâmara");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bonnevilleciborgue");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bonnevillecisne");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bonnevillecorpo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bonnevillejerome");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "bonnevillesantidade");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "carinhasimprudente");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cassandrariosmulheres");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cassandrariosmutreta");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cavolotarotfuego");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiaárabe");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiabrasileira");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiadinamarquesa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiafinlandesa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiafrancesa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiahispanoamericana");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiaislandesa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiaitaliana");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesianorteamericana");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesianorueguesa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiapalestiniana");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiaportuguesa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiaprovençal");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiarussa");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiasueca");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "contracapapoesiasuica");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "correioenvio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "costaflesh");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cruzine");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cuteloalmeidajogo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cutelobrainardlembro");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "cutelogiorgiomemorial");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "daysoflove2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "daysoflove3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "destraussguyotatéden");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "destrausswarkmanifesto");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudabonnevillepessoal");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudadiacovninguem");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudadomeneckmanual");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudafreitasrilke");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudahalpernvazios");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudahansencantos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudajacintoregime");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudakeiserurano");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudaloureirobarreiro");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudamarqueshomo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudamarqueslinha");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudamesquitaacordo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudapinacoelhotudo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudarafaelamá");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudargbmonstres");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudariveradesdominios");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudateodosionova");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudawienerspoemas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "doudoteodosiogorila");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "eagenetquerelle");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "enfermariamantovaniesqueceu");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "estrelapropaganda");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "estrelavestidostiago");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanbaptistasodio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flancostaoxigénio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flandireitoresposta");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanduraditatura");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanelo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flangabrielacloro");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanguimarãestitânio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanmarqueschumbo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanmodernoseis");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanmouraestrôncio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanoliveiracriptónio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanpalerma");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanpessoafosforo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flanpoemanifesto");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flopartaudacabar");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flopeirasregras");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flopguimaraesembriagaivos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flopkavafispoemas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "flopoutonooitocentos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienabarnescavalos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienabatailleratos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienagenetcondenado");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienajouhandeautirésias");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienakavafispáginas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienalealsodoma");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienamooresexo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienarimbaudbarco");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "hienawildecárcere");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ignotacocteausegredos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ignotacopipéron");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ignotamillermishima");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ignotapersepássaros");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "lamasboeing");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "lavanduladuaspoetas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "lincedante");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "livro");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "maiocostadesencapados");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "maiofeijóbichxs");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "maionealonvitoriosos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "marinhoycontos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "masmorra2023");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "montanhaartesperformativas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "obrahilda01");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "obratales01");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "odeteesboço");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "oliveirajoãoalves");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "pinhoparadoxplenty");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "poetriafrescamae");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "poetriafrescamaeespecial");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "presente1000");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "presente1250");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "presente1500");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "presente1750");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "presente2000");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "rabiscoheart");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "renatochorãoromania");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "renaud1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "renaud2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "renaud3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ribmulherló");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "rolimcarneiroincesto");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "salomélábioabril");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "snobpiñerabaro");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "teoremaleavittdança");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testealmeidaestrada");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testearendtpoemas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testebataillemorto");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testebataillepequeno");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testebeatfeminina");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testeblanchotamizade");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testeblanchotcomunidade");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testeblanchotloucura");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testebonnevilesantidade");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testebrunovínculos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testecageconferência");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testecahunconfissões");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testecernudaquimera");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testecocteauopio");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testecruzsonetos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testecummingseróticos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testedattasnoite");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testedurasgodard");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testedurasmorte");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testeéluardmãos");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testefariacanto");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testegravespoemas");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testehandkecanhota");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testejuarrozpoesia1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testejuarrozpoesia2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testekafkaconsiderações");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testekierkegaardsedutor");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testelordenós");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testenovalisuno");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testepasolinipoesia");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testepoesiaitaliana");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testequignardnoite");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testequignardsolitários");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testerossiamor");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testewalsermundo");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "testeweilamizade");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "tiagojimbicolour");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Title",
                keyValue: null,
                column: "Title",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Synopsis",
                keyValue: null,
                column: "Synopsis",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ReleaseDate",
                keyValue: null,
                column: "ReleaseDate",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Publisher",
                keyValue: null,
                column: "Publisher",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Language",
                keyValue: null,
                column: "Language",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Isbn",
                keyValue: null,
                column: "Isbn",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "CoverPicture",
                keyValue: null,
                column: "CoverPicture",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CoverPicture",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Author",
                keyValue: null,
                column: "Author",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

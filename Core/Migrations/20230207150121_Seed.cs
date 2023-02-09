using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Aircraft_AircraftCode",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "IsBooked",
                table: "Seats");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SellDate",
                table: "Tickets",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Aircraft",
                columns: new[] { "Code", "MaxFlightRange", "Model", "PassengerCapacity" },
                values: new object[,]
                {
                    { "6SD", 5600f, "Airbus A321", 220 },
                    { "7AI", 11100f, "Boeing 777-9", 426 },
                    { "86Y", 4440f, "Boeing 737-900", 215 }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Code", "City", "Country", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { "EDDB", "East Karlie", "Philippines", -17.653700000000001, -50.701599999999999, "Jaskolski Inc" },
                    { "KBMH", "North Tyra", "Iran", 1.1367, 8.5932999999999993, "Kuvalis - Schinner" },
                    { "KPHL", "Schmidtton", "Lithuania", 5.7949000000000002, -123.2607, "Turner - Connelly" },
                    { "LIMC", "West Stanfordton", "Tokelau", -41.292999999999999, -94.003200000000007, "Mertz - Kozey" },
                    { "PAR", "Port Adalbertochester", "United States of America", 13.8172, 46.544600000000003, "Langworth and Sons" },
                    { "UKBB", "North Serenaberg", "Benin", -69.772400000000005, -111.0552, "Wisozk, Morissette and Leffler" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName", "PassportNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Silvia", "Cummings", "973BDFF8", "1-949-582-9909" },
                    { 2, "Stewart", "Beer", "C6034302", "581.617.7691 x687" },
                    { 3, "Lamar", "Kihn", "F5B9175E", "561.890.1654" },
                    { 4, "Priscilla", "Bartell", "682F8125", "1-540-905-9103" },
                    { 5, "Wanda", "Kunde", "E8D6A882", "557.443.6667 x8083" },
                    { 6, "Ronnie", "Boyer", "4623A7ED", "(693) 781-1622" },
                    { 7, "Lucy", "Keeling", "2FA336E3", "963-699-2169 x69209" },
                    { 8, "Israel", "Spinka", "71EA5A38", "(235) 930-4675" },
                    { 9, "Steve", "Bechtelar", "A323D0C9", "812.629.9204" },
                    { 10, "Susie", "Cummerata", "B309CA25", "806.583.6154 x754" },
                    { 11, "Bradley", "Hamill", "AEF71447", "855-790-6080" },
                    { 12, "Christie", "Okuneva", "37CFD2B2", "(557) 317-7406" },
                    { 13, "Loren", "Osinski", "3177917E", "(803) 306-2818" },
                    { 14, "Patti", "Erdman", "BFDCDE6D", "1-514-395-7966 x1406" },
                    { 15, "Hilda", "Hane", "16EF9DBF", "447-320-9232 x64252" },
                    { 16, "June", "Farrell", "FA994458", "325.662.3846 x7832" },
                    { 17, "Damon", "Fay", "D81F3427", "1-965-564-2013" },
                    { 18, "Cody", "Schaefer", "FC0460FD", "959-890-4570" },
                    { 19, "Herman", "Hyatt", "6A118A6E", "398.739.3556 x64351" },
                    { 20, "Troy", "Borer", "6B9F5375", "778.935.4690" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AircraftCode", "ArrivalAirportCode", "ArrivalDateTime", "DepartureAirportCode", "DepartureDateTime", "FlightNumber" },
                values: new object[,]
                {
                    { 1, "7AI", "PAR", new DateTimeOffset(new DateTime(2023, 2, 10, 12, 4, 25, 910, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 2, 0, 0, 0)), "UKBB", new DateTimeOffset(new DateTime(2023, 2, 9, 6, 15, 46, 414, DateTimeKind.Unspecified).AddTicks(131), new TimeSpan(0, 2, 0, 0, 0)), "OA249" },
                    { 2, "6SD", "PAR", new DateTimeOffset(new DateTime(2023, 2, 25, 9, 16, 57, 348, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 2, 0, 0, 0)), "UKBB", new DateTimeOffset(new DateTime(2023, 2, 24, 10, 50, 29, 421, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 2, 0, 0, 0)), "OA8028" },
                    { 3, "7AI", "LIMC", new DateTimeOffset(new DateTime(2023, 3, 3, 19, 31, 0, 262, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 2, 0, 0, 0)), "KBMH", new DateTimeOffset(new DateTime(2023, 3, 2, 6, 21, 57, 58, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 2, 0, 0, 0)), "OA9078" },
                    { 4, "6SD", "LIMC", new DateTimeOffset(new DateTime(2023, 3, 5, 3, 54, 9, 894, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, 2, 0, 0, 0)), "KBMH", new DateTimeOffset(new DateTime(2023, 3, 4, 7, 45, 6, 989, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 2, 0, 0, 0)), "OA3856" },
                    { 5, "86Y", "PAR", new DateTimeOffset(new DateTime(2023, 3, 11, 3, 41, 22, 881, DateTimeKind.Unspecified).AddTicks(9432), new TimeSpan(0, 2, 0, 0, 0)), "EDDB", new DateTimeOffset(new DateTime(2023, 3, 9, 7, 17, 32, 24, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 2, 0, 0, 0)), "OA6405" },
                    { 6, "6SD", "LIMC", new DateTimeOffset(new DateTime(2023, 3, 4, 9, 46, 18, 426, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, 2, 0, 0, 0)), "UKBB", new DateTimeOffset(new DateTime(2023, 3, 3, 16, 34, 5, 598, DateTimeKind.Unspecified).AddTicks(9751), new TimeSpan(0, 2, 0, 0, 0)), "OA2796" },
                    { 7, "86Y", "LIMC", new DateTimeOffset(new DateTime(2023, 2, 26, 10, 58, 9, 55, DateTimeKind.Unspecified).AddTicks(3253), new TimeSpan(0, 2, 0, 0, 0)), "EDDB", new DateTimeOffset(new DateTime(2023, 2, 26, 7, 24, 39, 806, DateTimeKind.Unspecified).AddTicks(9229), new TimeSpan(0, 2, 0, 0, 0)), "OA9510" },
                    { 8, "86Y", "KPHL", new DateTimeOffset(new DateTime(2023, 2, 8, 19, 48, 39, 479, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 2, 0, 0, 0)), "EDDB", new DateTimeOffset(new DateTime(2023, 2, 8, 9, 43, 14, 87, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 2, 0, 0, 0)), "OA5725" },
                    { 9, "86Y", "KPHL", new DateTimeOffset(new DateTime(2023, 2, 24, 23, 2, 59, 479, DateTimeKind.Unspecified).AddTicks(4948), new TimeSpan(0, 2, 0, 0, 0)), "EDDB", new DateTimeOffset(new DateTime(2023, 2, 23, 0, 47, 27, 201, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 2, 0, 0, 0)), "OA5206" },
                    { 10, "7AI", "KPHL", new DateTimeOffset(new DateTime(2023, 3, 1, 18, 43, 1, 953, DateTimeKind.Unspecified).AddTicks(4979), new TimeSpan(0, 2, 0, 0, 0)), "KBMH", new DateTimeOffset(new DateTime(2023, 2, 28, 1, 18, 3, 385, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 2, 0, 0, 0)), "OA2440" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 1, 1, "1A", null },
                    { 2, 1, "2B", null },
                    { 3, 1, "3A", null },
                    { 4, 1, "4B", null },
                    { 5, 1, "5A", null },
                    { 6, 1, "6B", null },
                    { 7, 1, "7A", null },
                    { 8, 1, "8B", null },
                    { 9, 1, "9A", null },
                    { 10, 1, "10B", null },
                    { 11, 1, "11A", null },
                    { 12, 1, "12B", null },
                    { 13, 1, "13A", null },
                    { 14, 1, "14B", null },
                    { 15, 1, "15A", null },
                    { 16, 1, "16B", null },
                    { 17, 1, "17A", null },
                    { 18, 1, "18B", null },
                    { 19, 1, "19A", null },
                    { 20, 1, "20B", null },
                    { 21, 1, "21A", null },
                    { 22, 1, "22B", null },
                    { 23, 1, "23A", null },
                    { 24, 1, "24B", null },
                    { 25, 1, "25A", null },
                    { 26, 1, "26B", null },
                    { 27, 1, "27A", null },
                    { 28, 1, "28B", null },
                    { 29, 1, "29A", null },
                    { 30, 1, "30B", null },
                    { 31, 1, "31A", null },
                    { 32, 1, "32B", null },
                    { 33, 1, "33A", null },
                    { 34, 1, "34B", null },
                    { 35, 1, "35A", null },
                    { 36, 1, "36B", null },
                    { 37, 1, "37A", null },
                    { 38, 1, "38B", null },
                    { 39, 1, "39A", null },
                    { 40, 1, "40B", null },
                    { 41, 1, "41A", null },
                    { 42, 1, "42B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 43, 1, "43A", null },
                    { 44, 1, "44B", null },
                    { 45, 1, "45A", null },
                    { 46, 1, "46B", null },
                    { 47, 1, "47A", null },
                    { 48, 1, "48B", null },
                    { 49, 1, "49A", null },
                    { 50, 1, "50B", null },
                    { 51, 1, "51A", null },
                    { 52, 1, "52B", null },
                    { 53, 1, "53A", null },
                    { 54, 1, "54B", null },
                    { 55, 1, "55A", null },
                    { 56, 1, "56B", null },
                    { 57, 1, "57A", null },
                    { 58, 1, "58B", null },
                    { 59, 1, "59A", null },
                    { 60, 1, "60B", null },
                    { 61, 2, "1A", null },
                    { 62, 2, "2B", null },
                    { 63, 2, "3A", null },
                    { 64, 2, "4B", null },
                    { 65, 2, "5A", null },
                    { 66, 2, "6B", null },
                    { 67, 2, "7A", null },
                    { 68, 2, "8B", null },
                    { 69, 2, "9A", null },
                    { 70, 2, "10B", null },
                    { 71, 2, "11A", null },
                    { 72, 2, "12B", null },
                    { 73, 2, "13A", null },
                    { 74, 2, "14B", null },
                    { 75, 2, "15A", null },
                    { 76, 2, "16B", null },
                    { 77, 2, "17A", null },
                    { 78, 2, "18B", null },
                    { 79, 2, "19A", null },
                    { 80, 2, "20B", null },
                    { 81, 2, "21A", null },
                    { 82, 2, "22B", null },
                    { 83, 2, "23A", null },
                    { 84, 2, "24B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 85, 2, "25A", null },
                    { 86, 2, "26B", null },
                    { 87, 2, "27A", null },
                    { 88, 2, "28B", null },
                    { 89, 2, "29A", null },
                    { 90, 2, "30B", null },
                    { 91, 2, "31A", null },
                    { 92, 2, "32B", null },
                    { 93, 2, "33A", null },
                    { 94, 2, "34B", null },
                    { 95, 2, "35A", null },
                    { 96, 2, "36B", null },
                    { 97, 2, "37A", null },
                    { 98, 2, "38B", null },
                    { 99, 2, "39A", null },
                    { 100, 2, "40B", null },
                    { 101, 2, "41A", null },
                    { 102, 2, "42B", null },
                    { 103, 2, "43A", null },
                    { 104, 2, "44B", null },
                    { 105, 2, "45A", null },
                    { 106, 2, "46B", null },
                    { 107, 2, "47A", null },
                    { 108, 2, "48B", null },
                    { 109, 2, "49A", null },
                    { 110, 2, "50B", null },
                    { 111, 2, "51A", null },
                    { 112, 2, "52B", null },
                    { 113, 2, "53A", null },
                    { 114, 2, "54B", null },
                    { 115, 2, "55A", null },
                    { 116, 2, "56B", null },
                    { 117, 2, "57A", null },
                    { 118, 2, "58B", null },
                    { 119, 2, "59A", null },
                    { 120, 2, "60B", null },
                    { 121, 3, "1A", null },
                    { 122, 3, "2B", null },
                    { 123, 3, "3A", null },
                    { 124, 3, "4B", null },
                    { 125, 3, "5A", null },
                    { 126, 3, "6B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 127, 3, "7A", null },
                    { 128, 3, "8B", null },
                    { 129, 3, "9A", null },
                    { 130, 3, "10B", null },
                    { 131, 3, "11A", null },
                    { 132, 3, "12B", null },
                    { 133, 3, "13A", null },
                    { 134, 3, "14B", null },
                    { 135, 3, "15A", null },
                    { 136, 3, "16B", null },
                    { 137, 3, "17A", null },
                    { 138, 3, "18B", null },
                    { 139, 3, "19A", null },
                    { 140, 3, "20B", null },
                    { 141, 3, "21A", null },
                    { 142, 3, "22B", null },
                    { 143, 3, "23A", null },
                    { 144, 3, "24B", null },
                    { 145, 3, "25A", null },
                    { 146, 3, "26B", null },
                    { 147, 3, "27A", null },
                    { 148, 3, "28B", null },
                    { 149, 3, "29A", null },
                    { 150, 3, "30B", null },
                    { 151, 3, "31A", null },
                    { 152, 3, "32B", null },
                    { 153, 3, "33A", null },
                    { 154, 3, "34B", null },
                    { 155, 3, "35A", null },
                    { 156, 3, "36B", null },
                    { 157, 3, "37A", null },
                    { 158, 3, "38B", null },
                    { 159, 3, "39A", null },
                    { 160, 3, "40B", null },
                    { 161, 3, "41A", null },
                    { 162, 3, "42B", null },
                    { 163, 3, "43A", null },
                    { 164, 3, "44B", null },
                    { 165, 3, "45A", null },
                    { 166, 3, "46B", null },
                    { 167, 3, "47A", null },
                    { 168, 3, "48B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 169, 3, "49A", null },
                    { 170, 3, "50B", null },
                    { 171, 3, "51A", null },
                    { 172, 3, "52B", null },
                    { 173, 3, "53A", null },
                    { 174, 3, "54B", null },
                    { 175, 3, "55A", null },
                    { 176, 3, "56B", null },
                    { 177, 3, "57A", null },
                    { 178, 3, "58B", null },
                    { 179, 3, "59A", null },
                    { 180, 3, "60B", null },
                    { 181, 4, "1A", null },
                    { 182, 4, "2B", null },
                    { 183, 4, "3A", null },
                    { 184, 4, "4B", null },
                    { 185, 4, "5A", null },
                    { 186, 4, "6B", null },
                    { 187, 4, "7A", null },
                    { 188, 4, "8B", null },
                    { 189, 4, "9A", null },
                    { 190, 4, "10B", null },
                    { 191, 4, "11A", null },
                    { 192, 4, "12B", null },
                    { 193, 4, "13A", null },
                    { 194, 4, "14B", null },
                    { 195, 4, "15A", null },
                    { 196, 4, "16B", null },
                    { 197, 4, "17A", null },
                    { 198, 4, "18B", null },
                    { 199, 4, "19A", null },
                    { 200, 4, "20B", null },
                    { 201, 4, "21A", null },
                    { 202, 4, "22B", null },
                    { 203, 4, "23A", null },
                    { 204, 4, "24B", null },
                    { 205, 4, "25A", null },
                    { 206, 4, "26B", null },
                    { 207, 4, "27A", null },
                    { 208, 4, "28B", null },
                    { 209, 4, "29A", null },
                    { 210, 4, "30B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 211, 4, "31A", null },
                    { 212, 4, "32B", null },
                    { 213, 4, "33A", null },
                    { 214, 4, "34B", null },
                    { 215, 4, "35A", null },
                    { 216, 4, "36B", null },
                    { 217, 4, "37A", null },
                    { 218, 4, "38B", null },
                    { 219, 4, "39A", null },
                    { 220, 4, "40B", null },
                    { 221, 4, "41A", null },
                    { 222, 4, "42B", null },
                    { 223, 4, "43A", null },
                    { 224, 4, "44B", null },
                    { 225, 4, "45A", null },
                    { 226, 4, "46B", null },
                    { 227, 4, "47A", null },
                    { 228, 4, "48B", null },
                    { 229, 4, "49A", null },
                    { 230, 4, "50B", null },
                    { 231, 4, "51A", null },
                    { 232, 4, "52B", null },
                    { 233, 4, "53A", null },
                    { 234, 4, "54B", null },
                    { 235, 4, "55A", null },
                    { 236, 4, "56B", null },
                    { 237, 4, "57A", null },
                    { 238, 4, "58B", null },
                    { 239, 4, "59A", null },
                    { 240, 4, "60B", null },
                    { 241, 5, "1A", null },
                    { 242, 5, "2B", null },
                    { 243, 5, "3A", null },
                    { 244, 5, "4B", null },
                    { 245, 5, "5A", null },
                    { 246, 5, "6B", null },
                    { 247, 5, "7A", null },
                    { 248, 5, "8B", null },
                    { 249, 5, "9A", null },
                    { 250, 5, "10B", null },
                    { 251, 5, "11A", null },
                    { 252, 5, "12B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 253, 5, "13A", null },
                    { 254, 5, "14B", null },
                    { 255, 5, "15A", null },
                    { 256, 5, "16B", null },
                    { 257, 5, "17A", null },
                    { 258, 5, "18B", null },
                    { 259, 5, "19A", null },
                    { 260, 5, "20B", null },
                    { 261, 5, "21A", null },
                    { 262, 5, "22B", null },
                    { 263, 5, "23A", null },
                    { 264, 5, "24B", null },
                    { 265, 5, "25A", null },
                    { 266, 5, "26B", null },
                    { 267, 5, "27A", null },
                    { 268, 5, "28B", null },
                    { 269, 5, "29A", null },
                    { 270, 5, "30B", null },
                    { 271, 5, "31A", null },
                    { 272, 5, "32B", null },
                    { 273, 5, "33A", null },
                    { 274, 5, "34B", null },
                    { 275, 5, "35A", null },
                    { 276, 5, "36B", null },
                    { 277, 5, "37A", null },
                    { 278, 5, "38B", null },
                    { 279, 5, "39A", null },
                    { 280, 5, "40B", null },
                    { 281, 5, "41A", null },
                    { 282, 5, "42B", null },
                    { 283, 5, "43A", null },
                    { 284, 5, "44B", null },
                    { 285, 5, "45A", null },
                    { 286, 5, "46B", null },
                    { 287, 5, "47A", null },
                    { 288, 5, "48B", null },
                    { 289, 5, "49A", null },
                    { 290, 5, "50B", null },
                    { 291, 5, "51A", null },
                    { 292, 5, "52B", null },
                    { 293, 5, "53A", null },
                    { 294, 5, "54B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 295, 5, "55A", null },
                    { 296, 5, "56B", null },
                    { 297, 5, "57A", null },
                    { 298, 5, "58B", null },
                    { 299, 5, "59A", null },
                    { 300, 5, "60B", null },
                    { 301, 6, "1A", null },
                    { 302, 6, "2B", null },
                    { 303, 6, "3A", null },
                    { 304, 6, "4B", null },
                    { 305, 6, "5A", null },
                    { 306, 6, "6B", null },
                    { 307, 6, "7A", null },
                    { 308, 6, "8B", null },
                    { 309, 6, "9A", null },
                    { 310, 6, "10B", null },
                    { 311, 6, "11A", null },
                    { 312, 6, "12B", null },
                    { 313, 6, "13A", null },
                    { 314, 6, "14B", null },
                    { 315, 6, "15A", null },
                    { 316, 6, "16B", null },
                    { 317, 6, "17A", null },
                    { 318, 6, "18B", null },
                    { 319, 6, "19A", null },
                    { 320, 6, "20B", null },
                    { 321, 6, "21A", null },
                    { 322, 6, "22B", null },
                    { 323, 6, "23A", null },
                    { 324, 6, "24B", null },
                    { 325, 6, "25A", null },
                    { 326, 6, "26B", null },
                    { 327, 6, "27A", null },
                    { 328, 6, "28B", null },
                    { 329, 6, "29A", null },
                    { 330, 6, "30B", null },
                    { 331, 6, "31A", null },
                    { 332, 6, "32B", null },
                    { 333, 6, "33A", null },
                    { 334, 6, "34B", null },
                    { 335, 6, "35A", null },
                    { 336, 6, "36B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 337, 6, "37A", null },
                    { 338, 6, "38B", null },
                    { 339, 6, "39A", null },
                    { 340, 6, "40B", null },
                    { 341, 6, "41A", null },
                    { 342, 6, "42B", null },
                    { 343, 6, "43A", null },
                    { 344, 6, "44B", null },
                    { 345, 6, "45A", null },
                    { 346, 6, "46B", null },
                    { 347, 6, "47A", null },
                    { 348, 6, "48B", null },
                    { 349, 6, "49A", null },
                    { 350, 6, "50B", null },
                    { 351, 6, "51A", null },
                    { 352, 6, "52B", null },
                    { 353, 6, "53A", null },
                    { 354, 6, "54B", null },
                    { 355, 6, "55A", null },
                    { 356, 6, "56B", null },
                    { 357, 6, "57A", null },
                    { 358, 6, "58B", null },
                    { 359, 6, "59A", null },
                    { 360, 6, "60B", null },
                    { 361, 7, "1A", null },
                    { 362, 7, "2B", null },
                    { 363, 7, "3A", null },
                    { 364, 7, "4B", null },
                    { 365, 7, "5A", null },
                    { 366, 7, "6B", null },
                    { 367, 7, "7A", null },
                    { 368, 7, "8B", null },
                    { 369, 7, "9A", null },
                    { 370, 7, "10B", null },
                    { 371, 7, "11A", null },
                    { 372, 7, "12B", null },
                    { 373, 7, "13A", null },
                    { 374, 7, "14B", null },
                    { 375, 7, "15A", null },
                    { 376, 7, "16B", null },
                    { 377, 7, "17A", null },
                    { 378, 7, "18B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 379, 7, "19A", null },
                    { 380, 7, "20B", null },
                    { 381, 7, "21A", null },
                    { 382, 7, "22B", null },
                    { 383, 7, "23A", null },
                    { 384, 7, "24B", null },
                    { 385, 7, "25A", null },
                    { 386, 7, "26B", null },
                    { 387, 7, "27A", null },
                    { 388, 7, "28B", null },
                    { 389, 7, "29A", null },
                    { 390, 7, "30B", null },
                    { 391, 7, "31A", null },
                    { 392, 7, "32B", null },
                    { 393, 7, "33A", null },
                    { 394, 7, "34B", null },
                    { 395, 7, "35A", null },
                    { 396, 7, "36B", null },
                    { 397, 7, "37A", null },
                    { 398, 7, "38B", null },
                    { 399, 7, "39A", null },
                    { 400, 7, "40B", null },
                    { 401, 7, "41A", null },
                    { 402, 7, "42B", null },
                    { 403, 7, "43A", null },
                    { 404, 7, "44B", null },
                    { 405, 7, "45A", null },
                    { 406, 7, "46B", null },
                    { 407, 7, "47A", null },
                    { 408, 7, "48B", null },
                    { 409, 7, "49A", null },
                    { 410, 7, "50B", null },
                    { 411, 7, "51A", null },
                    { 412, 7, "52B", null },
                    { 413, 7, "53A", null },
                    { 414, 7, "54B", null },
                    { 415, 7, "55A", null },
                    { 416, 7, "56B", null },
                    { 417, 7, "57A", null },
                    { 418, 7, "58B", null },
                    { 419, 7, "59A", null },
                    { 420, 7, "60B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 421, 8, "1A", null },
                    { 422, 8, "2B", null },
                    { 423, 8, "3A", null },
                    { 424, 8, "4B", null },
                    { 425, 8, "5A", null },
                    { 426, 8, "6B", null },
                    { 427, 8, "7A", null },
                    { 428, 8, "8B", null },
                    { 429, 8, "9A", null },
                    { 430, 8, "10B", null },
                    { 431, 8, "11A", null },
                    { 432, 8, "12B", null },
                    { 433, 8, "13A", null },
                    { 434, 8, "14B", null },
                    { 435, 8, "15A", null },
                    { 436, 8, "16B", null },
                    { 437, 8, "17A", null },
                    { 438, 8, "18B", null },
                    { 439, 8, "19A", null },
                    { 440, 8, "20B", null },
                    { 441, 8, "21A", null },
                    { 442, 8, "22B", null },
                    { 443, 8, "23A", null },
                    { 444, 8, "24B", null },
                    { 445, 8, "25A", null },
                    { 446, 8, "26B", null },
                    { 447, 8, "27A", null },
                    { 448, 8, "28B", null },
                    { 449, 8, "29A", null },
                    { 450, 8, "30B", null },
                    { 451, 8, "31A", null },
                    { 452, 8, "32B", null },
                    { 453, 8, "33A", null },
                    { 454, 8, "34B", null },
                    { 455, 8, "35A", null },
                    { 456, 8, "36B", null },
                    { 457, 8, "37A", null },
                    { 458, 8, "38B", null },
                    { 459, 8, "39A", null },
                    { 460, 8, "40B", null },
                    { 461, 8, "41A", null },
                    { 462, 8, "42B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 463, 8, "43A", null },
                    { 464, 8, "44B", null },
                    { 465, 8, "45A", null },
                    { 466, 8, "46B", null },
                    { 467, 8, "47A", null },
                    { 468, 8, "48B", null },
                    { 469, 8, "49A", null },
                    { 470, 8, "50B", null },
                    { 471, 8, "51A", null },
                    { 472, 8, "52B", null },
                    { 473, 8, "53A", null },
                    { 474, 8, "54B", null },
                    { 475, 8, "55A", null },
                    { 476, 8, "56B", null },
                    { 477, 8, "57A", null },
                    { 478, 8, "58B", null },
                    { 479, 8, "59A", null },
                    { 480, 8, "60B", null },
                    { 481, 9, "1A", null },
                    { 482, 9, "2B", null },
                    { 483, 9, "3A", null },
                    { 484, 9, "4B", null },
                    { 485, 9, "5A", null },
                    { 486, 9, "6B", null },
                    { 487, 9, "7A", null },
                    { 488, 9, "8B", null },
                    { 489, 9, "9A", null },
                    { 490, 9, "10B", null },
                    { 491, 9, "11A", null },
                    { 492, 9, "12B", null },
                    { 493, 9, "13A", null },
                    { 494, 9, "14B", null },
                    { 495, 9, "15A", null },
                    { 496, 9, "16B", null },
                    { 497, 9, "17A", null },
                    { 498, 9, "18B", null },
                    { 499, 9, "19A", null },
                    { 500, 9, "20B", null },
                    { 501, 9, "21A", null },
                    { 502, 9, "22B", null },
                    { 503, 9, "23A", null },
                    { 504, 9, "24B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 505, 9, "25A", null },
                    { 506, 9, "26B", null },
                    { 507, 9, "27A", null },
                    { 508, 9, "28B", null },
                    { 509, 9, "29A", null },
                    { 510, 9, "30B", null },
                    { 511, 9, "31A", null },
                    { 512, 9, "32B", null },
                    { 513, 9, "33A", null },
                    { 514, 9, "34B", null },
                    { 515, 9, "35A", null },
                    { 516, 9, "36B", null },
                    { 517, 9, "37A", null },
                    { 518, 9, "38B", null },
                    { 519, 9, "39A", null },
                    { 520, 9, "40B", null },
                    { 521, 9, "41A", null },
                    { 522, 9, "42B", null },
                    { 523, 9, "43A", null },
                    { 524, 9, "44B", null },
                    { 525, 9, "45A", null },
                    { 526, 9, "46B", null },
                    { 527, 9, "47A", null },
                    { 528, 9, "48B", null },
                    { 529, 9, "49A", null },
                    { 530, 9, "50B", null },
                    { 531, 9, "51A", null },
                    { 532, 9, "52B", null },
                    { 533, 9, "53A", null },
                    { 534, 9, "54B", null },
                    { 535, 9, "55A", null },
                    { 536, 9, "56B", null },
                    { 537, 9, "57A", null },
                    { 538, 9, "58B", null },
                    { 539, 9, "59A", null },
                    { 540, 9, "60B", null },
                    { 541, 10, "1A", null },
                    { 542, 10, "2B", null },
                    { 543, 10, "3A", null },
                    { 544, 10, "4B", null },
                    { 545, 10, "5A", null },
                    { 546, 10, "6B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 547, 10, "7A", null },
                    { 548, 10, "8B", null },
                    { 549, 10, "9A", null },
                    { 550, 10, "10B", null },
                    { 551, 10, "11A", null },
                    { 552, 10, "12B", null },
                    { 553, 10, "13A", null },
                    { 554, 10, "14B", null },
                    { 555, 10, "15A", null },
                    { 556, 10, "16B", null },
                    { 557, 10, "17A", null },
                    { 558, 10, "18B", null },
                    { 559, 10, "19A", null },
                    { 560, 10, "20B", null },
                    { 561, 10, "21A", null },
                    { 562, 10, "22B", null },
                    { 563, 10, "23A", null },
                    { 564, 10, "24B", null },
                    { 565, 10, "25A", null },
                    { 566, 10, "26B", null },
                    { 567, 10, "27A", null },
                    { 568, 10, "28B", null },
                    { 569, 10, "29A", null },
                    { 570, 10, "30B", null },
                    { 571, 10, "31A", null },
                    { 572, 10, "32B", null },
                    { 573, 10, "33A", null },
                    { 574, 10, "34B", null },
                    { 575, 10, "35A", null },
                    { 576, 10, "36B", null },
                    { 577, 10, "37A", null },
                    { 578, 10, "38B", null },
                    { 579, 10, "39A", null },
                    { 580, 10, "40B", null },
                    { 581, 10, "41A", null },
                    { 582, 10, "42B", null },
                    { 583, 10, "43A", null },
                    { 584, 10, "44B", null },
                    { 585, 10, "45A", null },
                    { 586, 10, "46B", null },
                    { 587, 10, "47A", null },
                    { 588, 10, "48B", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "FlightId", "SeatNumber", "TicketId" },
                values: new object[,]
                {
                    { 589, 10, "49A", null },
                    { 590, 10, "50B", null },
                    { 591, 10, "51A", null },
                    { 592, 10, "52B", null },
                    { 593, 10, "53A", null },
                    { 594, 10, "54B", null },
                    { 595, 10, "55A", null },
                    { 596, 10, "56B", null },
                    { 597, 10, "57A", null },
                    { 598, 10, "58B", null },
                    { 599, 10, "59A", null },
                    { 600, 10, "60B", null }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ClientId", "FlightId", "SeatId", "SellDate" },
                values: new object[,]
                {
                    { 1, 14, 1, 12, new DateTimeOffset(new DateTime(2023, 1, 19, 10, 20, 59, 185, DateTimeKind.Unspecified).AddTicks(4922), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 2, 9, 1, 24, new DateTimeOffset(new DateTime(2023, 1, 23, 9, 23, 11, 296, DateTimeKind.Unspecified).AddTicks(328), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 3, 17, 1, 36, new DateTimeOffset(new DateTime(2023, 1, 17, 2, 58, 46, 544, DateTimeKind.Unspecified).AddTicks(4128), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 4, 11, 1, 48, new DateTimeOffset(new DateTime(2023, 1, 26, 5, 52, 3, 488, DateTimeKind.Unspecified).AddTicks(4912), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 5, 3, 1, 60, new DateTimeOffset(new DateTime(2023, 1, 21, 23, 18, 42, 720, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 6, 14, 2, 72, new DateTimeOffset(new DateTime(2023, 1, 16, 5, 28, 3, 877, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 7, 2, 2, 84, new DateTimeOffset(new DateTime(2023, 1, 19, 3, 40, 46, 368, DateTimeKind.Unspecified).AddTicks(7842), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 8, 19, 2, 96, new DateTimeOffset(new DateTime(2023, 1, 25, 1, 40, 50, 553, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 9, 12, 2, 108, new DateTimeOffset(new DateTime(2023, 1, 11, 0, 24, 41, 74, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 10, 10, 2, 120, new DateTimeOffset(new DateTime(2023, 1, 28, 1, 27, 6, 327, DateTimeKind.Unspecified).AddTicks(573), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 11, 11, 3, 132, new DateTimeOffset(new DateTime(2023, 2, 3, 16, 0, 24, 968, DateTimeKind.Unspecified).AddTicks(56), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 12, 17, 3, 144, new DateTimeOffset(new DateTime(2023, 1, 24, 8, 19, 46, 939, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 13, 8, 3, 156, new DateTimeOffset(new DateTime(2023, 2, 6, 23, 29, 31, 341, DateTimeKind.Unspecified).AddTicks(5524), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 14, 1, 3, 168, new DateTimeOffset(new DateTime(2023, 1, 13, 22, 16, 11, 849, DateTimeKind.Unspecified).AddTicks(8781), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 15, 16, 3, 180, new DateTimeOffset(new DateTime(2023, 1, 19, 18, 37, 37, 960, DateTimeKind.Unspecified).AddTicks(4334), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 16, 4, 4, 192, new DateTimeOffset(new DateTime(2023, 1, 30, 15, 13, 40, 180, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 17, 2, 4, 204, new DateTimeOffset(new DateTime(2023, 1, 16, 5, 47, 38, 911, DateTimeKind.Unspecified).AddTicks(3268), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 18, 16, 4, 216, new DateTimeOffset(new DateTime(2023, 1, 11, 14, 7, 45, 87, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 19, 20, 4, 228, new DateTimeOffset(new DateTime(2023, 1, 31, 14, 18, 33, 220, DateTimeKind.Unspecified).AddTicks(109), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 20, 11, 4, 240, new DateTimeOffset(new DateTime(2023, 1, 27, 7, 4, 47, 199, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 21, 9, 5, 252, new DateTimeOffset(new DateTime(2023, 1, 28, 16, 2, 59, 138, DateTimeKind.Unspecified).AddTicks(5572), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 22, 4, 5, 264, new DateTimeOffset(new DateTime(2023, 1, 12, 21, 39, 13, 161, DateTimeKind.Unspecified).AddTicks(6654), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 23, 12, 5, 276, new DateTimeOffset(new DateTime(2023, 1, 23, 11, 18, 10, 981, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 24, 4, 5, 288, new DateTimeOffset(new DateTime(2023, 1, 15, 8, 38, 8, 783, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 25, 5, 5, 300, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 46, 4, 661, DateTimeKind.Unspecified).AddTicks(7016), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 26, 5, 6, 312, new DateTimeOffset(new DateTime(2023, 1, 28, 22, 59, 3, 399, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 27, 12, 6, 324, new DateTimeOffset(new DateTime(2023, 1, 9, 0, 52, 13, 5, DateTimeKind.Unspecified).AddTicks(1183), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 28, 11, 6, 336, new DateTimeOffset(new DateTime(2023, 1, 22, 6, 8, 35, 802, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 29, 12, 6, 348, new DateTimeOffset(new DateTime(2023, 1, 14, 20, 37, 54, 234, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 30, 2, 6, 360, new DateTimeOffset(new DateTime(2023, 1, 19, 15, 56, 37, 178, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 31, 12, 7, 372, new DateTimeOffset(new DateTime(2023, 1, 26, 15, 49, 18, 298, DateTimeKind.Unspecified).AddTicks(3902), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 32, 8, 7, 384, new DateTimeOffset(new DateTime(2023, 1, 29, 21, 4, 40, 308, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 33, 3, 7, 396, new DateTimeOffset(new DateTime(2023, 1, 21, 5, 30, 51, 165, DateTimeKind.Unspecified).AddTicks(5796), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 34, 16, 7, 408, new DateTimeOffset(new DateTime(2023, 1, 22, 11, 46, 21, 97, DateTimeKind.Unspecified).AddTicks(3444), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 35, 8, 7, 420, new DateTimeOffset(new DateTime(2023, 1, 9, 15, 8, 49, 317, DateTimeKind.Unspecified).AddTicks(1877), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 36, 18, 8, 432, new DateTimeOffset(new DateTime(2023, 1, 24, 6, 52, 22, 695, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 37, 17, 8, 444, new DateTimeOffset(new DateTime(2023, 2, 4, 13, 0, 5, 526, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 38, 10, 8, 456, new DateTimeOffset(new DateTime(2023, 1, 18, 0, 37, 40, 297, DateTimeKind.Unspecified).AddTicks(6299), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 39, 9, 8, 468, new DateTimeOffset(new DateTime(2023, 1, 25, 23, 17, 49, 644, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 40, 15, 8, 480, new DateTimeOffset(new DateTime(2023, 1, 20, 4, 21, 25, 471, DateTimeKind.Unspecified).AddTicks(1799), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 41, 19, 9, 492, new DateTimeOffset(new DateTime(2023, 1, 29, 4, 31, 32, 53, DateTimeKind.Unspecified).AddTicks(308), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 42, 16, 9, 504, new DateTimeOffset(new DateTime(2023, 1, 20, 1, 17, 8, 942, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 2, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ClientId", "FlightId", "SeatId", "SellDate" },
                values: new object[,]
                {
                    { 43, 8, 9, 516, new DateTimeOffset(new DateTime(2023, 1, 24, 6, 37, 11, 733, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 44, 14, 9, 528, new DateTimeOffset(new DateTime(2023, 1, 30, 4, 38, 50, 46, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 45, 2, 9, 540, new DateTimeOffset(new DateTime(2023, 1, 31, 3, 5, 0, 366, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 46, 11, 10, 552, new DateTimeOffset(new DateTime(2023, 1, 8, 18, 29, 0, 12, DateTimeKind.Unspecified).AddTicks(1660), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 47, 16, 10, 564, new DateTimeOffset(new DateTime(2023, 1, 15, 13, 17, 5, 341, DateTimeKind.Unspecified).AddTicks(8304), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 48, 8, 10, 576, new DateTimeOffset(new DateTime(2023, 1, 9, 23, 50, 34, 70, DateTimeKind.Unspecified).AddTicks(1258), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 49, 13, 10, 588, new DateTimeOffset(new DateTime(2023, 1, 29, 19, 34, 2, 334, DateTimeKind.Unspecified).AddTicks(3992), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 50, 14, 10, 600, new DateTimeOffset(new DateTime(2023, 1, 25, 0, 20, 48, 474, DateTimeKind.Unspecified).AddTicks(6117), new TimeSpan(0, 2, 0, 0, 0)) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Aircraft_AircraftCode",
                table: "Flights",
                column: "AircraftCode",
                principalTable: "Aircraft",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Aircraft_AircraftCode",
                table: "Flights");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Code",
                keyValue: "6SD");

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Code",
                keyValue: "7AI");

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Code",
                keyValue: "86Y");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Code",
                keyValue: "EDDB");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Code",
                keyValue: "KBMH");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Code",
                keyValue: "KPHL");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Code",
                keyValue: "LIMC");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Code",
                keyValue: "PAR");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Code",
                keyValue: "UKBB");

            migrationBuilder.DropColumn(
                name: "SellDate",
                table: "Tickets");

            migrationBuilder.AddColumn<bool>(
                name: "IsBooked",
                table: "Seats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Aircraft_AircraftCode",
                table: "Flights",
                column: "AircraftCode",
                principalTable: "Aircraft",
                principalColumn: "Code");
        }
    }
}

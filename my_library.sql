-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2021 at 07:28 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `my_library`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(8) NOT NULL,
  `username` varchar(33) NOT NULL,
  `password` varchar(32) NOT NULL,
  `first_name` varchar(32) NOT NULL,
  `last_name` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `username`, `password`, `first_name`, `last_name`) VALUES
(1, 'admin123', 'admin123', 'Bob', 'Admin Tertampan'),
(2, 'erickyudha', '123456', 'Erick', 'Yudha'),
(3, 'testaccount2', '123456', 'test', 'account2');

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE `authors` (
  `author_id` varchar(15) NOT NULL,
  `name` varchar(33) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`author_id`, `name`) VALUES
('056', 'Wilson Bangun'),
('110', 'Almira Bastari'),
('112', 'Leila S Chudori'),
('117', 'Lexie Xu'),
('121', 'Tere Liye'),
('215', 'Dini Salim'),
('225', 'Sylvian Neuvel'),
('233', 'Sara Wijayanto'),
('242', 'Ilana Tan'),
('259', 'Inggrid Sonya'),
('318', 'Agatha Christie'),
('327', 'Dee Lestari'),
('433', 'Andrea Hirata');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `isbn` varchar(20) NOT NULL,
  `title` varchar(100) NOT NULL,
  `publisher_id` varchar(15) NOT NULL,
  `author_id` varchar(15) NOT NULL,
  `publish_year` int(4) NOT NULL,
  `description` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`isbn`, `title`, `publisher_id`, `author_id`, `publish_year`, `description`) VALUES
('9786020301891', 'Omen#4 : Malam Karnaval Berdarah', '063', '117', 2014, 'File 4 : Kasus Perusakan Wajah Anggota OSIS SMA Harapan Nusantara di Malam Karnaval. Tertuduh: Kelompok Radikal Anti-Judges. Tidak diketahui siapa sebenarnya anggota kelompok yang namanya jelek banget ini, meski kami punya dugaan kuat: Erika Guruh dan Valeria Guntur, dua anggota The Judges yang membelot lantaran tidak menyetujui kebijakan-kebijakan OSIS. Tambahan lagi, mereka berdua adalah kombinasi paling mematikan di sekolah kami yang sanggup melawan Putri Badai si Hakim Tertinggi, yang punya minion-minion berupa ketua OSIS yang punya kemampuan misterius dan wakilnya yang berandalan, alias kami berdua.'),
('9786020312934', 'Johan Series #1: Obsesi', '063', '117', 2015, 'Halo, namaku Jenny Angkasa dan hidupku saat ini bagaikan deretan mimpi buruk.\r\nPertama-tama, aku dimusuhi Hanny, cewek paling populer di sekolah yang tadinya adalah sahabatku satu-satunya. Mantan sohibku itu kini menganggapku lebih rendah daripada amuba, bahkan aku dikutuk untuk menjalani hidup sial selamanya.'),
('9786020312941', 'Johan Series #2: Pengurus MOS Harus Mati', '063', '117', 2015, 'Hai, namaku Hanny Pelangi, dan hidupku saat ini bagaikan sederetan mimpi buruk.\r\nAwalnya semua terlihat luar biasa. Aku sedang menikmati liburan yang menyenangkan bersama sahabatku, Jenny, di Singapura saat aku diminta pulang oleh pacar baruku, Benji, sang ketua OSIS, lantaran aku terpilih menjadi salah satu pengurus MOS. Wow! Terpilih menjadi anggota tim elite dan mendapat kesempatan menyiksa murid-murid baru? Siapa yang tidak mau?'),
('9786020312958', 'Johan Series #3: Permainan Maut', '063', '117', 2015, 'Yo, namaku Tony Senjakala dan hidupku saat ini bagaikan sederetan mimpi buruk.\r\nSebuah e-mail dari teman lamaku—tentang kejadian-kejadian misterius di rumahnya—terus mengusik pikiranku. Tetapi, aku berusaha melupakannya karena sudah tidak sabar lagi untuk berlibur dengan Jenny, pacarku yang manis banget.'),
('9786020312965', 'Johan Series #4: Teror', '063', '117', 2015, 'Namaku Johan, dan akulah penyebab mimpi buruk semua orang.\r\nSemua orang selalu meremehkanku, mulai dari ibuku hingga anak-anak tolol di sekolahku, dan aku selalu berhasil memberi mereka pelajaran bahwa aku tidak bisa diremehkan. Tentu, beberapa akibatnya tak kuduga, seperti aku telah menewaskan ibuku dan beberapa kecelakaan lain, tapi itu harga yang harus kubayar demi menegakkan harga diriku.\r\nHidupku berubah drastis sejak aku bertemu Jenny, cewek yang sudah merebut rumah masa kecilku. Bukan saja itu kesalahan yang dilakukannya, melainkan juga ternyata dia berteman dengan cewek cantik yang seharusnya menjadi teman atau, lebih baik lagi, pacarku. Aku bertekad akan menghukum Jenny. Namun kebalikan dari harapanku, akulah yang dijebloskan ke rumah sakit jiwa.'),
('9786020314624', 'In a Blue Moon', '063', '242', 2015, 'Lucas Ford pertama kali bertemu dengan Sophie Wilson di\r\nbulan Desember pada tahun terakhir SMA-nya. Gadis itu\r\nmembencinya. Lucas kembali bertemu dengan Sophie di\r\nbulan Desember sepuluh tahun kemudian di kota New York.\r\nGadis itu masih membencinya. Masalah utamanya bukan\r\nitu—oh, bukan!—melainkan kenyataan bahwa gadis yang\r\nmembencinya itu kini ditetapkan sebagai tunangan Lucas\r\noleh kakeknya yang suka ikut campur.'),
('9786020318776', 'Omen #7: Target Terakhir', '063', '117', 2015, 'Tertuduh: Siapa lagi kalau bukan Nikki si cewek bermulut nyaris sobek dan ibu angkatnya yang psikopat? Kali ini mereka mengajak satu oknum lain, yaitu Arman, pacar baru Nikki yang rupanya tidak kalah jahatnya dibanding Nikki. Selain itu, lagi-lagi mereka membawa geng motor Rapid Fire yang anggotanya tinggal separuh lantaran sebagian besar dari mereka dikirim ke rumah sakit oleh si Obeng… maksudku, Les.'),
('9786020324784', 'Hujan', '063', '121', 2018, 'Novel HUJAN berkisah tentang persahabatan, tentang cinta, tentang perpisahan, tentang melupakan, dan tentang hujan...'),
('9786020332055', 'Young Adult: Rahasia Tergelap', '063', '117', 2016, 'Giselle tidak pernah menyangka Merly akan mengakhiri hidupnya dengan terjun dari atap gedung kampus. Setahu Giselle, Merly termasuk cewek ceria yang tak pernah punya masalah, tapi kenapa cewek itu bunuh diri?'),
('9786020332956', 'Bumi', '063', '121', 2016, 'Bumi, merupakan rangkaian awal dari kisah sekelompok anak remaja berkemampuan istimewa. Mereka yang istimewa, mampu pergi ke dunia pararel bumi, bertemu dengan klan lain dan berhadapan dengan Tamus yang memiliki ambisi membebaskan si Tanpa Mahkota dan kemudian, menguasai bumi.\r\n\r\n\r\nPerkenalkan, Raib, seorang gadis belia berusia lima belas tahun yang tidak biasa. Dia bisa menghilang. Jangan beritahu siapapun, Itu adalah rahasia terbesar yang tak pernah ia ceritakan pada siapapun, termasuk kedua orangtuanya.\r\nKehidupannya tetap berjalan normal, meskipun untuk dirinya sendiri. tidak jarang Raib menjahili orangtuanya dengan tiba-tiba menghilang, lalu muncul kembali secara tiba-tiba membuat kaget kedua orangtuanya.'),
('9786020351179', 'Bintang', '063', '121', 2017, 'Namaku Raib, aku bisa menghilang. Seli, teman semejaku, bisa mengeluarkan petir dari telapak tangannya. Dan Ali, si biang kerok sekaligus si genius, bisa berubah menjadi beruang raksasa. Kami bertiga kemudian bertualang ke dunia paralel yang tidak diketahui banyak orang, yang disebut Klan Bumi, Klan Bulan, Klan Matahari, dan Klan Bintang. Kami bertemu tokoh-tokoh hebat. Penduduk klan lain.'),
('9786020362106', 'Negeri di Ujung Tanduk', '063', '112', 2013, 'Di Negeri di Ujung Tanduk kehidupan semakin rusak, bukan karena orang jahat semakin banyak, tapi semakin banyak orang yang memilih tidak peduli lagi.\r\n\r\nDi Negeri di Ujung Tanduk, para penipu menjadi pemimpin, para pengkhianat menjadi pujaan, bukan karena tidak ada lagi yang memiliki teladan, tapi mereka memutuskan menutup mata dan memilih hidup bahagia sendirian.\r\n\r\nTapi di Negeri di Ujung Tanduk setidaknya, kawan, seorang petarung sejati akan memilih jalan suci, meski habis seluruh darah di badan, menguap segenap air mata, dia akan berdiri paling akhir, demi membela kehormatan.'),
('9786020367736', 'Young Adult: Dark Series#2: Perburuan dalam Kegelapan', '063', '117', 2017, 'Trisha tidak pernah suka dengan Grey, MVP tim futsal sekaligus cowok paling berisik yang pernah dia kenal. Namun, semuanya berubah saat cowok itu mendampinginya pada waktu paling sulit dalam hidupnya, yaitu saat teman satu kos sekaligus sahabatnya, Lely, terbunuh akibat gang rape. Bersama Grey dan teman-temannya, Trisha mulai menyelidiki satu per satu orang yang menjadi sasaran kecurigaan mereka. Pertama, Johan si anak bekas tim futsal yang mendadak muncul di TKP. Kedua, Mariko—teman satu kos yang misterius dan mengaku-ngaku sebagai pacar Johan. Lalu tiba-tiba Tari, sahabat Trisha yang lain, mendadak bertingkah aneh.'),
('9786020380711', 'Resign!', '063', '110', 2017, 'Kompetisi sengit terjadi di sebuah kantor konsultan di Jakarta. Pesertanya adalah para cungpret, alias kacung kampret. Yang mereka incar bukanlah penghargaan pegawai terbaik, jabatan tertinggi, atau bonus terbesar, melainkan memenangkan taruhan untuk segera resign!'),
('9786020385471', 'Death On The Nile (Pembunuhan Di Sungai Nil)', '063', '318', 2018, 'Gadis itu terbaring miring. Posisinya wajar dan tenang. Tapi di atas telinganya ada lubang kecil dengan bekas darah kering di sekelilingnya. Kemudian pandangan Poirot tertuju pada dinding putih di depannya dan ia menarik napas dalam-dalam.\r\n\r\nDinding putih bersih itu dikotori huruf \"J\" berwarna merah kecokelat-cokelatan yang ditulis dengan gemetar. Poirot membungkuk di atas mayat gadis itu dan dengan hati-hati mengangkat tangan kanan si gadis. Salah satu jarinya bernoda merah kecokelatan...'),
('9786020388823', 'Satu, Dua, Pasang Gesper Sepatunya', '063', '318', 2017, 'Pagi itu adalah pagi yang tidak mungkin dilupakan oleh Hercule Poirot. Pagi ketika ia tidak mampu merasa lebih unggul daripada orang lain dalam hal apa pun. Pendeknya, pagi itu ia berkunjung ke Mr. Morley, dokter giginya. Sore harinya pun tak terlupakan. Mr. Morley ditemukan mati tertembak. Penyidikan kasus itu melalui pasien pasien lain melibatkan Poirot dengan seorang bankir kaya, seorang Yunani misterius yang tidak menyenangkan, seorang pemuda Amerika yang garang dan bertampang pembunuh, serta mantan aktris dengan sepatu bergesper yang menjadi pusat perhatiannya.'),
('9786020399492', 'Misteri Karibia (A Carribean Myst)', '063', '318', 2013, 'Miss Marple menikmati liburannya di Karibia yang hangat, tapi tak dapat menyisihkan perasaan tak puas yang menghinggapinya. Di surga tropis ini, tak banyak yang terjadi. Hingga suatu saat, Mayor Palgrave si tukang cerita, bertanya kepadanya:\r\n\r\n“Anda mau melihat potret seorang pembunuh?”\r\n\r\nNamun, sang Mayor tak pernah sempat memperlihatkan foto itu maupun menyelesaikan ceritanya---keesokan paginya, dia ditemukan telah meninggal dalam tidur. Suatu kebetulan… atau apa? Insting menyelidik Miss Marple pun terpantik.\r\n\r\nDi bawah matahari Karibia yang cemerlang, kejahatan sedang bekerja.'),
('9786020489728', 'LiT: Tujuh Hari untuk Keshia', '063', '259', 2019, 'Sejak mantan pacarnya tahu-tahu saja kembali dan membawa seorang anak perempuan bernama Keshia yang katanya adalah anaknya, Sadewa tahu bila hidupnya akan kacau. Lalu benar saja, Sadewa tidak pernah akur dengan Keshia. Jikaa di rumah, keduanya selalu saja bertengkar. Entah itu meributkan tagihan listrik, cicilan yang ditunggak berbulan-bulan, hutang beras di warung, dapur berantakan, atau bahkan cuma karena remote tv yang hilang. Masalah sekecil apa pun sepertinya selalu dijadikan momok untuk keduanya adu mulut dan membuat rumah menjadi zona perang seketika. Keduanya tidak pernah memedulikan satu sama lain. Sadewa tidak pernah peduli dengan kehidupan Keshia, baik di rumah atau pun di sekolahnya. Sadewa tidak peduli dengan kelakuan putri tomboinya itu yang selalu saja berpura-pura kuat dan menganggap bisa mengatasi segalanya sendirian. Sementara Keshia, sama halnya dengan Sadewa, dia tidak pernah peduli dengan kelakuan ayahnya yang masih saja bersikap layaknya ABG itu.'),
('9786020604886', 'Malam Tanpa Akhir (Endless Night)', '063', '318', 2012, 'Siapa pun yang memiliki Gipsy’s Acre akan mengalami nasib malang dan kejadian-kejadian berbahaya… hingga akhirnya mengalami kematian.\r\n\r\nTapi Mike dan Ellie tak peduli karena mereka sedang dilanda cinta. Mereka mendirikan rumah di Gipsy’s Acre, dan yakin kebahagiaan mereka akan menghapuskan segala masa lalu yang jahat itu untuk selamanya.\r\n\r\nKemudian, ancaman-ancaman itu mulai datang. Begitu juga beberapa kecelakaan dan terror. Cita-cita mereka yang indah pun berubah menjadi mimpi buruk yang penuh ketakutan, pengkhianatan… dan pembunuhan!'),
('9786020610375', 'Lord Edgware Dies - Matinya Lord Edgware', '063', '318', 2017, '\"Suami saya harus saya singkirkan!\r\n\r\nPoirot terenyak kaget. Tapi ketika bertemu Lord Edgware, aku teringat kembali bagaimana Jane bergidik ketika menceritakan suaminya. Dengan ramah Lord Edgware mengucapkan selamat berpisah kepada kami, tapi ketika sedang menutup pintu perpustakaan, aku melihat ke dalam dan hampir saja aku berseru kaget.\r\n\r\nWajah penuh senyum yang ningrat tadi telah beralih rupa. Bibirnya menyeringai sehingga tampak deretan giginya, matanya berkilat-kilat marah.\r\n\r\nSorot kemarahan yang hampir-hampir mendekati sinting.\r\n\r\nEsok paginya Lord Edgware ditemukan sudah mati. Tengkuknya ditikam....\"\"\"'),
('9786020616339', 'Dark Series#3: Malaikat Berhati Gelap', '063', '117', 2018, 'Aria Topan berada dalam kesulitan besar saat mengetahui bahwa Justin, teman masa kecil sekaligus cinta pertamanya, kuliah di kampus yang sama dengannya. Lebih gawat lagi, cowok itu dan teman-temannya kepo banget. Di mana ada kejadian mencekam, di situlah para cowok itu berada. Padahal Aya sendiri juga termasuk orang yang kepo. Akibatnya, mereka sering bertemu dalam berbagai situasi, baik yang menyenangkan maupun yang tidak.'),
('9786020616711', 'And Then There Were None (Lalu Semuanya Lenyap)', '063', '318', 2017, 'Sepuluh orang diundang ke sebuah rumah mewah di Pulau Prajurit di seberang pantai Devon. Sepuluh orang dengan rahasia kelam masing-masing, datang tanpa curiga pada sore musim panas yang indah. Tetapi tiba-tiba, terjadi serentetan kejadian misterius. Pulau tersebut berubah menjadi pulau maut yang mengerikan ketika satu demi satu, orang-orang itu tewas...'),
('9786020617039', 'The Murder of Roger Ackroyd (Pembunuhan Atas Roger Ackroyd)', '063', '318', 2017, 'Roger Ackroyd tahu terlalu banyak. Ia tahu bahwa wanita yang ia cintai meracuni suami pertamanya yang kejam. Ia juga curiga bahwa wanita itu diperas seseorang. Dan kini… wanita itu bunuh diri. Malam itu Roger menerima sepucuk surat berisi informasi yang sangat fatal. Sayang sekali, sebelum ia sempat membaca surat itu sampai selesai, seseorang menikamnya hingga tewas. Hercule Poirot pun terpaksa menunda masa pensiunnya untuk menyelidiki kasus ini.'),
('9786020617770', 'Pembunuhan di Orient Express (Murder on the Orient Express)', '063', '318', 2017, 'Tepat setelah tengah malam, gumpalan salju menghentikan kereta Orient Express. Padahal saat itu kereta mewah tersebut sangat dipadati penumpang. Tetapi, begitu pagi tiba, mereka kekurangan satu penumpang. Dia tewas di dalam kompartemen, dengan belasan luka tusuk, dan pintunya terkunci dari dalam.\r\n\r\nSebagai salah satu penumpang, Poirot berlomba dengan waktu untuk menemukan pelaku pembunuhan itu.'),
('9786020625492', ' Pembunuhan ABC (The ABC Murders)', '063', '318', 2017, 'A berarti Andover... di sana Mrs. Ascher dipukul sampai mati. B berarti Bexhill... tempat Betty Barnard mati dicekik. C berarti Churston... dan Sir Carmichael Clarke ditemukan terbunuh. Di samping tubuh masing-masing korban diletakkan sebuah buku Panduan Kereta Api ABC, terbuka pada halaman yang menunjukkan tempat pembunuhan. Polisi tak berdaya. Tapi si pembunuh telah membuat kesalahan besar. Dia berani menantang Hercule Poirot untuk membuka kedoknya'),
('9786020625904', 'Setelah Pemakaman (After the Funeral)', '063', '318', 2017, 'Cora Lansquenet sejak dulu suka bicara melantur.... dan keluarganya yang terhormat mengabaikan komentar yang dia ucapkan setelah pemakaman kakaknya, Richard, “Dia dibunuh, kan?” Mereka ingat lagi komentar itu keesokan harinya, waktu Cora ditemukan terbunuh dengan sebuah kapak... dan beberapa hari kemudian, ketika ada seseorang mengirim kue pengantin yang telah di celup arsenik kepada teman serumah Cora... Tetapi saat itu pengacara keluarga sudah memanggil Hercule Poirot....'),
('9786020629261', 'Young Adult: Dark Series#4: Di Balik Sosok Gelap', '063', '117', 2019, 'Rima Hujan berada dalam masalah besar. Dia memergoki pacarnya—Daniel—bertemu diam-diam dengan Merry, selebgram kondang yang satu klub dengannya. Saat stres karena hal itu, Rima malah menemukan beberapa mayat di gudang klub seni... dalam bentuk patung lilin! Apakah pelakunya adalah salah satu anggota klub yang selama ini dia kenal dengan baik?'),
('9786020635835', 'Young Adult: Dark Series#5: Buku Harian Sang Pangeran Kegelapan', '063', '117', 2019, 'Hyuga berada dalam posisi tak enak ketika “sobat tato”-nya, Damian Erlangga, meminta bantuan. Terlebih lagi bantuan itu menempatkannya sebagai musuh teman-teman yang selama ini menjadi keluarganya. Tapi Hyuga percaya ada kode persahabatan yang tidak bisa dikhianati, meski harga yang harus dibayarnya adalah menjadi agen ganda. Damian berada dalam posisi tak enak lantaran Johan Jonathan, si ular licik dan keji, meminta bantuannya. Terlebih lagi pekerjaan ini akan membuat cinta sejatinya, Putri Badai, membencinya. Tapi Damian sudah tahu sejak lama, melakukan pekerjaan kotor adalah tugasnya, karena tak banyak orang yang sudi merendahkan diri dan melakukannya. Erika Guruh berada dalam posisi tak enak karena disuruh menjaga anak-anak keluarga Cemiri: Tony Senjakala, Frankie Cahyadi, Markus Mann, Tory Senjakala, Hanny Pelangi, dan Jenny Angkasa. Masalahnya, satu per satu anak-anak itu lenyap, kemungkinan besar mati. Erika bertekad menjadikan semua ini masalah pribadi, namun yang ditemukannya malah membuat hatinya hancur lebur.'),
('9786020638010', 'Ganjil-Genap', '063', '110', 2020, 'Gimana rasanya diputusin setelah berpacaran selama tiga belas tahun?\r\n\r\nHidup Gala yang mendadak jomblo semakin runyam ketika adiknya kebelet nikah! Gala bertekad pantang lajang menjelang umur kepala tiga. Bersama ketiga sahabatnya, Nandi, Sydney, dan Detira, strategi pencarian jodoh pun disusun. Darat, udara, bahkan laut \"disisir\" demi menemukan pria idaman.\r\n\r\nAkankah Gala berhasil menemukan pasangan untuk menggenapi hari-hari ganjilnya? '),
('9786020639512', 'Selena', '063', '121', 2019, '\"Selena\" dan \"Nebula\" adalah buku ke-8 dan ke-9 yang menceritakan siapa orangtua Raib dalam serial petualangan dunia paralel. Dua buku ini sebaiknya dibaca berurutan. Kedua buku ini juga bercerita tentang Akademi Bayangan Tingkat Tinggi, sekolah terbaik di seluruh Klan Bulan. Tentang persahabatan tiga mahasiswa, yang diam-diam memiliki rencana bertualang ke tempat-tempat jauh. Tapi petualangan itu berakhir buruk, saat persahabatan mereka diuji dengan rasa suka, egoisme, dan pengkhianatan.'),
('9786020639536', 'Nebula', '063', '121', 2019, 'SELENA dan NEBULA adalah buku ke-8 dan ke-9 yang menceritakan siapa orangtua Raib dalam serial petualangan dunia paralel. Dua buku ini sebaiknya dibaca berurutan. Kedua buku ini juga bercerita tentang Akademi Bayangan Tingkat Tinggi, sekolah terbaik di seluruh Klan Bulan. Tentang persahabatan tiga mahasiswa, yang diam-diam memiliki rencana bertualang ke tempat-tempat jauh. Tapi petualangan itu berakhir buruk, saat persahabatan mereka diuji dengan rasa suka, egoisme, dan pengkhianatan.'),
('9786020643564', 'Teenlit: #1: Jangan Diklik: Rahasia Ayu', '063', '117', 2020, 'Ayu Rembulan menjadi saksi kematian Leoni, teman sekelasnya yang bunuh diri tahun lalu. Pada hari ulang tahun kematian Leoni, Ayu menerima SMS aneh yang membuat sebuah aplikasi misterius bernama JanganDiklik terpasang di ponselnya. Melalui aplikasi itu, Ayu menemukan catatan harian Leoni yang menceritakan hari-hari terakhirnya sebelum meninggal. Sejak itu, kecelakaan demi kecelakaan tragis menghantui teman-teman yang dulu mencelakai Leoni. Orang-orang lain mengira semua itu kebetulan, tetapi Ayu tahu hantu Leoni-lah yang sedang membalaskan dendamnya. Tak seorang pun percaya padanya, kecuali Rex, cowok jahat yang sudah menindas dan mempermalukan Ayu selama setahun ini. Bersama-sama mereka berusaha menyelamatkan teman-teman mereka… juga diri mereka sendiri.'),
('9786020647821', 'Selamat Tinggal', '063', '121', 2020, 'Kita tidak sempurna. Kita mungkin punya keburukan, melakukan kesalahan, bahkan berbuat jahat, menyakiti orang lain. Tapi beruntunglah yang mau berubah. Berjanji tidak melakukannya lagi, memperbaiki, dan menebus kesalahan tersebut.\r\n\r\nMari tutup masa lalu yang kelam, mari membuka halaman yang baru. Jangan ragu-ragu. Jangan cemas. Tinggalkanlah kebodohan dan ketidakpedulian. “Selamat Tinggal” suka berbohong, “Selamat Tinggal” kecurangan, “Selamat Tinggal” sifat-sifat buruk lainnya.'),
('9786020649665', 'The Star and I', '063', '242', 2021, '\"Kulihat dunia dalam matamu dan masa depan dalam senyummu...\" Sejak kecil, Olivia Mitchell ingin tahu siapa orangtua kandungnya. Jadi, ketika ia mendapat kesempatan bekerja di New York, ia pun menyambarnya tanpa ragu. Namun, mencari seseorang tanpa nama di kota sebesar New York adalah sesuatu yang mustahil. Kini kontrak kerja Olivia akan segera berakhir, dan Olivia menolak pulang ke Inggris sebelum berhasil melacak keberadaan orangtua kandungnya. Itu berarti ia harus segera mencari pekerjaan baru supaya ia bisa tetap tinggal di New York. Seolah-olah semua itu belum cukup memusingkan, Olivia mendadak bertemu kembali dengan Rex Rankin---sahabat masa kecilnya, sekaligus cinta pertamanya yang gagal---yang muncul untuk menawarkan bantuan.'),
('9786020652351', 'Sunshine Becomes You', '063', '242', 2021, '“Walaupun tidak ada hal lain di dunia ini yang bisa kaupercayai, percayalah bahwa aku mencintaimu. Sepenuh hatiku.” Ini adalah salah satu kisah yang terjadi di bawah langit kota New York… Ini kisah tentang harapan yang muncul di tengah keputusasaan… Tentang impian yang bertahan di antara keraguan… Dan tentang cinta yang memberikan alasan untuk bertahan hidup. Awalnya Alex Hirano lebih memilih jauh-jauh dari gadis itu—malaikat kegelapannya yang sudah membuatnya cacat. Kemudian Mia Clark tertawa dan Alex bertanya-tanya bagaimana ia dulu bisa berpikir gadis yang memiliki tawa secerah matahari itu adalah malaikat kegelapannya. Awalnya mata hitam yang menatapnya dengan tajam dan dingin itu membuat Mia gemetar ketakutan dan berharap bumi menelannya detik itu juga. Kemudian Alex Hirano tersenyum dan jantung Mia yang malang melonjak dan berdebar begitu keras sampai Mia takut Alex bisa mendengarnya.'),
('9786020655680', 'Winter in Tokyo', '063', '242', 2021, 'Tetangga baruku, Nishimura Kazuto, datang ke Tokyo untuk mencari suasana baru. Itulah katanya, tapi menurutku alasannya lebih dari itu. Dia orang yang baik, menyenangkan, dan bisa diandalkan. Perlahan-lahan---mungkin sejak Malam Natal itu---aku mulai memandangnya dengan cara yang berbeda. Dan sejak itu pula rasanya sulit membayangkan hidup tanpa dia. ---Keiko tentang Kazuto Sejak awal aku sudah merasa ada sesuatu yang menarik dari Ishida Keiko. Segalanya terasa menyenangkan bila dia ada. Segalanya terasa baik bila dia ada. Saat ini di dalam hatinya masih ada seseorang yang ditunggunya. Cinta pertamanya. Kuharap dia bisa berhenti memikirkan orang itu dan mulai melihatku. Karena hidup tanpa dirinya sama sekali bukan hidup. ---Kazuto tentang Keiko Mereka pertama kali bertemu di awal musim dingin di Tokyo. Selama sebulan bersama, perasaan baru pun mulai terbentuk. Lalu segalanya berubah ketika suatu hari salah seorang dari mereka terbangun dan sama sekali tidak mengingat semua yang terjadi selama sebulan terakhir, termasuk orang yang tadinya sudah menjadi bagian penting dalam hidupnya....'),
('9786020655703', 'Summer in Seoul', '063', '242', 2021, 'Jung Tae-Woo---penyanyi muda terkenal Seoul yang muncul kembali setelah empat tahun menghindari dunia showbiz. \"Aku hanya ingin memintamu berfoto denganku sebagai pacarku,\" kata Jung Tae-Woo pada gadis di hadapannya. Sandy alias Han Soon-Hee---gadis blasteran Indonesia-Korea yang sudah mengenali Jung Tae-Woo sejak awal, namun sedikit pun tidak terkesan. Sandy mengangkat wajahnya dan menatap laki-laki itu, lalu berkata, \"Baiklah, asalkan wajahku tidak terlihat.\" Awalnya Jung Tae-Woo tidak curiga kenapa Sandy langsung menerima tawarannya. Sementara Sandy hanya bisa berharap ia tidak akan menyesali keputusannya terlibat dengan Jung Tae-Woo. Hari-hari musim panas sebagai \"kekasih\" Jung Tae-Woo dimulai. Perubahan rasa itu pun ada. Namun keduanya tidak menyadari kebenaran kisah empat tahun lalu sedang mengejar mereka.'),
('9786020655789', 'Spring in London', '063', '242', 2021, 'Gadis itu tidak menyukainya. Kenapa? Astaga, ia---Danny Jo---adalah orang yang baik. Sungguh! Ia selalu bersikap ramah, sopan, dan menyenangkan. Lalu kenapa Naomi Ishida menjauhinya seperti wabah penyakit? Bagaimana mereka bisa bekerja sama dalam pembuatan video musik ini kalau gadis itu tidak mengacuhkannya setiap saat? Kesalahan apa yang sudah dia lakukan? Bagaimanapun juga Danny bukan orang yang gampang menyerah. Ia akan mencoba mendekati Naomi untuk mencari tahu alasan gadis itu memusuhinya. Tetapi ada dua hal yang tidak diperhitungkan Danny. Yang pertama adalah kemungkinan ia akan jatuh cinta pada Naomi Ishida yang dingin, misterius, dan penuh rahasia itu. Dan yang kedua adalah kemungkinan ia akan menguak rahasia gelap yang bisa menghancurkan mereka berdua dan orang-orang yang mereka sayangi.'),
('9786020655802', 'Autumn in Paris', '063', '242', 2021, 'Tara Dupont menyukai Paris dan musim gugur. Ia mengira sudah memiliki segalanya dalam hidup… sampai ia bertemu Tatsuya Fujisawa yang susah ditebak dan selalu membangkitkan rasa penasarannya sejak awal. Tatsuya Fujisawa benci Paris dan musim gugur. Ia datang ke Paris untuk mencari orang yang menghancurkan hidupnya. Namun ia tidak menduga akan terpesona pada Tara Dupont, gadis yang cerewet tapi bisa menenangkan jiwa dan pikirannya... juga mengubah dunianya. Tara maupun Tatsuya sama sekali tidak menyadari benang yang menghubungkan mereka dengan masa lalu, adanya rahasia yang menghancurkan segala harapan, perasaan, dan keyakinan. Ketika kebenaran terungkap, tersingkap pula arti putus asa... arti tak berdaya... Kenyataan juga begitu menyakitkan hingga mendorong salah satu dari mereka ingin mengakhiri hidup....'),
('9786020657028', 'Young Adult: Dark Series#6: Akhir Tergelap', '063', '117', 2021, 'Geng Psikopat Grey dan Josh menyamar di bus khusus napi untuk mencari tahu soal si Makelar Gadungan. Tidak tahunya mereka malah harus menghadapi Eliza Guruh yang cantik, misterius, dan pandai memanipulasi, yang muncul bersama teman napinya yang brengsek banget, King. Dengan strategi dan pimpinan Eliza, semua napi berhasil kabur, tapi satu per satu mulai terbunuh. Ada satu pembunuh di antara mereka. Grey dan Josh curiga itu adalah Eliza, tetapi tugas mereka makin pelik saat sobat mereka, Daryl, muncul bersama Viktor Yamada dan Leslie Gunawan.'),
('9786020657455', 'Harapan Dari Tempat Paling Jauh', '063', '259', 2021, 'Hidup Vanka hanya untuk ibunya. Dia memilih fokus belajar dan mengejar prestasi ini-itu sampai menjadi salah satu murid penyendiri di sekolah, untuk ibunya. Vanka bertekad menjadi yang terbaik agar ibunya sudi memaafkan status Vanka sebagai anak di luar nikah. Namun, di tengah usahanya membuktikan diri, Vanka malah harus berurusan dengan Oliver, si cowok angkuh yang ternyata memiliki banyak ketakutan ganjil. Hidup Oliver hanya untuk kakeknya. Dia menjadi aktor terkenal, meladeni jutaan penggemar, memaksa diri tetap berangkat ke sekolah yang mengerikan, untuk membuat kakeknya percaya bahwa dirinya anak yang normal. Namun, di tengah semua kepura-puraan itu, Oliver bersinggungan dengan Vanka, si cewek yang menyimpan banyak amarah. Awal hubungan keduanya ditandai benci dan dendam.'),
('9786020822341', 'Tentang Kamu', '063', '121', 2016, 'Terima kasih untuk kesempatan mengenalmu,\r\nitu adalah salah satu anugerah terbesar hidupku.\r\nCinta memang tidak perlu ditemukan,\r\ncintalah yang akan menemukan kita.\r\n\r\nTerima kasih. Nasihat lama itu benar sekali.\r\naku tidak akan menangis karena sesuatu telah\r\nberakhir, tapi aku akan tersenyum karena sesuatu itu pernah terjadi.\r\n\r\nMasa lalu, Rasa sakit, Masa depan. Mimpi-mimpi.\r\nSemua akan berlalu, seperti sungai yang mengalir.\r\nMaka biarlah hidupku mengalir seperti sungai kehidupan.'),
('9786022910527', 'SUPERNOVA 1: KPBJ', '338', '327', 2014, 'Menunaikan ikrar mereka untuk berkarya bersama, pasangan Dimas dan Reuben mulai menulis roman yang diberi judul Kesatria, Putri, dan Bintang Jatuh.\r\n\r\nParalel dengan itu, dalam kehidupan nyata, sebuah kisah cinta terlarang terjalin antara Ferre dan Rana. Hubungan cinta mereka merepresentasikan dinamika yang terjadi antara tokoh Kesatria dan Putri dalam fiksi Dimas dan Reuben. Tokoh ketiga, Bintang Jatuh, dihadirkan oleh seorang peragawati terkenal bernama Diva, yang memiliki profesi sampingan sebagai pelacur kelas atas.'),
('9786022910534', 'SUPERNOVA 2: Akar', '338', '327', 2014, 'Di Bolivia, Gio mendapat kabar bahwa Diva hilang dalam sebuah ekspedisi sungai di pedalaman Amazon. Di Indonesia, perjalanan seorang anak yatim piatu bernama Bodhi dimulai. Bodhi, yang dibesarkan di wihara oleh Guru Liong, akhirnya meninggalkan tempat ia dibesarkan dan bertualang ke Asia Tenggara. Di Bangkok, ia bertemu pria eksentrik bernama Kell yang mengajarinya seni tato.\r\n\r\nSetelah melalui petualangan yang berliku di berbagai negara, Bodhi akhirnya kembali ke Indonesia. Ia dipertemukan dengan tokoh punk karismatik bernama Bong. Sejak itu, Bodhi menjadi bagian dari komunitas punk dengan perannya sebagai seniman tato.\r\n\r\nSebuah surat misterius yang ditemukan secara tidak sengaja oleh Bodhi kembali membawanya ke gerbang petualangan baru.'),
('9786022910541', 'SUPERNOVA 3: Petir', '338', '327', 2014, 'Dua tahun setelah roman mereka rampung, Dimas dan Reuben mengalami stagnasi. Hingga suatu hari mereka mendapat surat elektronik dari seseorang bernama Gio. Kata “Supernova” yang disebut Gio dalam surat itu menjadi tanda tanya baru sekaligus awal pengetahuan Dimas dan Reuben tentang jaringan yang selama ini melibatkan mereka tanpa disadari.\r\n\r\nSementara itu, di Kota Bandung, seorang gadis sebatang kara bernama Elektra berusaha menyambung hidup. Berawal dari perkenalannya dengan seorang yogini bernama Ibu Sati dan seorang entreprenur muda urakan bernama Toni alias Mpret, hidup Elektra mulai terakselerasi. Dari anak kuper yang tidak punya motivasi, Elektra bertransformasi menjadi seorang pengusaha, dan akhirnya seorang penyembuh.\r\n\r\nSetelah nyaman dalam lingkungannya yang baru, hidup Elektra kembali siap diguncang ketika Bong memintanya untuk menolong seseorang yang tak ia kenal bernama Bodhi.'),
('9786022910558', 'SUPERNOVA 4: Partikel', '338', '327', 2014, 'Di pinggir Kota Bogor, dekat sebuah kampung bernama Batu Luhur, seorang anak bernama Zarah, dan adiknya, Hara, dibesarkan secara tidak konvensional oleh ayahnya, dosen sekaligus ahli mikologi bernama Firas. Cara Firas mendidik anak-anaknya mengundang pertentangan dari keluarganya sendiri.'),
('9786022910930', 'Madre', '338', '327', 2015, '“Apa rasanya jika sejarah kita berubah dalam sehari? Darah saya mendadak seperempat Tionghoa, Nenek saya seorang penjual roti, dan dia, bersama kakek yang tidak saya kenal, mewariskan anggota keluarga baru yang tidak pernah saya tahu: Madre.”'),
('9786022910954', 'Perahu Kertas', '338', '327', 2015, 'Namanya Kugy. Mungil, pengkhayal, dan berantakan. Dari benaknya, mengalir untaian dongeng indah. Keenan belum pernah bertemu manusia seaneh itu.\r\n\r\n…\r\n\r\nNamanya Keenan. Cerdas, artistik, dan penuh kejutan. Dari tangannya, mewujud lukisan-lukisan magis. Kugy belum pernah bertemu manusia seajaib itu.\r\n\r\n…\r\n\r\nDan kini mereka berhadapan di antara hamparan misteri dan rintangan. Akankah dongeng dan lukisan itu bersatu?\r\n\r\nAkankah hati dan impian mereka bertemu?'),
('9786022911029', 'Ayah', '338', '433', 2015, 'Betapa Sabari menyayangi Zorro. Ingin dia memeluknya sepanjang waktu. Dia terpesona melihat makhluk kecil yang sangat indah dan seluruh kebaikan yang terpancar\r\ndarinya. Diciuminya anak itu dari kepala sampai ke jari-jemari kakinya yang mungil. Kalau malam Sabari susah susah tidur lantaran membayangkan bermacam rencana\r\nyang akan dia lalui dengan anaknya jika besar nanti. Dia ingin mengajaknya melihat pawai 17 Agustus, mengunjungi pasar malam, membelikannya mainan,\r\nmenggandengnya ke masjid, mengajarinya berpuasa dan mengaji, dan memboncengnya naik sepeda saban sore ke taman kota.'),
('9786022911319', 'Supernova: Inteligensi Embun Pagi', '338', '327', 2016, 'Di Bandung, pertemuan Bodhi dan Elektra mulai memicu ingatan mereka berdua tentang tempat bernama Asko. Sedangkan Zarah, yang pulang ke desa Batu Luhur setelah sekian lama melanglangbuana, kembali berhadapan dengan misteri hilangnya Firas, ayahnya.\r\n\r\nSementara itu, dalam perjalanan pesawat dari New York menuju Jakarta, teman seperjalanan Alfa yang bernama Kell mengungkapkan sesuatu yang tidak terduga. Dari berbagai lokasi yang berbeda, keterhubungan antara mereka perlahan terkuak. Identitas dan misi mereka akhirnya semakin jelas.\r\n\r\nHidup mereka takkan pernah sama lagi.'),
('9786022912705', 'Kepingan Supernova', '338', '327', 2017, 'Tidak ada awal dan akhir.\r\n\r\nTidak ada sebab dan akibat.\r\n\r\nTidak ada ruang dan waktu.\r\n\r\nYang ada hanyalah Ada.'),
('9786022916628', 'Laskar pelangi', '338', '433', 2019, '\"Laskar Pelangi\" merupakan novel karya Andrea Hirata yang pertama kali diterbitkan pada tahun 2005. Secara garis besar, novel ini menceritakan kehidupan anak-anak daerah di Belitong (saat ini Provinsi Bangka Belitung).'),
('9786022916635', 'Sang pemimpi', '338', '433', 2019, 'Arai adalah saudara jauh Ikal yang telah menjadi yatim piatu sejak kelas 3 SD. Ia adalah anak yang sangat tabah menjalani hidupnya. Bayangkan saja, ketika Ikal dan Ayahnya menjemput Arai, mereka sedih melihat keadaan Arai, namun Arai menghibur Ikal dengan mainan buatannya. Adapun Jimbron adalah sahabat setia mereka yang sangat terobsesi kepada kuda. Ia sangat mengerti seluk-beluk setiap jenis kuda.\r\nKetiga anak itu sering dimarahi Pak Mustar karena ulah konyol mereka. Pak mustar adalah sosok orang yang sangat bersahaja, tegas, dan disiplin. Ia adalah pahlawan bagi anak-anak di Belitong. Berkatnya, Ikal dan teman-temannya tidak perlu menempuh jalan sejauh ratusan kilometer untuk pergi ke sebuah sekolah negeri. Pak Mustar menjadi galak karena anaknya tidak dapat masuk ke SMA yang susah-payah dibangunnya hanya karena nilai ujiannya kurang 0,25 dari batas minimal.'),
('9786022916659', 'Mozaik-mozaik terindah', '338', '433', 2019, 'Mozaik-Mozaik Terindah merupakan kumpulan bab-bab pilihan editor yang diambil dari buku-buku Andrea Hirata. Di dalamnya kita akan menemukan semangat, perjuangan, cinta, harapan, dan tak kalah pentingnya adalah makna sahabat.'),
('9786022916666', 'Orang-orang biasa', '338', '433', 2019, 'Orang-orang biasa (Ordinary People) adalah novel ke-10 yang diterbitkan Andrea Hirata bersama Penerbit Bentang Pustaka. Andrea Hirata menulis novel Orang-Orang Biasa antara karena kekecewaan yang besar akan kegagalannya memperjuangkan seorang anak miskin yang pintar untuk masuk Fakultas Kedokteran Universitas Bengkulu.'),
('9786022916864', 'Guru Aini', '338', '433', 2019, 'Guru Aini mengisahkan kegigihan seorang guru matematik, Guru Desi dalam mencari murid genius di kawasan pedalaman. Baginya, murid genius matematik hanyalah lahir secara semula jadi. Sehinggalah beliau bertemu dengan seorang murid bernama Aini. Seorang anak yang sentiasa gagal dalam matematik dan langsung tidak berminat akan subjek kira-kira.'),
('9786022917243', 'Rantai Tak Putus', '338', '327', 2020, 'Ke mana pun kita melayangkan pandang, UMKM―Usaha Mikro, Kecil, dan Menengah―selalu hadir. Dari petani cabai hingga pemilik bengkel, UMKM menyediakan lapangan kerja terbanyak sekaligus alat terbaik untuk pengentasan kemiskinan dan pemerataan ekonomi. Namun, kuantitas tak selalu bertumbuh selaras dengan kualitas. Lantas, adakah formula ideal untuk menaikkan kelas UMKM di Indonesia?'),
('9786024246945', 'Laut Bercerita', '424', '112', 2017, 'Laut Bercerita, novel terbaru Leila S. Chudori, bertutur tentang kisah keluarga yang kehilangan, sekumpulan sahabat yang merasakan kekosongan di dada, sekelompok orang yang gemar menyiksa dan lancar berkhianat, sejumlah keluarga yang mencari kejelasan makam anaknya, dan tentang cinta yang tak akan luntur.'),
('9786024525712', 'Melbourne wedding marathon', '063', '110', 2017, 'Sydney Deyanira\r\nWanita cerdas, mandiri, ambisius, dan perfeksionis. Sydney merasa patah hati ketika sahabat yang ia kencani selama satu semester terakhir memilih berpacaran dengan orang lain. Dijuluki sebagai ahli percintaan prematur, Sydney mulai berpikir untuk melakukan apa yang tidak pernah ia lakukan sebelumnya, menjalin hubungan palsu dengan orang baru.\r\n\r\nAnantha Daniswara\r\nPria sukses, arogan, suka bergonta-ganti pasangan namun masih belum berdamai dengan masa lalunya. Demi memenuhi tantangan mantan pacarnya, Anantha nekat meminta pelayannya sendiri untuk menjadi kekasihnya. Melbourne bukan kota cinta dan jauh dari kata romantis. Sebagai kota yang paling nyaman ditinggali di dunia, Melbourne menjadi awal baru bagi dua insan yang tertekan dengan rentetan pesta pernikahan!'),
('9786027888036', 'Rectoverso', '338', '327', 2015, 'Sebuah kisah indah selalu melekat dalam kenangan, seperti jejak yang ditatah di atas karang. Rectoverso adalah kisah itu. Segala emosi terwakili di dalamnya. Ada kesedihan, suka cita, ragu-ragu, ketakutan, membentuk alur penuh cabang, meski pada akhirnya akan kembali kepada muara yang sama.'),
('9786027888982', 'Edensor', '338', '433', 2013, 'Aku ingin mendaki puncak tantangan, menerjang batu granit kesulitan, menggoda mara bahaya, dan memecahkan misteri dengan sains. Aku ingin menghirup berupa-rupa pengalaman lalu terjun bebas menyelami labirin lika-liku hidup yang ujungnya tak dapat disangka. Aku mendamba kehidupan dengan kemungkinan-kemungkinan yang bereaksi satu sama lain seperti benturan molekul uranium: meletup tak terduga-duga, menyerap, mengikat, mengganda, berkembang, terurai, dan berpencar ke arah yang mengejutkan. Aku ingin ke tempat-tempat yang jauh, menjumpai beragam bahasa dan orang-orang asing. Aku ingin berkelana, menemukan arahku dengan membaca bintang gemintang. Aku ingin mengarungi padang dan gurun-gurun, ingin melepuh terbakar matahari, limbung dihantam angin, dan menciut dicengkeram dingin. Aku ingin kehidupan yang menggetarkan, penuh dengan penaklukan. Aku ingin hidup! Ingin merasakan sari pati hidup!'),
('9786028811613', 'Filosofi Kopi', '338', '327', 2012, 'Ben bukan sekadar pecinta kopi biasa. Dia sudi melakukan perjalanan ke seluruh penjuru dunia, mencurahkan segenap waktu dan tenaganya, semua demi mencecap rahasia kenikmatan kopi. Pantas jika kemudian dia diakui sebagai barista nomor wahid. Tak sekadar meramu kopi, dia bahkan mampu merumuskan filosofi di setiap ramuannya. Puncaknya, dia berhasil menciptakan sebuah ramuan yang diakui oleh semua pengunjungnya, kecuali seorang pria. Sejak itulah Ben tahu ada yang salah dalam hidupnya.'),
('9786230001239', 'Le Mariage: Wedding with Converse', '063', '259', 2019, 'Raskal dan Joana, dua orang siswa SMA yang kini sedang dijerat putus asa akan kenyataan hidup. Mereka bersahabat dari kecil, namun persahabatan itu harus putus karena terjadinya sebuah peristiwa; Joana hamil dan Raskal terjebak lingkup narkoba. Cita-cita, harapan, dan juga angan-angan musnah sudah untuk keduanya. Raskal, yang adalah laki-laki yang bertanggung jawab atas kehamilan Joana, terpaksa harus menikahi gadis itu. Namun, sekali lagi ditegaskan, walau Raskal adalah sahabat kecilnya, kini Joana menganggap Raskal hanya sebagai laki-laki brengsek yang harus mempertanggungjawabkan semuanya. Raskal pikir, pernikahan adalah ujian terberatnya. Tapi, saat waktu terus bergulir dan dia menyadari orang-orang yang dicintainya mulai pergi meninggalkannya, Raskal baru mengerti kalau dirinya memang tidak bisa tertolong lagi.'),
('9786230019630', 'LiT: Say Hi!', '063', '259', 2021, 'Dia yang serba pas-pasan, ngerasa temenan sama Ervan dan Pandu yang berpredikat cowok populer sekolah jadi semacam ujian.\r\n\r\nErvan si ganteng, Ribby si kumal. Pandu si keren, Ribby si dekil.'),
('9786230020223', 'Sleeping Giants (Themis Files #1)', '002', '225', 2021, 'Rose kecil sedang mengayuh sepeda barunya ketika dia terjungkal ke tepi tebing. Dia ternyata terjatuh ke sebuah lubang berbentuk persegi, tepiannya dihiasi ukiran dan simbol yang memancarkan cahaya pirus. Tapi apa yang dilihat para penyelamatnya ternyata lebih janggal lagi: gadis itu tergeletak di atas sebentuk tangan logam raksasa. Tujuh belas tahun setelahnya, misteri yang melingkupi benda aneh itu belum terpecahkan. Rose tumbuh besar menjadi seorang fisikawan cerdas dan ditunjuk untuk memimpin tim rahasia yang meneliti benda itu. Ternyata tangan raksasa itu bukan satu-satunya benda yang akan mereka temukan. Dan semakin lama semakin disadari bahwa telah didapatkan sebuah bukti yang sanggup mengubah pemahaman manusia bahwa mereka tidak sendirian di alam semesta.'),
('9786230020674', 'Waking Gods (Themis Files #2)', '002', '225', 2021, 'Ketika kecil, Rose tak sengaja menemukan benda aneh yang mengagumkan: sebentuk tangan logam raksasa yang terkubur di tanah. Ketika dewasa, Rose mencurahkan karier dan otak cerdasnya untuk memecahkan misteri itu. Mengapa ada sebuah robot raksasa yang bagian-bagian tubuhnya dikubur di sepenjuru Bumi? Tahun demi tahun penelitian malah membuahkan lebih banyak pertanyaan. Namun yang pasti, manusia bukan makhluk yang mampu menciptakan mesin sehebat itu. Apakah robot itu didatangkan ke Bumi untuk melindungi manusia, atau justru untuk menghancurkan semuanya? Satu dekade sejak penemuan robot pertama, robot-robot raksasa bermunculan di berbagai kota besar di dunia, termasuk London, Tokyo, Kairo, dan Jakarta. Misteri mulai sedikit terkuak. Namun Rose sekarang harus berpacu dengan waktu untuk melawan mereka sebelum seisi Bumi lenyap tak bersisa.'),
('9786230021831', 'Wingit', '002', '233', 2020, 'Penelusuran sebuah kompleks perumahan tua terbengkalai di daerah Jakarta Timur malam itu awalnya berjalan menyenangkan. Sebelum masuk ke area kompleks, saya bersama Wisnu, Fadi, dan Demian membuka vlog dengan gimmick seru untuk mencairkan suasana. Namun, saat tiba di sebuah lokasi rumah tingkat yang dikelilingi pepohonan dan semak, saya melihat semakin banyak makhluk tak kasatmata yang membuat saya terkejut.'),
('9786230026171', 'Lit: Suki', '002', '215', 2021, 'Senin kedua semester pertama kelas XI. Pelataran halaman masih lumayan sepi saat Suki tiba. Hanya ada beberapa anak rajin yang Suki hafal mukanya, tapi tidak namanya. Ada anggota OSIS yang kebagian piket dan beberapa staf kebersihan sekolah. Suki berjalan melewati lapangan voli menuju kelas sambil memasang earphone, mendengarkan lagu. Tiba-tiba saja sebuah tas melayang tepat di depan wajahnya. “JAGAIN TAS GUE, LIK!” teriak seseorang dari lapangan. Suki menoleh. Di sana ada dua cowok yang sedang saling memukul. Suki hanya menonton. Rasanya seperti melihat adegan film aksi, tetapi secara live. Gerakan mereka cepat. Pukul pipi kanan, tendang perut, saling menyeruduk. Kadang mengumpat dan meringis. Karena masih terlalu pagi, tidak ada yang berusaha menghentikan. Apa yang harus Suki lakukan? Apakah membantu mereka dan kemudian terlibat, atau lari saja?'),
('9786230026188', 'LiT: Indah Dalam Kelam', '002', '215', 2021, 'Jelita Geanessa bisa membaca masa lalu seseorang hanya dengan bersentuhan tangan. Itulah alasan selama ini dia memakai jaket hoodymerah dan mengasingkan diri dari sekitar. Mengetahui rahasia kelam milik orang lain membuat sepanjang hidupnya terasa begitu mengerikan. Lita bertemu dengan Darka Samudra, cowok ganteng dan sangat populer di sekolah, dalam momen tak sengaja di area loker. Saat tangan mereka bersentuhan, alih-alih mengetahui rahasia Darka, Lita malah jatuh pingsan. Ada sesuatu tentang Darka yang membuat Lita penasaran dan mulai mencari tahu rahasia di baliknya.'),
('9786230028977', 'Only Human (Themis Files #3)', '002', '225', 2021, 'Sebentuk tangan raksasa tanpa sengaja ditemukan Rose ketika dia masih kecil, artefak itu sudah membuat Rose mendedikasikan hidup untuk menelitinya. Tangan itu adalah bagian dari sesosok robot canggih yang diciptakan oleh ras alien dengan peradaban yang jauh lebih maju dibanding manusia. Tanpa sengaja, Rose beserta rekan-rekannya pun berteleportasi ke planet asal si robot, tempat mereka hidup dalam keterasingan. Butuh usaha keras dan penuh intrik, tapi mereka berhasil kembali ke Bumi. Sayangnya, keadaan di Bumi tak seperti yang mereka duga. Invasi alien sembilan tahun lalu telah mengubah sifat dasar manusia. Jutaan orang mati karena serangan bangsa alien. Akankah ada lebih banyak korban jika manusia berperang dengan bangsanya sendiri?'),
('9786239554521', 'Pulang-Pergi', '063', '121', 2021, 'Ada jodoh yang ditemukan lewat tatapan pertama.\r\nAda persahabatan yang diawali lewat sapa hangat.\r\nBagaimana jika takdir bersama ternyata,\r\ndiawali dengan pertarungan mematikan?\r\nLantas semua cerita berkelindan dengan,\r\npengejaran demi pengejaran mencari jawaban?\r\nPulang-Pergi'),
('9786239607449', 'Rembulan Tenggelam Di Wajahmu', '063', '121', 2021, 'Tutup mata kita. Tutup pikiran kita dari carut marut kehidupan. Mari berpikir takjim sejenak. Bayangkan saat ini ada satu malaikat bersayap indah datang kepada kita, lantas lembut berkata : \" Aku memberikan kau kesempatan hebat. Lima kesempatan untuk bertaya tentang rahasia kehidupan, dan aku akan menjawabnya langsung sekarang. Lima pertanyaan. Lima jawaban. Apakah pertanyaan pertamamu?\"\r\n\r\nMaka apakah kita akan bertanya : Apakah cinta itu? Apakah hidup ini adil? Apakah kaya adalah segalanya? Apakah kita memiliki pilihan dalam hidup? Apakah makna kehilangan?\r\n\r\nRay (tokoh utama dalam kisah ini), ternyata memiliki kecamuk pertanyaan sendiri. Lima pertanyaan sebelum akhirnya dia mengerti makna hidup dan kehidupannya.\r\n\r\nSiapkan energi Anda untuk memasuki dunia \'fantasi\' tere-liye tentang perjalanan hidup. Di sini hanya ada satu rumus: semua urusan adalah sederhana. Mala mulailah membaca dengan menghela nafas lega...'),
('9789792276855', 'Permainan Maut', '063', '117', 2013, '\"Yo, namaku Tony Senjakala dan hidupku saat ini bagaikan sederetan mimpi buruk.\r\n\r\nSebuah e-mail dari teman lamaku—tentang kejadian-kejadian misterius di rumahnya—terus mengusik pikiranku. Namun aku berusaha melupakannya karena sudah tidak sabar lagi untuk berlibur dengan Jenny, pacarku yang manis banget.\r\n\r\nTak disangka, tiba-tiba muncullah seseorang yang sangat tidak ingin kujumpai, namun terus saja menghantui kehidupanku. Tidak ingin orang ini membahayakan Jenny, aku terpaksa melupakan liburan impianku, mengadakan kamp latihan judo dadakan, dan menginap di rumah misterius yang konon menimbulkan nasib buruk bagi para penghuninya.'),
('9789792287950', 'Omen #1: Omen', '063', '117', 2012, 'Kasus penusukan siswa-siswi SMA Harapan Nusantara.'),
('9789792298222', 'Omen #3: Misteri Organisasi Rahasia The Jugdes', '063', '117', 2013, 'File 3: Kasus penganiayaan murid-murid SMA Harapan Nusantara dalam proses seleksi anggota organisasi rahasia “The Judges”. Tertuduh: Penyelenggara proses seleksi itu, alias para anggota “The Judges” yang semuanya misterius, mencurigakan, dan menyebalkan. Sifat sok berkuasa mereka membuat mereka jadi tertuduh ideal. Belum lagi undangan demi undangan yang dilayangkan pada para anggota kendati sudah terjadi peristiwa-peristiwa tak mengenakkan, menandakan mereka tidak peduli pada korban. Tentu saja, tertuduh utama adalah pemimpin organisasi sok keren ini, si Hakim Tertinggi. Fakta-fakta: Pada minggu terakhir tahun ajaran, surat-surat undangan dilayangkan pada anak-anak paling cerdas dan berbakat di kelas X, mengajak kami untuk mengikuti proses seleksi untuk menjadi anggota organisasi paling berpengaruh di sekolah kami. Tidak dinyana, satu per satu kami diserang secara brutal pada proses seleksi, ditinggalkan dalam posisi seolah-olah mereka menjadi korban ritual sebuah upacara. Misi kami: Menemukan pelaku kejahatan sebelum kami sendiri menjadi korban. Penyidik Kasus, Erika Guruh, Valeria Guntur, dan Rima Hujan');

-- --------------------------------------------------------

--
-- Table structure for table `publishers`
--

CREATE TABLE `publishers` (
  `publisher_id` varchar(15) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `publishers`
--

INSERT INTO `publishers` (`publisher_id`, `name`) VALUES
('002', 'PT. Elex Media Komputindo'),
('063', 'PT. Gramedia Pustaka Utama'),
('241', 'Yudhistira'),
('310', 'PT. Sembilan Cahaya Abadi'),
('338', 'Bentang Pustaka'),
('424', 'Kepustakaan Populer Gramedia (KPG)');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `transaction_id` int(11) NOT NULL,
  `user_id` int(15) NOT NULL,
  `isbn` varchar(20) NOT NULL,
  `borrow_date` date NOT NULL,
  `return_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`transaction_id`, `user_id`, `isbn`, `borrow_date`, `return_date`) VALUES
(1, 1, '9786020318776', '2021-12-18', '2021-12-25'),
(3, 1, '9786020312941', '2021-12-01', '2021-12-08'),
(4, 3, '9786020638010', '2021-12-18', '2021-12-25'),
(5, 3, '9786020652351', '2021-12-18', '2021-12-25');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(15) NOT NULL,
  `username` varchar(64) NOT NULL,
  `password` varchar(32) NOT NULL,
  `first_name` varchar(32) NOT NULL,
  `last_name` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `username`, `password`, `first_name`, `last_name`) VALUES
(1, 'testuser1', 'testuser', 'Test', 'User'),
(3, 'bobtampan65', '123456', 'Bob', 'Tampan');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`author_id`),
  ADD UNIQUE KEY `author_id` (`author_id`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`isbn`),
  ADD UNIQUE KEY `isbn` (`isbn`),
  ADD KEY `author_id` (`author_id`),
  ADD KEY `publisher_id` (`publisher_id`);

--
-- Indexes for table `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`publisher_id`),
  ADD UNIQUE KEY `publisher_id` (`publisher_id`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `isbn` (`isbn`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`author_id`) REFERENCES `authors` (`author_id`),
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`publisher_id`) REFERENCES `publishers` (`publisher_id`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`),
  ADD CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`isbn`) REFERENCES `books` (`isbn`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 06 2021 г., 22:52
-- Версия сервера: 10.4.19-MariaDB
-- Версия PHP: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `course_db`
--

-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `id` int(11) NOT NULL,
  `FullName` text DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Phone` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `client`
--

INSERT INTO `client` (`id`, `FullName`, `Address`, `Phone`) VALUES
(1, 'Подкін Гліб Олександрович', 'вул. Крошенська 28', '+380979447436'),
(4, 'Островський Владислав Вікторович', 'вул. Мала Бердичівська 1', '+380975263616'),
(5, 'Гуменюк Данило Сергійович', 'вул. Центральна 1а, с. Печанівка', '+380964018003'),
(6, 'Жукова Яна Володимиріна', 'м. Санкт-Петербург, РФ', '+79113149644'),
(7, 'Максимова Наталія Олександрівна', 'вул. П\'ясківського, с. Печанівка', '+380684416107');

-- --------------------------------------------------------

--
-- Структура таблицы `employees`
--

CREATE TABLE `employees` (
  `id` int(11) NOT NULL,
  `SecondName` text DEFAULT NULL,
  `FirstName` text DEFAULT NULL,
  `Position` text DEFAULT NULL,
  `BDay` date DEFAULT current_timestamp(),
  `Address` text DEFAULT NULL,
  `Phone` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `employees`
--

INSERT INTO `employees` (`id`, `SecondName`, `FirstName`, `Position`, `BDay`, `Address`, `Phone`) VALUES
(1, 'Івасюк', 'Богдан', 'Директор', '1997-05-14', 'вул. Жуйка 14', '+380679248551'),
(3, 'Бандера', 'Степан', 'Консультант', '2000-01-21', 'вул. Перемоги 15', '+380675962441'),
(4, 'Коновалов', 'Микола', 'Старший консультант', '2002-12-19', 'вул. Малікова 154', '+380978746035'),
(5, 'Путін', 'Володимир', 'Прибиральник', '1952-10-07', 'м. Москва, РФ', '+758487458');

-- --------------------------------------------------------

--
-- Структура таблицы `order`
--

CREATE TABLE `order` (
  `id` int(11) NOT NULL,
  `product_id` int(11) DEFAULT NULL,
  `employees_id` int(11) DEFAULT NULL,
  `client_id` int(11) DEFAULT NULL,
  `PublicateDate` date DEFAULT NULL,
  `ExecutionDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `order`
--

INSERT INTO `order` (`id`, `product_id`, `employees_id`, `client_id`, `PublicateDate`, `ExecutionDate`) VALUES
(8, 16, 4, 1, '2021-06-03', '2021-06-04'),
(9, 17, 3, 6, '2021-05-12', '2021-05-24');

-- --------------------------------------------------------

--
-- Структура таблицы `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `supply_id` int(11) DEFAULT NULL,
  `Name` text DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `Image` text DEFAULT NULL,
  `SupplyerPrice` float DEFAULT NULL,
  `Aviable` text DEFAULT NULL,
  `Count` int(11) DEFAULT NULL,
  `PriceForSale` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `product`
--

INSERT INTO `product` (`id`, `supply_id`, `Name`, `Description`, `Image`, `SupplyerPrice`, `Aviable`, `Count`, `PriceForSale`) VALUES
(16, 1, 'Apple MacBook Pro 13 2021', 'На сьогоднішній день на ринку представлені версії з різними «начинками». Вони відрізняються як параметрами процесорів і кількостями ядер, так і іншими важливими характеристиками.\r\nMacBook Pro 13 \"укомплектований чіпом M1, графічним і центральним процесором з 8 ядрами. Модель доступна з накопичувачами SSD 256, 512 ГБ, 1 або 2 ТБ і обсягом оперативної пам\'яті 8 або 16 ГБ.\r\nMacBook Pro 16 \"оснащені восьмиядерними процесорами i9 9-го покоління. Доступні з різним обсягом накопичувача - 512 ГБ і від 1 до 8 ТБ. У графічному процесорі також 8 ядер. Оперативна пам\'ять відрізняється від 16 до 64 ГБ в залежності від версії.', 'C:\\Users\\ostro\\Desktop\\DB\\imgs\\1.jpg', 50000, 'В наявності', 10, 52000),
(17, 8, 'Samsung 870 Evo-Series 500GB 2.5\" SATA III V-NAND TLC', 'Перед вами оновлена версія модуля пам\'яті SSD, який став найпопулярнішим на ринку*. Система пам\'яті 870 EVO базується на унікальних розробках Samsung для розробки SSD. Дана модель має підвищену продуктивність, міцність та відрізняється розширеною сумісністю. Крім цього, накопичувач відповідає вимогам розробників контенту, фахівців інформаційних технологій та користувачів інтернет-мережі.', 'C:\\Users\\ostro\\Desktop\\DB\\imgs\\2.jpg', 2000, 'Не має в наявності', 0, 2499);

-- --------------------------------------------------------

--
-- Структура таблицы `provider`
--

CREATE TABLE `provider` (
  `id` int(11) NOT NULL,
  `CompanyName` text DEFAULT NULL,
  `Provider` text DEFAULT NULL,
  `Phone` text DEFAULT NULL,
  `Address` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `provider`
--

INSERT INTO `provider` (`id`, `CompanyName`, `Provider`, `Phone`, `Address`) VALUES
(1, 'Apple Inc.', 'Jonh Brown', '+122832594', 'California, USA'),
(3, 'Micro-Star International', 'Mathew Perry', '+38069695612', 'вул. Бориса Тена 15 1/6'),
(5, 'Samsung Group', 'Олександр Олесь', '+380974125781', 'вул. Небесної Сотні 15, Київ'),
(6, 'AsusTek Computer Inc.', 'Lloyd Holmes', '+5688117574', 'Тайбей(Тайвань)'),
(7, 'Google LLC', 'Головач Олена', '+38063845485', 'вул. Карла Н\'юєла, м. Запоріжжя');

-- --------------------------------------------------------

--
-- Структура таблицы `supply`
--

CREATE TABLE `supply` (
  `id` int(11) NOT NULL,
  `SupplyerID` int(11) DEFAULT NULL,
  `Date` date DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `supply`
--

INSERT INTO `supply` (`id`, `SupplyerID`, `Date`) VALUES
(1, 1, '2021-04-12'),
(2, 3, '2021-06-02'),
(8, 5, '2021-05-18'),
(9, 6, '2021-05-31'),
(10, 7, '2021-05-06');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_id` (`product_id`),
  ADD KEY `employees_id` (`employees_id`),
  ADD KEY `client_id` (`client_id`);

--
-- Индексы таблицы `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`),
  ADD KEY `supply_id` (`supply_id`);

--
-- Индексы таблицы `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `supply`
--
ALTER TABLE `supply`
  ADD PRIMARY KEY (`id`),
  ADD KEY `SupplyerID` (`SupplyerID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `employees`
--
ALTER TABLE `employees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `order`
--
ALTER TABLE `order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `provider`
--
ALTER TABLE `provider`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `supply`
--
ALTER TABLE `supply`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `order_ibfk_2` FOREIGN KEY (`employees_id`) REFERENCES `employees` (`id`),
  ADD CONSTRAINT `order_ibfk_3` FOREIGN KEY (`client_id`) REFERENCES `client` (`id`);

--
-- Ограничения внешнего ключа таблицы `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`supply_id`) REFERENCES `supply` (`id`);

--
-- Ограничения внешнего ключа таблицы `supply`
--
ALTER TABLE `supply`
  ADD CONSTRAINT `supply_ibfk_1` FOREIGN KEY (`SupplyerID`) REFERENCES `provider` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

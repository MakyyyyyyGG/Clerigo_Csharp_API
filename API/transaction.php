<?php
header("Content-Type: application/json");

$host = 'localhost';
$db = 'lara';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $stmt = $pdo->query("SELECT transaction_id, category, cost, transaction_date FROM transactions");
    $transactions = $stmt->fetchAll();
    echo json_encode($transactions);
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    $sql = "INSERT INTO transactions (category, cost, transaction_date) VALUES (?, ?, NOW())";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$input['category'], $input['cost']]);
    echo json_encode(['message' => 'Transaction added successfully']);
}
?>

<?php
session_start();

require_once "config.php";

$sql = "SELECT * FROM article ORDER BY id DESC LIMIT 4;";
$result = $link->query($sql);

$sql2 = "SELECT * FROM product ORDER BY product_id ASC LIMIT 4;";
$result2 = $link->query($sql2);

if (isset($_GET['paid']) && $_GET['paid'] == 1) {
    if (!empty($_SESSION["shopping_cart"])) {
            unset($_SESSION["shopping_cart"]);
        }
    }


?>

<!DOCTYPE html>
<html class="index" lang="en">

<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <title>Good Food Home Page</title>
</head>

<body>
    <?php
    if (isset($_SESSION['id']) && (isset($_SESSION['username'])) && (isset($_SESSION['rank']))) {
        if ($_SESSION['rank'] == 'Normal') {
            include "./header-normal.php";
        } else {
            include "./header-member.php";
        }
    } elseif (!isset($_SESSION['id']) && (!isset($_SESSION['username']))) {
        include "./header.php";
    }
    ?>

    <!--<main>-->
    <main>
        <div class="carousel">
            <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
                <div class="carousel-inner" style="height:700px;">
                    <div class="carousel-item active">
                        <img src="../GoodFood/images/carousel1.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="../GoodFood/images/carousel2.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="../GoodFood/images/carousel3.jpg" class="d-block w-100" alt="...">
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
        <!-- cards -->
        <div class="card" style="padding-top: 10px; padding-left:200px; padding-right:200px; background-image:url(../GoodFood/images/bg.png);">
            <br>
            <hr>
            <h1><b>Newest Articles</b></h1>
            <table>
                <tr>
                    <?php if ($result->num_rows > 0) {
                        // Bind variables to the prepared statement as parameters
                        while ($row = $result->fetch_assoc()) {
                            echo '<td style="margin:0 10px 0 10px;">
                                    <div class="cards" style="width: 15rem; padding:15px">
                                        <img src="../GoodFood/images/' . $row['image'] . '" class="card-img-top" alt="..." style="object-fit:cover; height: 200px; width: 260px;">
                                        <div class="card-body">
                                            <h5 class="card-title">' . $row["title"] . '</h5>
                                            <p class="card-text" style="white-space:nowrap;overflow:hidden;text-overflow:ellipsis;width:250px;">' . $row["c_description"] . '. . .</p>
                                            <a href="readarticle.php?id=' . $row["id"] . '" class="btn btn-primary" id="1" style=";background-color:black; border-color:black;">Read More ></a>
                                        </div>
                                    </div>
                                </td>';
                        }
                    }
                    ?>

                    <!--</main>-->
                </tr>
            </table>
            <hr>
        </div>
        <div class="card" style="padding-left:200px; padding-right:200px;border:none;border-radius:0;background-image:url(../GoodFood/images/bg.png);">
            <br>
            <hr>
            <h1><b>Shop Items</b></h1>
            <table>
                <tr>
                    <?php if ($result2->num_rows > 0) {
                        // Bind variables to the prepared statement as parameters
                        while ($row2 = $result2->fetch_assoc()) {
                            echo '<td style="margin:0 10px 0 10px;">
                                    <div class="cards" style="width: 18rem;">
                                        <img src="../GoodFood/images/' . $row2['product_image'] . '" class="card-img-top" alt="..." style="object-fit:cover; height: 200px; width: 280px;">
                                        <div class="card-body">
                                            <h5 class="card-title">' . $row2["product_name"] . '</h5>
                                            <p class="card-text" style="white-space:nowrap;overflow:hidden;text-overflow:ellipsis;width:320px;">' . $row2["detail"] . '. . .</p>
                                            <a href="shop.php" class="btn btn-primary" id="1" style="background-color:black; border-color:black;">Go to shop ></a>
                                        </div>
                                    </div>
                                </td>';
                        }
                    }
                    ?>

                    <!--</main>-->
                </tr>
            </table>
            <hr>
        </div>
    </main>

    <?php include "./footer.php" ?>

</body>

</html>
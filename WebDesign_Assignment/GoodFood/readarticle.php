<?php
session_start();

require_once "config.php";

$id = $_GET['id'];
$sql = "SELECT * FROM article WHERE id = $id";
$result = $link->query($sql);

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <title>Good Food Article </title>
</head>

<body>
<?php
  if (isset($_SESSION['id']) && (isset($_SESSION['username'])) && (isset($_SESSION['rank']))) {
    if($_SESSION['rank'] == 'Normal'){
      include "./header-normal.php";
    }else{
      include "./header-member.php";
    }
  } elseif (!isset($_SESSION['id']) && (!isset($_SESSION['username']))) {
    include "./header.php";
  }
  ?>

    <main class="readMore">
        <!-- main -->
        <?php if ($result->num_rows != 0) {
            while ($row = $result->fetch_assoc()) {
                echo '
                <div ">
                <a href="javascript:history.back()" class="btn btn-primary" style="background-color:black; border-color:black;margin-bottom:20px;width:90%;">Go back</a>
                </div>
                <div class="titleHead">
                <h3>'.$row['title'].'</h3>
                <p>
                    <small>Publish date: '.$row['date'].'<br>
                        Author: '.$row['author'].'
                    </small>
                </p>
                <hr>
            </div>
    
            <img src="../GoodFood/images/'.$row['image'].'" class="articleImage" alt="News1"><br><br>
            <p class="content-text" id="firstParagraph">'.$row['content'].'</p><br>
            </div>';
            }
        }
        ?>

    </main>

</body>
<?php include "./footer.php" ?>

</html>
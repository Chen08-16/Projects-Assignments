<?php
session_start();

require_once "config.php";

$sql = "SELECT * FROM product ORDER BY product_id";
$result = $link->query($sql);

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
    <title>Good Food Event</title>
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

<main class="readMore" style="height: 734px;">
        <div class="container container-countDown">
            <div class="content-countDown">
                <h1>Sweepstake Countdown</h1><br>
                <h4>Winner of the sweepstake event will be announced once the timer hits 0.</h4>
                <h4>Announcement Date: Dec 25, 2022 00:00:00</h4>
                <h4>Stay tuned for the date!</h4>
                <div class="countDownTimer">
                    <div>
                        <p id="days">00</p>
                        <span>Days</span>
                    </div>
                    <div>
                        <p id="hours">00</p>
                        <span>Hours</span>
                    </div>
                    <div>
                        <p id="minutes">00</p>
                        <span>Minutes</span>
                    </div>
                    <div>
                        <p id="seconds">00</p>
                        <span>Seconds</span>
                    </div>
                </div>
                <br><br>
                <h2>Get your chance to win big prizes by buying tickets at our store now!</h2>
            </div>
        </div>
</main>

<?php include "./footer.php" ?>

<script type="text/javascript">

var countDownDate = new Date("Dec 25, 2022 00:00:00").getTime();

    var x = setInterval(function(){
        
        var now = new Date().getTime();
        var distance = countDownDate - now;

        var daysD = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hoursH = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutesM = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var secondsS = Math.floor((distance % (1000 * 60)) / 1000);

        document.getElementById("days").innerHTML = daysD ;
        document.getElementById("hours").innerHTML = hoursH ;
        document.getElementById("minutes").innerHTML = minutesM ;
        document.getElementById("seconds").innerHTML = secondsS;

        if (timeleft < 0) {
            clearInterval(x);
            document.getElementById("days").innerHTML = "00";
            document.getElementById("hours").innerHTML = "00";
            document.getElementById("minutes").innerHTML = "00";
            document.getElementById("seconds").innerHTML = "00";
        }

    },1000);

</script>

</body>
</html>
<!DOCTYPE html>
<html class="index" lang="en">

<div class ="header">
<nav class="navbar navbar-expand-lg bg-white sticky-top navbar-light p-3 shadow-sm">
    <div class="container">
      <a class="navbar-brand" href="index.php"><i class="fa-solid fa-shop me-2"></i><strong>GOOD FOOD</strong></a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

        <ul class="navbar-nav ms-auto ">
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" aria-current="page" href="index.php">Home</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="articles.php">Articles</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="shop.php">Shop</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="meal.php">Meal Planning</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="event.php">Events</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="aboutus.php">About Us</a>
          </li>
        </ul>
        <ul class="navbar-nav ms-auto ">
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="shopping-cart.php"><i class="fa-solid fa-cart-shopping me-1"></i> Cart</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="account.php"><i class="fa-solid fa-circle-user me-1"></i> Account</a>
          </li>
          <li class="nav-item">
            <a class="nav-link mx-2 text-uppercase" href="#" data-bs-toggle="modal" data-bs-target="#staticBackdrop"><i class="fa-solid fa-circle-user me-1"></i> Logout</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>
</div>

<!-- Modal -->
<div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Log Out Confirmation</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        Are you sure you want to logout?
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary" style="background-color:black;"onclick="location.href='logout.php'">Yes</button>
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">No</button>
      </div>
    </div>
  </div>
</div>

</html>

@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center text-light">
    <h1 class="display-4 text-light">Bem Vindo à Auto Escola É o Braia</h1>

    <div class="container">
        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="~/img/banner.jfif" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="~/img/cnh.jfif" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="~/img/tipos.jfif" class="d-block w-100" alt="...">
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
</div>

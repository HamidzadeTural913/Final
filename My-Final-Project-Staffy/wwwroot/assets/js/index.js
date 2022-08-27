
$('.count').each(function () {
    $(this).prop('Counter',0).animate({
        Counter: $(this).text()
    }, {
        duration: 3000,
        easing: 'swing',
        step: function (now) {
            $(this).text(Math.ceil(now));
        }
    });
});

var head = document.querySelectorAll(".tabs-menu .tab-head-card .tab-head .tab-head-link")
var body = document.querySelectorAll(".tabs-menu .tab-body-card .tab-body")

for (const tabhead of head) {
    tabhead.addEventListener("click", function () {
        let activreng = document.querySelector(".activ-reng")
        activreng.classList.remove("activ-reng")
        this.classList.add("activ-reng")
        let id = tabhead.getAttribute("data-id")
        for (const tabbody of body) {
            if (tabbody.getAttribute("data-id") == id) {
                tabbody.classList.add("active")
            }
            else {
                tabbody.classList.remove("active")
            }
        }
    })
}

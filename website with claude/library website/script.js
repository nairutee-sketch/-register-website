$(function () {
  "use strict";

  /* ===================== BOOK DATA ===================== */
  /* All titles, authors, and excerpts below are fictional, written for this demo. */
  var books = [
    {
      id: 1, title: "The Long Way to Harrow", author: "Odalys Fenn",
      genre: "Fiction", call: "813.54", price: 14.99, color: "#7A2E3B",
      desc: "Two estranged sisters drive the length of an old coastal road to close their late father's shop.",
      excerpt: "The shop key had not left her mother's key ring in eleven years, and now it sat in Wren's palm like something borrowed from a museum. She did not remember the door being so narrow. She did not remember the bell above it either, but it rang all the same when she pushed inside, sending a small brass sound into the dust and the dark and the smell of her father, which was cedar and machine oil and, faintly, peppermint."
    },
    {
      id: 2, title: "Six Doors, One Key", author: "R. M. Castellan",
      genre: "Mystery", call: "133.8", price: 12.5, color: "#1F2A38",
      desc: "A locksmith is hired to open a house that six previous owners swear has no doors at all.",
      excerpt: "Marek had opened stranger things than doors that did not want to be doors — safes bricked into chimneys, trunks welded shut by rust and spite — but he had never been paid, in cash, up front, to open something the owner insisted was not there. 'There is no door,' Ms. Okafor said again, calmly, as if repeating it might make it truer. 'There is a wall. I would like you to open the wall.'"
    },
    {
      id: 3, title: "Weather for Beginners", author: "Juno Ade",
      genre: "Poetry", call: "808.1", price: 11.0, color: "#435544",
      desc: "A debut collection tracking one year of a small city through its storms, thaws, and long grey Marches.",
      excerpt: "In January the river / forgets its own name, / goes hard and white and nameless / under the bridge we still call / the bridge, though nothing / underneath it moves."
    },
    {
      id: 4, title: "Orbit of Quiet Things", author: "Priya Halden",
      genre: "Sci-Fi", call: "813.87", price: 16.99, color: "#7A2E3B",
      desc: "A maintenance engineer on a dying space station discovers the silence she was sent to fix isn't mechanical.",
      excerpt: "The station had been quiet for six days, which should not have alarmed anyone, since silence was the entire point of Deck Four. It was the kind of quiet you built on purpose, with foam and steel and triple-sealed doors, so that the listening arrays two decks up could hear the whole cold universe without so much as a fan humming underneath it. Which was why, on the seventh day, when Deck Four made a sound, Rae heard it before anyone else did — and wished, immediately, that she had not."
    },
    {
      id: 5, title: "Everything We Kept", author: "Odalys Fenn",
      genre: "Nonfiction", call: "306.85", price: 18.0, color: "#B8924A",
      desc: "An essay collection on the objects families argue over after a death, and what those arguments are really about.",
      excerpt: "Nobody fights over the good china because they love the china. They fight over it because the china was the last thing their mother touched with both hands steady, and once it is divided, so is that memory, into however many pieces there are people left to want it."
    },
    {
      id: 6, title: "A Softer Kind of Loud", author: "Marisol Trent",
      genre: "Romance", call: "813.6", price: 13.5, color: "#7A2E3B",
      desc: "A noise-sensitive sound engineer and the touring musician renting the flat upstairs learn to share a wall.",
      excerpt: "She had rules about noise the way other people had rules about money: strict, private, slightly embarrassing to say out loud. Rule one was no bass after nine. Rule four, added just last week, was do not learn the upstairs neighbor's tour schedule by heart. She was already breaking rule four. She had been breaking it since Tuesday, since the first time his guitar came softly through the ceiling and she found herself lying very still on the floor, listening, instead of turning on the fan like a reasonable woman would."
    },
    {
      id: 7, title: "The Understudy's Almanac", author: "Femi Osei",
      genre: "Fiction", call: "822.9", price: 15.25, color: "#435544",
      desc: "Told over one theater season, an understudy keeps a private record of every performance she never got to give.",
      excerpt: "By March she had understudied four roles and gone on for none of them, and had begun, in the margins of her script, keeping a record of the performances that existed only in the dressing room mirror: opening night, the matinee she'd have played louder, the closing show she'd have played almost silent, on purpose, just to see if anyone in the back row noticed the difference."
    },
    {
      id: 8, title: "Cartography of Small Towns", author: "R. M. Castellan",
      genre: "Nonfiction", call: "917.3", price: 19.99, color: "#1F2A38",
      desc: "A map-maker's field notes from ten years spent charting towns too small for any atlas to bother with.",
      excerpt: "There is no official population count for Petrel's Bend, because no one in Petrel's Bend has agreed to be counted the same way twice. The town clerk gave me three different numbers in one afternoon, each one correct, she insisted, for a different definition of who counts as living there."
    },
    {
      id: 9, title: "The Physics of Almost", author: "Priya Halden",
      genre: "Sci-Fi", call: "530.11", price: 17.5, color: "#B8924A",
      desc: "A theoretical physicist builds a machine that shows her every version of a decision she almost made.",
      excerpt: "The machine did not show the future. Dr. Anwen Cole was careful, always, to correct people on this point, usually more sharply than the question deserved. It showed the almost: the version of the dinner party where she'd said yes instead of no, the version of the job offer she'd turned down on a Tuesday for reasons she could no longer fully reconstruct. Small, private, unlived lives, stacked up like unopened mail."
    },
    {
      id: 10, title: "Low Tide Confessions", author: "Marisol Trent",
      genre: "Mystery", call: "813.6", price: 13.99, color: "#435544",
      desc: "A harbor town's annual low tide reveals a boat that sank thirty years ago, and everyone remembers it differently.",
      excerpt: "Every forty years or so the tide went low enough to show the Merribel's hull, and every time it did, someone in town swore they remembered the sinking a little differently than they had the decade before — a different hour, a different weather, a different name shouted from the dock. Constable Yu had stopped correcting people. She had started, instead, writing the versions down."
    },
    {
      id: 11, title: "Field Notes on Staying", author: "Femi Osei",
      genre: "Poetry", call: "808.1", price: 10.5, color: "#7A2E3B",
      desc: "Short poems written in the margins of a decade spent choosing, again and again, not to leave.",
      excerpt: "Everyone I loved left this town / eventually, gently, the way / a kettle leaves a boil — / and I stayed to hear / the small click of the room / going quiet again."
    },
    {
      id: 12, title: "The Last Good Referral", author: "Juno Ade",
      genre: "Nonfiction", call: "331.25", price: 20.0, color: "#1F2A38",
      desc: "A former recruiter examines what 'who you know' really costs the people who don't know anyone.",
      excerpt: "Every job I ever got, I got because someone already inside the building said my name out loud in a room I wasn't in. I did not understand this was a system until I tried to build the same door for someone else and found there was no handle on my side either."
    }
  ];

  var cart = []; // array of book ids

  /* ===================== RENDER CATALOG ===================== */
  function bookCardHTML(b) {
    var initials = b.title.split(" ").slice(0, 2).map(function (w) { return w[0]; }).join("");
    return (
      '<div class="col-sm-6 col-lg-4 book-col" data-genre="' + b.genre + '" data-title="' + b.title.toLowerCase() + '" data-author="' + b.author.toLowerCase() + '">' +
        '<div class="book-card">' +
          '<div class="book-cover" style="background:' + b.color + ';">' + initials + '</div>' +
          '<span class="book-call">' + b.call + ' &middot; ' + b.genre + '</span>' +
          '<h3 class="book-title">' + b.title + '</h3>' +
          '<p class="book-author">' + b.author + '</p>' +
          '<p class="book-desc">' + b.desc + '</p>' +
          '<div class="book-foot"><span class="book-price">$' + b.price.toFixed(2) + '</span></div>' +
          '<div class="book-actions">' +
            '<button class="btn-sm-outline js-read" data-id="' + b.id + '">Read sample</button>' +
            '<button class="btn-sm-solid js-add" data-id="' + b.id + '">Buy</button>' +
          '</div>' +
        '</div>' +
      '</div>'
    );
  }

  var $grid = $("#bookGrid");
  books.forEach(function (b) { $grid.append(bookCardHTML(b)); });
  $("#statBooks").text(books.length);

  /* staff picks: fixed three, styled differently */
  var pickIds = [4, 1, 3];
  var pickNotes = {
    4: "\u201CStarts quiet and does not let go \u2014 finished it in one sitting.\u201D",
    1: "\u201CThe kind of family story that earns its ending.\u201D",
    3: "\u201CReads like the year actually felt. Short poems, long echo.\u201D"
  };
  var $picksRow = $("#picksRow");
  pickIds.forEach(function (id) {
    var b = books.find(function (x) { return x.id === id; });
    $picksRow.append(
      '<div class="col-md-4">' +
        '<div class="pick-card">' +
          '<span class="book-call">' + b.call + ' &middot; ' + b.genre + '</span>' +
          '<strong>' + b.title + '</strong>' +
          '<p class="book-author">' + b.author + '</p>' +
          '<p class="pick-note">' + pickNotes[id] + '</p>' +
        '</div>' +
      '</div>'
    );
  });

  /* ===================== FILTER + SEARCH ===================== */
  var activeGenre = "all";

  function applyFilters() {
    var query = $("#searchInput").val().trim().toLowerCase();
    var visible = 0;

    $(".book-col").each(function () {
      var $col = $(this);
      var genreOK = activeGenre === "all" || $col.data("genre") === activeGenre;
      var textOK = !query ||
        $col.data("title").indexOf(query) !== -1 ||
        $col.data("author").toString().indexOf(query) !== -1;

      if (genreOK && textOK) {
        $col.removeClass("d-none");
        visible++;
      } else {
        $col.addClass("d-none");
      }
    });

    $("#resultCount").text(visible + (visible === 1 ? " title" : " titles") + " on this shelf");
    $("#emptyState").toggleClass("d-none", visible !== 0);
  }

  $("#genrePills").on("click", ".pill", function () {
    $(".pill").removeClass("active");
    $(this).addClass("active");
    activeGenre = $(this).data("genre");
    applyFilters();
  });

  $("#searchInput").on("input", applyFilters);

  applyFilters();

  /* ===================== READ SAMPLE MODAL ===================== */
  var $readModal = $("#readModal");
  var readModalInstance = new bootstrap.Modal($readModal[0]);

  $(document).on("click", ".js-read", function () {
    var id = parseInt($(this).data("id"), 10);
    var b = books.find(function (x) { return x.id === id; });
    if (!b) return;

    $("#modalCallNumber").text(b.call + " \u00B7 " + b.genre);
    $("#modalTitle").text(b.title);
    $("#modalAuthor").text(b.author);
    $("#modalExcerpt").text(b.excerpt);
    $("#modalPrice").text("$" + b.price.toFixed(2));
    $("#modalAddToCart").data("id", b.id);

    readModalInstance.show();
  });

  $("#modalAddToCart").on("click", function () {
    var id = parseInt($(this).data("id"), 10);
    addToCart(id);
    readModalInstance.hide();
  });

  /* ===================== CART ===================== */
  var cartOffcanvasEl = document.getElementById("cartPanel");

  function addToCart(id) {
    cart.push(id);
    renderCart();

    var $btn = $('.js-add[data-id="' + id + '"]');
    var original = $btn.text();
    $btn.addClass("added").text("Added");
    setTimeout(function () { $btn.removeClass("added").text(original); }, 900);
  }

  $(document).on("click", ".js-add", function () {
    addToCart(parseInt($(this).data("id"), 10));
  });

  function renderCart() {
    var $items = $("#cartItems").empty();
    var total = 0;

    if (cart.length === 0) {
      $("#emptyCart").removeClass("d-none");
      $("#checkoutBtn").prop("disabled", true);
    } else {
      $("#emptyCart").addClass("d-none");
      $("#checkoutBtn").prop("disabled", false);

      var counts = {};
      cart.forEach(function (id) { counts[id] = (counts[id] || 0) + 1; });

      Object.keys(counts).forEach(function (idKey) {
        var id = parseInt(idKey, 10);
        var b = books.find(function (x) { return x.id === id; });
        var qty = counts[idKey];
        total += b.price * qty;

        $items.append(
          '<div class="cart-line" data-id="' + id + '">' +
            '<div>' +
              '<div class="cart-line-title">' + b.title + (qty > 1 ? " &times; " + qty : "") + '</div>' +
              '<div class="cart-line-author">' + b.author + '</div>' +
              '<button class="cart-remove js-remove" data-id="' + id + '">Remove</button>' +
            '</div>' +
            '<div>$' + (b.price * qty).toFixed(2) + '</div>' +
          '</div>'
        );
      });
    }

    $("#cartTotal").text("$" + total.toFixed(2));
    $("#cartCount").text(cart.length);
  }

  $(document).on("click", ".js-remove", function () {
    var id = parseInt($(this).data("id"), 10);
    var idx = cart.indexOf(id);
    if (idx !== -1) cart.splice(idx, 1);
    renderCart();
  });

  $("#checkoutBtn").on("click", function () {
    var count = cart.length;
    cart = [];
    renderCart();
    bootstrap.Offcanvas.getInstance(cartOffcanvasEl).hide();
    $("#joinFeedback").text("Order placed \u2014 " + count + " book" + (count === 1 ? "" : "s") + " on the way. (Demo only.)");
    setTimeout(function () { $("#joinFeedback").text(""); }, 4000);
  });

  renderCart();

  /* ===================== JOIN FORM ===================== */
  $("#joinForm").on("submit", function (e) {
    e.preventDefault();
    var email = $("#joinEmail").val().trim();
    if (!email) return;
    $("#joinFeedback").text("You're on the list \u2014 first pick lands Friday.");
    $("#joinEmail").val("");
  });

  /* ===================== HEADER SCROLL STATE ===================== */
  var $header = $("#siteHeader");
  $(window).on("scroll", function () {
    $header.toggleClass("scrolled", $(window).scrollTop() > 12);
  });
});

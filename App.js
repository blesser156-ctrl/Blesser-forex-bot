document.addEventListener("DOMContentLoaded", function () {

    let running = false;
    let connected = false;
    let balance = 10000;
    let pnl = 0;

    const start = document.getElementById("start");
    const stop = document.getElementById("stop");
    const emergency = document.getElementById("emergency");
    const connect = document.getElementById("connect");

    const status = document.getElementById("status");
    const balanceEl = document.getElementById("balance");
    const pnlEl = document.getElementById("pnl");
    const connection = document.getElementById("connection");
    const logEl = document.getElementById("log");

    function log(message) {
        logEl.textContent =
            new Date().toLocaleTimeString() + " — " + message;
    }

    function updateScreen() {

        status.textContent = running ? "RUNNING" : "STOPPED";

        status.style.color =
            running ? "#22c55e" : "#ef4444";

        balanceEl.textContent =
            "$" + balance.toFixed(2);

        pnlEl.textContent =
            (pnl >= 0 ? "+$" : "-$") +
            Math.abs(pnl).toFixed(2);
    }

    connect.addEventListener("click", function () {

        connected = true;

        connection.textContent =
            "MT5: Demo Connected ✓";

        connection.className = "online";

        connect.textContent =
            "CONNECTED ✓";

        log("Demo connection successful.");
    });

    start.addEventListener("click", function () {

        if (!connected) {

            log("Please connect the demo first.");

            connection.textContent =
                "MT5: Not Connected — tap CONNECT DEMO";

            return;
        }

        running = true;

        updateScreen();

        log("Bot started in DEMO mode.");
    });

    stop.addEventListener("click", function () {

        running = false;

        updateScreen();

        log("Bot stopped.");
    });

    emergency.addEventListener("click", function () {

        running = false;

        updateScreen();

        log("EMERGENCY STOP activated.");
    });

    setInterval(function () {

        if (!running) return;

        const movement =
            (Math.random() - 0.5) * 2;

        pnl += movement;
        balance += movement;

        updateScreen();

    }, 3000);

    updateScreen();

    log("Forex Bot V1 ready.");

});

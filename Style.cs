* {
    box-sizing: border-box;
}

body {
    margin: 0;
    font-family: Arial, sans-serif;
    background: #0f172a;
    color: white;
}

.container {
    max-width: 650px;
    margin: auto;
    padding: 20px;
}

h1 {
    text-align: center;
    margin-bottom: 5px;
}

.subtitle {
    text-align: center;
    color: #94a3b8;
    margin-bottom: 25px;
}

.card {
    background: #1e293b;
    border-radius: 14px;
    padding: 18px;
    margin-bottom: 15px;
}

.status-card {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

#status {
    color: #ef4444;
}

#connection {
    background: #0f172a;
    padding: 12px;
    border-radius: 8px;
    margin-bottom: 12px;
    color: #94a3b8;
}

.online {
    color: #22c55e !important;
}

label {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin: 12px 0;
    color: #cbd5e1;
}

input {
    width: 130px;
    padding: 10px;
    border: 1px solid #475569;
    border-radius: 7px;
    background: #0f172a;
    color: white;
}

.row {
    display: flex;
    justify-content: space-between;
    padding: 10px 0;
    border-bottom: 1px solid #334155;
}

.buttons {
    display: grid;
    gap: 10px;
    margin-bottom: 15px;
}

button {
    width: 100%;
    padding: 15px;
    border: none;
    border-radius: 9px;
    font-size: 15px;
    font-weight: bold;
    cursor: pointer;
}

.green {
    background: #22c55e;
    color: #052e16;
}

.blue {
    background: #3b82f6;
    color: white;
}

.gray {
    background: #475569;
    color: white;
}

.red {
    background: #ef4444;
    color: white;
}

#log {
    background: #0f172a;
    padding: 15px;
    border-radius: 8px;
    color: #cbd5e1;
    min-height: 50px;
}

.warning {
    text-align: center;
    color: #f59e0b;
    font-size: 12px;
    margin-top: 20px;
}

@media (max-width: 480px) {
    .container {
        padding: 12px;
    }

    label {
        gap: 10px;
    }

    input {
        width: 110px;
    }
}

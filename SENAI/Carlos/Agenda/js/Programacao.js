// Variáveis globais para armazenar a data atual
let currentDate = new Date();
let currentMonth = currentDate.getMonth();
let currentYear = currentDate.getFullYear();

// Função para gerar o calendário de um mês específico
function generateCalendar(month, year) {
    const monthYearElement = document.getElementById('monthYear');
    const daysElement = document.getElementById('days');

    // Exibir o mês e o ano
    monthYearElement.innerText = `${getMonthName(month)} ${year}`;

    // Limpar o calendário atual
    daysElement.innerHTML = '';

    // Obter o primeiro dia do mês e o número de dias no mês
    const firstDay = new Date(year, month, 1).getDay();
    const daysInMonth = new Date(year, month + 1, 0).getDate();

    // Criar as células do calendário
    let day = 1;
    for (let i = 0; i < 6; i++) { // Até 6 linhas de dias (semana)
        const row = document.createElement('tr');
        for (let j = 0; j < 7; j++) { // 7 dias na semana
            const cell = document.createElement('td');

            // Preencher os dias
            if (i === 0 && j < firstDay) {
                cell.innerText = ''; // Espaços vazios antes do primeiro dia
            } else if (day <= daysInMonth) {
                cell.innerText = day;
                day++;
            }

            row.appendChild(cell);
        }
        daysElement.appendChild(row);
    }
}

// Gerar a lista de meses na barra lateral
function generateMonthsList() {
    const monthsListElement = document.getElementById('monthsList');
    months.forEach((month, index) => {
        const listItem = document.createElement('li');
        listItem.innerText = month;
        listItem.addEventListener('click', () => {
            currentMonth = index;
            generateCalendar(currentMonth, currentYear);
        });
        monthsListElement.appendChild(listItem);
    });
}

// Função auxiliar para obter o nome do mês
function getMonthName(monthIndex) {
    const months = [
        'Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho',
        'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'
    ];
    return months[monthIndex];
}

// Gerar o calendário inicial
generateCalendar(currentMonth, currentYear);

// Gerar a lista de meses na barra lateral
generateMonthsList();

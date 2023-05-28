const form = document.querySelector('.form');
const span = document.querySelector('#error');

form.addEventListener('submit', (event) => {
    event.preventDefault();

    const codigo = document.querySelector('input[name="codigo"]').value.trim();
    const nome = document.querySelector('input[name="nome"]').value.trim();
    const funcao = document.querySelector('input[name="funcao"]').value.trim();

    if (codigo === "") {
        displayErrorMessage("Código", true);
        return;
    }

    if (nome === "") {
        displayErrorMessage("Nome", true);
        return;
    }

    if (funcao === "") {
        displayErrorMessage("Função", true);
        return;
    }

    displayErrorMessage("", false);
    form.submit(); // Envio do formulário
});

const displayErrorMessage = (field, show) => {
    if (show) {
        span.textContent = `O campo ${field} deve ser preenchido!`;
        span.classList.add('error');
    } else {
        span.textContent = "";
    }
}
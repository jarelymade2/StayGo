// Function to handle the number counters for children and adults
function setupNumberCounters() {
    document.querySelectorAll('.number-counter').forEach(counter => {
        const minusBtn = counter.querySelector('.btn-minus');
        const plusBtn = counter.querySelector('.btn-plus');
        const input = counter.querySelector('input');

        minusBtn.addEventListener('click', () => {
            let value = parseInt(input.value);
            if (value > 0) {
                input.value = value - 1;
            }
        });

        plusBtn.addEventListener('click', () => {
            let value = parseInt(input.value);
            input.value = value + 1;
        });
    });
}

// Run the setup function when the page loads
document.addEventListener('DOMContentLoaded', setupNumberCounters);
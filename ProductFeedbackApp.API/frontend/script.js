const apiUrl = "https://localhost:7058/api/feedback";

document.getElementById("feedbackForm").addEventListener("submit", async (e) => {
    e.preventDefault();

    const feedback = {
        name: document.getElementById("name").value,
        message: document.getElementById("message").value,
        rating: parseInt(document.getElementById("rating").value)
    };

    const res = await fetch(apiUrl, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(feedback)
    });

    const data = await res.json();
    alert(data.message);
    e.target.reset();
});

async function loadFeedback() {
    const res = await fetch(apiUrl);
    const feedbacks = await res.json();

    const list = document.getElementById("feedbackList");
    list.innerHTML = "";
    feedbacks.forEach(fb => {
        const li = document.createElement("li");
        li.textContent = `${fb.name} (${fb.rating}/5): ${fb.message}`;
        list.appendChild(li);
    });
}

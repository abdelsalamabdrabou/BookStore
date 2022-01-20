let dataTable = $('#bookTable').DataTable({
    "ajax": {
        "url": "/Admin/Book/GetBooks",
        "type": "GET",
    },
    "columns": [
        { "data": "isbn" },
        { "data": "title" },
        { "data": "author" },
        { "data": "publisher" },
        { "data": "purchasePrice" },
        { "data": "offeringPrice" },
        { "data": "edition" },
        { "data": "publicationYear" },
        { "data": "status" },
        { "data": "quantity" },
        {
            "data": "bookId",
            "render": function (data) {
                return `
                    <a href="/Admin/Book/Index?id=${data}" class="btn btn-success p-2">Edit</a>
                    <button onclick="MyDelete('${data}')" id="toastbtn" class="btn btn-danger p-2">Delete</button>
                `;
            }
        }
    ]
});

function MyDelete(bookId) {
    var toastElList = [].slice.call(document.querySelectorAll('.toast'))
    var toastList = toastElList.map(function (toastEl) {
        return new bootstrap.Toast(toastEl)
    })

    let isConfirmed = confirm("Are you sure to delete?");

    if (isConfirmed) {
        $.ajax({
            url: "/Admin/Book/Delete?id=" + bookId,
            type: "DELETE",
            success: function (data) {
                if (data.success) {
                    document.getElementById("toastHeader").setAttribute("class", "toast-header text-white bg-success");
                    document.getElementById("toastBody").innerHTML = "Book has been successfully deleted";
                    dataTable.ajax.reload();
                }
                else {
                    document.getElementById("toastHeader").setAttribute("class", "toast-header text-white bg-danger");
                    document.getElementById("toastBody").innerHTML = "Error has been occured";
                }

                toastList.forEach(toast => toast.show());                 
            }
        })
    }
}

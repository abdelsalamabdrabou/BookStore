let dataTable = $('#bookTable').DataTable({
    "ajax": {
        "url": "/Admin/Order/GetOrders",
        "type": "GET",
    },
    "columns": [
        { "data": "trackingNumber" },
        { "data": "customer" },
        { "data": "orderStatus" },
        { "data": "paymentStatus" },
        { "data": "processedBy" },
        {
            "data": "orderId",
            "render": function (data) {
                return `
                    <a href="/Admin/Order/Details?id=${data}" class="btn btn-success p-2">Show</a>
                `;
            }
        },
        {
            "data": "orderId",
            "render": function (data) {
                return `
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
            url: "/Admin/Order/Delete?id=" + bookId,
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

let dataTable = $("#rolesTable").DataTable({
    "ajax": {
        "url": "/Admin/Roles/GetRoles",
        "type": "GET"
    },
    "columns": [
        { "data": "roleId", "width": "25%" },
        { "data": "roleName" },
        {
            "data": "roleId",
            "render": function (data) {
                return `
                    <div class="btn-group" role="group">
                        <button id="btnGroupDrop1" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Actions
                        </button>
                        <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
                            <a class="dropdown-item" href="/Admin/Roles/ManagePermissions?id=${data}">Manage Permissions</a>
                            <a class="dropdown-item" href="#" onclick="Delete('${data}')" id="toastbtn">Delete</a>
                        </div>
                    </div>
                `;
            }
        }
    ]
})

function Delete(id) {
    var toastElList = [].slice.call(document.querySelectorAll('.toast'))
    var toastList = toastElList.map(function (toastEl) {
        return new bootstrap.Toast(toastEl)
    })

    let isConfirmed = confirm("Are you sure to delete?");

    if (isConfirmed) {
        $.ajax({
            url: "/Admin/Roles/Delete?id=" + id,
            type: "DELETE",
            success: function (data) {
                if (data.success) {
                    document.getElementById("toastHeader").setAttribute("class", "toast-header text-white bg-success");
                    document.getElementById("toastBody").innerHTML = "Role has been successfully deleted";
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
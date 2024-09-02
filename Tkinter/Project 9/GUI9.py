import tkinter as tk
from tkinter import ttk
from random import choice

window = tk.Tk()
window.title("Excel")
window.geometry("800x600")

# data
first_name = [
"Irgo",
"Sarah",
"Evandro",
"Giovana",
"Naiara",
"Christian",
"Cleiton",
"Daniel",
"Thiago",
"Tiago"
]

last_name = [
"Pinto",
"Nascimento",
"Cleiton",
"Gio",
"Grazina",
"da Naiara",
"Evandro",
"Alves",
"Braga",
"Neto"
]

#tree view
table = ttk.Treeview(master = window, columns = ("first", "last", "email"), show = "headings")
table.heading("first", text = "First Name")
table.heading("last", text = "Last Name")
table.heading("email", text = "Email")

# Insert Values
for i in range(100):
    first = choice(first_name)
    last = choice(last_name)
    email = f"{first}{last}@gmail.com"
    data = (first, last, email)
    table.insert(parent = "", index = 0, values = data)

table.pack(fill = "both", expand = True)

# Event

def item_select(_):
    for i in table.selection():
        print(table.item(i)["values"])
    # table.item(table.selection())

def delete_items(_):
    print("Delete")
    for i in table.selection():
        table.delete(i)

table.bind("<<TreeviewSelect>>", item_select)
table.bind("<Delete>", delete_items)


window.mainloop()
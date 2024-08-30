import tkinter as tk
from tkinter import ttk

def print_string_var():
    print(string_var.get())
    string_var.set("Button pressed")

window = tk.Tk()
window.title("Tkinter Variables")
window.geometry("800x600")

# Tkinter variable
string_var = tk.StringVar(value = "Start Value")


label = ttk.Label(master = window, textvariable= string_var)
label.pack()

entry = ttk.Entry(master = window, textvariable = string_var)
entry.pack()

button = ttk.Button(master = window, text = "button", command = print_string_var)
button.pack()

window.mainloop()


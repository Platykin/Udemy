import tkinter as tk
from tkinter import ttk

def button_func():
    #get content of the entry
    entry_text = entry.get()

    #uptade label
    label["text"] = entry_text
    entry["state"] = "disabled"

def text_back():
    label["text"] = "some text"
    entry["state"] = "normal"

# Window
window = tk.Tk()
window.title("Getting and setting widgets")
window.geometry("800x600")


# Widgets
label = tk.Label(master = window, text = "Test label")
label.pack()

entry = tk.Entry(master = window, text = "Test entry")
entry.pack()

button = tk.Button(master = window, text = "Test Button", command = button_func)
button.pack()

# Button test
button_test = ttk.Button(master = window, command = text_back, text = "Fixing button")
button_test.pack()
# Run
window.mainloop()
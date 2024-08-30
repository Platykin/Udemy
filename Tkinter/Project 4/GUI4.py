import tkinter as tk
from tkinter import ttk

# Window
window = tk.Tk()
window.title("Tkinter Variables")

# Tkinter Variables
string_variable = tk.StringVar(value = "test")

# Widgets
entry1 = ttk.Entry(master = window, textvariable = string_variable)
entry1.pack()
entry2 = ttk.Entry(master = window, textvariable = string_variable)
entry2.pack()
label = ttk.Label(master = window, textvariable = string_variable)
label.pack()


# Run
window.mainloop()
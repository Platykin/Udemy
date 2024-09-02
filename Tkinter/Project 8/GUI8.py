import tkinter as tk
from tkinter import ttk


window = tk.Tk()
window.title("Combo and Spin")
window.geometry("800x600")

# combobox
types_of_windows = (
"boxcar",
"triang",
"blackman",
"hamming",
"hann",
"bartlett",
"flattop",
"parzen",
"bohman",
"blackmanharris",
"nuttall",
"barthann",
"cosine",
"exponential",
"tukey",
"taylor",
"lanczos"
)

types_of_windows_var = tk.StringVar(value= types_of_windows[0])

combo = ttk.Combobox(master = window, textvariable = types_of_windows_var)
combo["values"] = types_of_windows
combo.pack()

combo.bind("<<ComboboxSelected>>", lambda event: print(types_of_windows_var.get()))

spin = ttk.Spinbox(master = window, from_ = 0, to = 99, increment = 9)
spin.pack()

values_letters = (
"A",
"B",
"C",
"D",
"E"
)

value_letters_var = tk.StringVar(value = values_letters[0])
spin_ex = ttk.Spinbox(master = window, textvariable = value_letters_var, values = values_letters)
spin_ex.bind("<<Decrement>>", lambda event: print("Decrement"))
spin_ex.pack()


window.mainloop()
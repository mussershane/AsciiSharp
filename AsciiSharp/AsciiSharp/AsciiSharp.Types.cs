using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiSharp.Types {
    interface IControllable {
        char avatar { get; set; }
        void Move(direction myDir);
        void Disable();
        void Enable();
    }

    interface IInteractable {
        char avatar { get; set; }
        void Remove();
    }

    enum direction { up, down, left, right };
    
}

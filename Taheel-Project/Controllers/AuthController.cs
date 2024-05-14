﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taheel_Project.Controllers
{
    [ApiController]
    [Route("suite/webapi")]
    public class AuthController : ControllerBase
    {
 
        public AuthController()
        {
      
        }

        [HttpPost("applicantLogin")]
        public string ApplicantLogin([FromBody] string data)
        {
            // Actions within this controller

            return "72QpQmtBAvxliu9TErCZhsB6F2RC5xprZZ%2FgztH75P0X4fNlgf3LDLB6xdQ044nB%2Fd4fVM%2FNoXjs70Ip00rL8FB777eHkMcUeVwnnNnwABg8KPz7nUp1HT2BYbEy8UkQk84UOvOIkjeL%2FdFHfSAAMg";
        }

        [HttpPost("verifyOTP")]
        public string verifyOTP([FromBody] string data)
        {
            // Actions within this controller

            return "72QpQmtBAvxliu9TErCZhsB6F2RC5xprZZ%2FgztH75P2q%2F6YyCp0HA9FoE1Q8CC83PyShBfGcWbqzb6nj57Ub0njybBdn6H883%2Fc3b1Vux1dhfqfW2yD3nyp2%2BmyjWsahp2721pZXNhV%2Fm6zQcX1kAnFM7EIO0jiiy2fXPTbLE45hmHg3Hb0PlhUihV5BUTjzq2f5b48wiNyM7KWyV0ATG2XvR%2Bi8hWmGg%2By%2FwRSoeHkHeQrwso7Z6Q9KH4xchG4LSCO1JT2g%2BTzmu20So9utl86NS3kfFfAuj4KKRSmKPnG4ERAcva%2FqfxN4iQXpkRGu0AOonRASqWnzTGE2ejuSmZuuTakiYOwaVjB1jznOVci%2FDP0YglOkIuE6VceqGcuswdZZcuCUXhvLAhChhZmc0ooxcmp6uWVMU454%2BXjs4sCs5nqmJn4F5YLgfZVVZttK245DlVxxEz0p7XIqL6jrguEtF65xRQuQ0VtK4mMD8UFMIPC2zryJ2Xl1kW0AT9TVe9lG0FVfxVQVak3Yt7k9Ij32hYzoQz38tF1NX%2BFOgoa7nJ92ksbx%2Ba2SYE3mAUgdQ3VKhZV4kzk8Y%2Bci3wJ3zvKX3pHTGeOIigKhjWp5ZuMEyGRWVM4Gsk2T3VJ6W6tzAdc8jxIKIk2UL%2BvfV7ik6Fc38%2Bx5Sgii517XCwP51HEVzi3TuDNBiKW%2BBLACzMT%2BRTUXeHvT6VLo1zqaMMFXij7fJkXBdFT9jZcyKJrWZWdAK9vofcrjFr%2FrIMkSj0ElFuQ2KjEAJ3hV2v5AbY2s02R4t5wlpLrQosC8Svg%2Fp3hJnSV%2BPUJJMeoxBqdozqk2esIGJwc1m4md4swc6bX1%2BPaUEu7pDKG4ge6zX1QMHiK38yuec%2BITcf2GPJoO%2BdDhZTNJ4WuXqR0zvX%2FLzzKRL4myvh1clF8TdjURnx3wzXNVsjmLHjTpzYM0Vx9hDmlqchmeXkbaClrsrmv8kxK1WU0LGO837wgQx4nxTVva8hsLA2ZsUgDKZZJVxvGMOR1qKJjmaCwj4FsY%2B714IoXsEW%2B5o52q8QNQEMHpZdydDZjpTHNmDTBkAnEFIc9ridD17Xa7aVHbm89kWTgB1sFWP9eQmF1E5ySO%2BSeksPNkv%2BcHwJwqyQ6rdjMVJa6pK7o17J1jhUqExLAI10dv27LufNN2pFiDmLYqAIe8m9cUaLbOjdqDWpi7f%2B6eLMV1JJ0RisYZw1VeM4OqdNgI54lf%2BkJqIIHO7daptPmdpuH1ngB4Tr1A1MBLyCQmb3FsCdqjACXhXoUeZOM6CZUMn%2FLgpiRHXMGBxLD2oVOx3r%2FDgN%2B0phPPNAVDB8vOoJhkAcuGhxXu1686a8ER%2FXiJN8RJjG82hePwHPNBlaJg8u0s7o6TA1aPP8tA%2Bc0BFrpVZ2fU%2BHdM1XhbL5gk8aC%2BcpRXmNkpahxrGgkxSWbO7oG3x%2BpjrkY%2BNqsPiUh7F92YW7uhRaoBZR4HFAfygXF1xwcFMMoYN9%2Buxgs2CzdlhfaCZaxLb1xXVv5u%2BHfHG%2Bx3Y3yLyKKYoNdz5MeYBGm%2FtmSos6sA5kgsHwHykmziqQ699TfZgSzI9aMS0GWRNc5ZTb2EVns1Lr%2FFcVP5G2Fd32C0w%2Bf5auIH44wq66W2onghuiw6bczmmIAiW5KjpdkBgSd1NPLmXqjgsGMc2WBb4osy%2F1H6Z5xPC1O39x8l1Cm7DliAjYbJN1YpovPEXtT1UNwlQYDqyunUdwPnd2EMUrfcxRsxmPXXgKvsRn8IRxEOsRzuBjChDvdQJtDC3wDmSnMi26H13jpB2lWERV7XSYC8UOgOGmOk4o0jZca9RM0I7z%2Fskt%2Fo7nJOWE0lmaW889zdBw6DkGm5G8pB0IjUKamNSjH4byJQAamNbWbOd0S54vEbJGjd7qr%2BQpY0VM9d7KMxhPtODTAq9Bozm92ZaHzf5IsKpUDW7NVTZk3EKk8QT%2Bj2H8EY%2Fdx%2B9P4LmNkHVP3D4VG7Qd5R1kK00cOenuWPAEKTz%2BmyVFEbsCsZT0us%2BEFljp41TQyz80p9xWiGFozv3y0fwDtf0%2F%2BNHT9rxzIFDgRalpFXk0PlcbcQGj07h7IbbAFycWnL8s5AlZXGkrSiYj%2BX1xG6vRJCQ7TdRYWnpp6afFYWCRtxwySPpDmF6v9FYsk2RlzPsA0J7HxeMIrWBRNkqP%2BRTw4zQcGUPwBP1rNDFQBaGs5jrVUIXIsT67%2FomSQPUFjV3LJ6rJ%2Bc9F42PWAGSi3Zmv9DgdkobrR1fiTtlJ%2FRsgf023iJJFupk%2FfOr9Abz1LVvimXivgNBXSltdUIdqYdSUCEZW%2BLnzWCzQEEaWvYGh1hIyZpMsFx%2F6FridMBg5YtXtkUX8wF4%2BDC14WqZK672Qd15yZwq3NCkBXpJ2TvN9Z7CEeZcG%2F%2BjcTtoGdVTZh8m9mdRi54cGfafuCB69Sgeh0vFRKVLoeN9BvrK%2FZafjt47rjBL4AILQi81li04SYxbwa0ZLRGFaY5DDXdVjQcPvueXb1gDaiGNvVk%2FfJ2iyjmjuF1kZEu8uynISQ253cWjQS1EWXKPa8h86wUduMS%2FDUvT4VsQn%2FihHL9vlx12cPmhAd7WZendFfQ23ePuZgVBlFUVFKCwkjZNsZU5lwCFta4rGy%2Byv%2FYmoZeiunL4LP5vQHz%2Bl7Twqq22QWfMM%2Fvp4wb8Ut3R3VTAeaftfMQ5rTDI4hh0u09Yg%2B4oxh3pAyum7DVwoXH3SQ";
        }
    }
}

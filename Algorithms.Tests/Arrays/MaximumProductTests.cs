﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.Arrays
{
    [TestClass]
    public class MaximumProductTests
    {
        [TestMethod]
        [DataRow(new int[] { -10, -3, 5, 6, -2 }, 30)]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void FirstTry(int[] A, int expected)
        {
            var solution = new Algorithms.Arrays.MaximumProduct.MaximumProduct();
            var actual = solution.FirstTry(A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { -10, -3, 5, 6, -2 }, 30)]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void SecondTry(int[] A, int expected)
        {
            var solution = new Algorithms.Arrays.MaximumProduct.MaximumProduct();
            var actual = solution.SecondTry(A);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { -10, -3, 5, 6, -2 }, 30)]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void ThirdTry(int[] A, int expected)
        {
            var solution = new Algorithms.Arrays.MaximumProduct.MaximumProduct();
            var actual = solution.ThirdTry(A);

            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new int[] { -889, -849, -952, 745, -347, -424, -466, 372, 398, -708, 138, -14, 52, 479, -301 }, 846328 };
            yield return new object[] { new int[] { 927, -494, 79, 592, 450, -512, 777, -471, -640, -203, -765, 929, -794, -405, 450, -193, -438, -47, -700, -917, -498, -777, -655, 505, -581, -194, -895, -730, -934, -220, -797, 563, -241, -125, -325, 565, 362, -721, -328, -453, -666, 621, 687, -52, -582, -353, -672, -223, 947, 485 }, 879763 };
            yield return new object[] { new int[] { -424, -967, -248, 395, -804, 703, -840, 573, 173, -356, -617, 507, -537, 580, -407, -329, 169, 330, 919, 885, 445, -718, -720, 752, 749, -120, -465, 397, 87, 772, -522, 328, -678, -420, -796, -831, -189, 363, -321, -28, 404, 788, 106, -972, -836, -174, 157, -893, -646, 746, 477, -3, -143, -938, -960, -707, 752, -1, 646, 315, 167, -237, -514, 401, -835, 55, 184, 883, 375, -577, 860, 805, -349, -53, -520, 657, 175, -748, 588, -78, 723, -572, 42, 340, -706, 481, -530, -740, -460, 910, -584, 811, 717, 363, 804, -359, 301, 705, 863, 108 }, 939924 }; 
            yield return new object[] { new int[] { 642, 274, -268, 930, 885, 672, -655, 910, 581, -618, 117, 500, 411, -276, 592, -261, 720, 145, 106, -317, -415, -76, 342, 464, -994, -951, -912, 288, 142, 838, -645, 470, -612, -521, 280, -552, 695, 111, 455, -378, 135, -441, -322, -843, -208, -84, -601, -8, 770, 65, -79, -845, -402, 179, -477, -283, 932, 267, 924, 835, 583, 57, -232, 743, -973, 647, 111, -68, 444, 143, 44, -392, 690, -516, 548, -975, -754, 184, -329, 90, 650, 95, 517, -923, -83, -801, -129, 209, 955, -438, -484, -572, 187, 619, 38, -922, 791, -66, -870, 145, 804, 466, 548, -373, -979, -687, -535, -886, 631, -502, -530, -253, -405, -167, -815, -513, 540, -310, -174, 827, -224, 902, -24, -119, -373, -384, 420, -929, 445, 470, -767, 311, 53, 526, 286, -817, 547, -110, -944, -396, 734, -243, 578, 457, -908, 768, 832, -647, 433, -449, -463, 100, -892, -697, -631, 901, -510, -334, 999, 404, -108, -606, -332, -840, -736, 158, 694, 69, 547, -998, -61, -350, -366, -779, -908, -982, -676, 519, -211, -142, -217, 67, -363, -106, -68, 132, 202, -251, 157, 384, 693, -119, -110, -349, 712, 340, -912, 417, 192, -67, -926, -238, -195, 431, 611, 887, -534, 887, -789, -650, 577, -30, 876, 140, -379, 824, 756, 774, 228, 131, 956, -56, 912, -837, -691, -943, 759, 983, -491, -248, 930, -94, -674, 856, -216, -979, -739, 206, 283, 44, -334, 315, -462, -194, 806, -278, 5, 749, -970, 887, 583, -686, -811, -939, -24, 130, -150, -358, 122, 553, -872, -517, 377, 459, -581, -330, -356, -981, -644, -401, 563, -450, -509, -817, -535, -360, -595, 105, -644, 587, 52, -991, 952, -378, 168, 616, -283, -735, -121, 654, 171, 618, -916, 729, -84, -817, 938, 79, -613, 135, -923, -15, 393, 430, -677, 32, 823, -995, 596, -664, -276, 744, -714, 534, -500, -882, -470, -245, -710, -197, 953, -621, 140, -298, 428, 944, -534, -239, 266, -719, -299, 326, -282, 220, 509, -933, -384, -478, -702, -865, 793, -288, -332, -458, -71, 426, 332, -451, 229, -202, 653, 183, -212, 583, 182, 697, 844, -310, -998, -622, -435, 61, -262, 314, 635, 397, 26, 66, -975, -568, 501, -992, -544, -846, 10, 240, 710, -403, 772, -998, -388, 917, 532, -532, -372, 518, -463, 135, -963, 811, -778, 925, -480, 919, 569, -269, 973, 354, -93, 531, -600, -734, -477, -204, 296, 644, -274, -366, -427, 941, 987, 247, -82, 999, 765, -352, 529, -731, -315, -884, -140, 891, 28, -787, -790, 576, 487, -464, -416, -722, 267, -644, 689, -760, 601, -654, 393, -264, 172, -17, -209, 903, -439, -904, 824, -25, 7, -480, -846, -79, 202, 704, -332, -209, -329, -491, 237, -690, -414, 720, -844, -810, -951, -706, -326, 630, 558, -323, -603, 419, 254, -207, 97, 701, 324, -43, 329, -68, -612, 234, -432, -33, -618, 663, 76, 563, 687, -102, 569, 92, 108, 83, -850, 451, -174, -399, 853, -733, 421, -806 }, 998001 };
            yield return new object[] { new int[] { 417, -671, -878, -266, 667, -591, -394, -33, 466, 714, 179, -695, 922, 351, 151, 189, 807, -614, 217, 111, 943, -341, 108, 305, -690, -829, -358, 646, -126, -277, 103, 62, 510, -806, 817, -761, -155, 647, 996, -333, -44, -280, 432, 855, 912, -197, 160, -201, -700, 637, -207, 467, 49, -691, -750, -243, 221, -184, -576, 495, 766, -40, -908, -258, -390, -883, -206, 728, 533, -88, -656, -840, -610, -450, -846, 223, 227, 253, 392, 506, 10, 843, 346, 237, 930, 635, -988, 200, 943, 60, 17, -972, 222, -500, -99, 996, -373, -311, 244, 795, -992, 432, 265, 387, 293, -368, 77, -502, -845, 27, 529, 968, 424, -82, -515, 922, 614, -145, -189, -25, -896, 593, 784, -528, 894, -685, -63, 890, 648, -843, -405, -463, -991, 597, 497, 577, -422, 958, 943, 297, -442, 514, 45, -84, 530, 49, -396, -696, -986, -21, -618, 772, 877, -732, 690, -585, 648, -208, 492, -22, 694, 187, -151, 997, -569, -9, 958, 826, 420, -93, 344, 655, -88, 514, -583, -410, -452, -132, -58, -155, 711, -367, 875, -331, 775, -177, -340, 740, 907, 82, 929, 785, -535, -35, 602, 370, -336, 48, -515, -462, 90, -223, -116, 107, 634, -274, -141, -637, 851, 99, 866, -220, 850, -353, 266, 61, 312, -820, -778, 607, -669, -782, 919, -663, -22, 559, 190, 946, 911, 46, 926, 499, -617, -597, 754, -67, 748, -232, 34, 48, 964, -704, 888, -193, 216, 149, 934, 817, 698, -459, -942, -516, -174, -123, -793, -128, -142, -453, -872, -925, 536, -88, -548, -195, 173, -634, -603, 447, -107, -668, 312, -457, 145, 173, 643, -965, -671, 111, 121, 828, 624, 372, -753, 369, -13, 442, -327, 505, -804, -118, -925, 201, -361, -42, 511, 51, 844, 83, 634, -151, -248, -513, -76, 366, 228, 514, 338, 652, 234, -829, -458, 747, 425, -701, -549, -836, -335, 82, 818, 730, 692, -109, 250, -989, -743, -889, 904, -814, 662, -408, -809, 246, 476, -728, 76, 137, -552, -119, -859, 472, -897, 21, -730, -976, -660, -673, 775, -661, -493, 347, -614, -239, 264, 903, 156, 860, 236, -88, 108, 117, 610, 152, 990, -358, 980, 295, -730, 153, 223, 314, 715, 783, -59, -655, 627, -329, -379, 225, 671, 929, -665, 565, 678, -686, -794, 429, 981, 572, 115, 216, 900, 535, 772, 23, 861, -49, 31, 628, -956, 44, -944, -378, 116, 193, 631, -398, 820, -82, -724, -516, 239, -990, 241, 179, -218, -955, 473, 675, -564, -450, 313, -302, -963, -993, 413, -821, -990, 917, -516, -325, 639, -8, 181, -374, 872, 713, -552, -515, -318, 603, 609, 63, 296, -369, 976, 890, -706, -407, -759, 816, 477, 356, 192, 493, 731, 358, -416, 109, 780, 452, -408, 902, -566, 600, -155, -754, -172, -386, 306, 69, 596, -12, -8, -168, -60, -750, 401, 406, -970, 523, 885, 416, 676, -333, 198, -717, 800, 688, -105, -487, 128, 339, -295, 230, 11, 707, -372, 695, 786, 730, 61, 679, 286, 171, -781, -511, -636, -641, -448, 481, 956, 177, 78, -744, 566, 175, -774, 767, -598, -439, -555, 140, 719, -208, 940, -744, -718, 761, 821, 233, 621, 706, 620, -701, -539, -795, -870, -496, -553, -292, 919, 441, 136, 414, -443, 951, -740, -552, 663, 835, 481, -139, 293, 224, 284, 921, 959, -506, 231, 962, -793, -398, -463, 318, 859, -750, 556, -221, 795, 361, 45, 721, 319, 693, -358, 3, -996, -695, -765, 989, 996, 834, -903, 985, 752, -240, -587, -604, 14, -460, -754, 635, 273, -516, -499, 316, -96, 817, 555, -694, -606, 481, -347, -698, -210, 759, 541, 599, -419, -719, 917, 653, -742, 241, 966, -628, -495, -449, 566, 98, 836, 160, 764, 254, 114, 409, -552, -166, 192, 325, -901, -814, -250, 928, 595, -486, 180, 794, 195, 992, 219, -186, 814, -267, -377, -408, 377, -969, -482, -872, -189, -648, -750, -544, -531, 233, 717, 398, 188, 381, 310, -293, -593, 256, -819, 730, -97, -671, 646, 451, 191, -290, 356, 573, 879, 22, 346, 30, -369, -478, -968, -583, -684, 63, -486, 747, 936, -707, 459, -639, -203, 782, -394, 814, -319, -489, -594, -442, -448, -108, 689, 47, -615, 66, -64, -899, -4, -324, -423, 446, 887, -314, -233, -335, 348, -107, -610, 343, -259, -567, 794, -391, -130, 284, -346, 409, -897, 542, -108, 367, -385, -213, -522, 738, -167, -15, -969, 249, -874, -587, -249, 259, 716, -988, -526, -889, 14, 941, -535, 787, -879, 63, 816, -882, 98, 79, -824, 100, -588, 526, 997, 453, 784, 210, -169, 99, -792, 29, 832, -637, -139, 141, 216, -672, 682, -465, -108, -142, -190, -457, -605, -838, 76, 104, 246, 552, -29, -641, -361, 753, -192, -69, -163, -400, -585, 297, 474, -494, 180, 374, 902, 985, -892, -898, -75, -20, 846, 487, -564, -437, -813, 317, -711, 869, 131, 834, -623, -320, 963, 278, -872, 849, -611, -922, 554, 930, -697, -384, 913, -615, 61, -614, 677, 436, -360, -590, -947, -26, -822, -734, 705, 484, 923, -924, 566, 490, -359, -32, 468, -420, -80, -207, -458, 902, 245, -947, 595, -970, -453, -5, -324, 230, 574, -950, 501, 800, 640, -147, 228, -279, 781, 402, -498, 697, 573, -356, 925, -688, -488, -936, 288, 335, 147, 332, 465, -733, 843, 775, -810, -413, -186, -977, -573, 182, 589, -525, 909, 872, -426, 765, 850, 788, 739, -253, -201, 517, -710, -155, -671, -399, -873, 282, 518, -518, 706, 341, -918, -759, -415, 233, 957, 864, -338, -359, 906, 758, -25, 319, -893, 98, -266, -947, 738, -254, -787, 499, 595, -600, -467, 947, 977, -2, 446, 588, -541, 531, -495, 944, 475, -752, -608, 668, 286, 340, 808, 985, 126, 98, -159, 41, -459, -29, -263, 230, 867, -926, 544, -229, -732, -793, 746, 682, 708, -363, 256, -41, -582, 73, -819, -626, 252, 31, 843, 859, -295, 66, -234, -603, -62, -772, -627, -504, 558, 491, 406, 6, -740, -785, 721, -615 }, 994009 };
            yield return new object[] { new int[] { 733, 179, 611, 841, -164, 182, 166, -126, 756, 568, 626, -836, -301, -17, -469 }, 635796 };
            yield return new object[] { new int[] { 100, 432, -627, 96, 189, 232, -289, 317, -737, -650, -211, -844, -68, -171, 737, 456, 293, 439, 948, -170, 694, -327, 884, -535, 414, -647, 559, 800, -506, -955, 801, -663, -172, -973, -656, -664, -646, 651, 636, -58, 21, 862, 348, 491, -954, 26, -766, -955, -981, -888 }, 954513 };
            yield return new object[] { new int[] { -667, -276, -249, -848, -163, -573, 548, 908, 682, -164, 672, -89, -178, -783, -452, -548, 327, -96, -515, 400, 101, 641, 803, 6, 809, 831, 324, -607, -582, -612, -881, 514, 781, -618, 712, 76, 586, -324, 189, 917, -212, -554, 969, -201, 270, -890, 39, 131, -58, 594, 698, 329, 559, -382, 10, -309, -80, 745, -657, 5, 102, 155, 489, 293, -283, -843, 130, -560, -496, 471, -134, -349, 715, -432, -388, -345, 672, 3, 736, 698, -209, -807, 450, -176, -310, -211, 954, 162, 371, 20, -844, 841, -668, -816, -186, 633, -44, -325, -918, 112 }, 924426 };
            yield return new object[] { new int[] { -21, -401, -374, 470, -273, 46, 614, -9, -995, -646, 19, 916, -991, -356, -787, -91, 704, -335, -397, 927, -797, 968, 68, 483, 315, 25, -681, 530, 753, -21, 698, -4, -80, -377, -281, -808, 566, 979, -904, 643, 174, -38, 156, 17, -999, -761, 831, 688, 970, 904, 928, -709, -929, -845, -91, 11, 530, 143, -845, 702, -273, -917, 237, 26, -345, -977, -5, 385, 924, -979, 343, 725, -432, -41, -248, 240, -189, -949, 482, 76, 193, -369, 560, 849, 51, 407, -76, -235, 714, 708, -339, -577, 824, -606, -84, 91, 725, -870, -639, 978, 243, -554, 763, 949, -439, -798, 723, 112, 402, 669, -801, 479, 660, 79, -491, -905, -478, 388, 975, 248, 98, -770, 670, -784, 359, -80, 901, -826, -957, 661, 514, -319, 690, 504, 832, -254, -132, 611, 287, -152, 684, 812, 363, -955, 508, 182, -238, -255, 884, -180, -432, -664, -846, 112, -121, 13, -224, 546, -411, 641, -699, 549, 69, 741, -846, 518, 788, -844, 246, 762, 227, -89, -900, 126, 564, 286, -133, 624, -292, -824, -843, 155, -711, 222, 92, 178, -474, -423, -376, -181, 970, 321, 21, 646, -454, -865, -257, 621, 891, 990, 394, -394, 498, -879, 593, 657, -765, 27, 548, 593, -855, 151, -162, -587, 484, 145, 259, 847, -352, -25, -9, 211, 531, -574, 792, 905, 889, -546, -420, 428, -458, 245, 733, -282, -218, 551, 656, -833, 628, 434, -58, 498, 28, 31, -327, -182, -517, -392, -838, 400, -125, -104, -28, -85, -2, -818, 74, 72, -672, 687, 768, 781, -553, -881, 50, -100, 418, -881, 631, 932, 489, 92, -782, 214, -967, 492, -818, -500, 753, -26, 421, 280, -708, 180, -447, 646, -727, -183, 719, -401, -524, -416, 838, 941, 666, 160, 51, -92, 980, 773, 399, -637, -23, -771, 911, 783, -323, 758, -118, 506, 999, -426, 319, 354, -735, -512, 489, 267, 566, 403, -373, -399, -600, 31, 456, -96, 253, -724, 547, -128, -560, 274, -481, 979, 574, 58, -698, -938, 268, -230, -32, -486, 935, -787, -401, 902, 265, -516, 675, 178, 671, 784, 342, -423, 145, -202, 963, 946, -228, 7, -471, -599, -790, -991, 65, -275, -946, 339, 780, 207, -815, 426, 998, -204, -566, -888, -335, -813, -569, 554, 638, -231, -399, -631, 201, -344, 931, 942, -167, -225, 94, -644, 290, -739, -760, -433, -696, 925, 148, 873, 847, 926, -296, -532, -7, -755, 785, -455, -858, 33, -868, 775, 514, 218, 368, 760, 799, 840, -192, -592, -207, -888, -495, 4, -888, 828, -864, 737, -444, 867, 808, -261, 39, -443, 707, 712, -935, -867, 376, -45, -129, 386, 800, 800, -358, 318, -158, -929, -107, -520, -233, -537, 117, -261, 79, 735, 420, 699, -645, 164, -891, -952, 989, -726, 224, 393, -264, -44, 511, 655, 694, 666, -536, 852, 537, 407, -689, -296, -639, -206, -14, -936, -156, -925, 99, 345, 622, -701, 478, 972, -709, -635, 777, -788, -154, -178, 396, 525, -425, 249 }, 997002 };
            yield return new object[] { new int[] { -419, 885, -440, 237, -215, 100, 999, 265, 202, 672, 423, -284, 337, 560, -822, -956, 204, 913, 175, 879, 771, -563, 478, 539, 364, 328, 888, -749, 5, -286, -990, -214, -872, 112, -788, 101, 504, 606, 290, 998, 345, -644, 97, 805, -452, 575, 28, -784, -967, -199, 618, 483, -651, -304, 478, -856, -594, 21, 873, 457, 212, 747, -741, -513, 661, -363, -413, -775, 348, 76, -460, 597, -377, 177, -467, 414, 339, 673, -10, 788, -700, 672, -782, -796, 96, -473, -564, 432, 633, -933, -306, -517, 733, 832, -214, 598, -904, -391, -856, 911, -12, -198, -132, -44, -739, -979, -141, 172, -838, -937, -196, -267, -970, -916, 156, 540, 529, -945, 391, 134, -800, 154, -409, 280, -618, -943, 863, -210, -610, -65, 317, -270, 528, 78, -200, 497, -197, 261, 942, 74, 667, 263, 270, 569, 263, 961, -548, 649, -324, 246, -931, -959, 218, 9, 710, 833, -789, 587, -426, -797, -842, -932, -219, 226, -254, -926, 204, -49, 283, 659, -264, -732, -888, -684, 466, -64, 883, 21, -983, -580, 605, -787, -886, 144, -134, 276, 511, -481, 367, -34, 286, 216, -314, 739, -84, 598, -518, -956, -177, 188, -243, 500, -635, 17, -490, 800, 928, -98, 542, -226, 950, 189, 569, -846, -402, 944, 954, 637, -640, 470, -437, -315, 583, -683, -628, 519, 581, -627, 400, 868, -546, 839, -802, -171, 663, -896, 847, 97, -366, 65, 347, -391, -24, -407, 16, -903, 647, -469, 140, -29, 644, -156, 683, 353, -375, -929, 916, -952, -356, -10, -782, 555, 501, 674, -681, -890, -9, -261, -510, -506, -904, -144, 2, 294, -878, 953, 708, -10, 301, -725, 872, 49, 233, -572, -777, 609, -845, -156, -796, 591, -813, 799, -548, 644, -154, 792, 107, 301, -726, -95, 106, -93, -959, -355, -125, -213, 842, -611, 230, -329, -637, -74, -253, -631, 117, 169, -679, 73, 450, -291, 954, -854, -465, -101, -694, -703, -596, 358, -553, -670, -154, -593, -284, -605, 168, -35, 8, -413, 553, 436, 767, 766, 613, 533, 228, 261, 52, -917, -474, 677, 470, -967, 850, 564, -49, -41, -629, 142, -661, -422, -617, -517, 941, -100, 824, 955, -790, -649, 200, -848, -840, 734, 520, -986, -58, -812, -467, 2, 670, 45, 244, -680, -168, -230, -140, -188, -443, 151, 444, -791, -407, 866, -753, -26, 53, 283, 824, -288, 708, 272, 51, -300, -118, -626, 517, 735, -487, 836, -378, -238, -575, 369, 471, 294, 333, -938, 651, 171, -960, 12, 398, 58, -93, -10, 558, -707, 486, -455, -40, 658, -636, 820, 294, -603, 994, -457, 437, -542, 252, 124, -701, -280, -471, -319, 783, 224, -606, -47, 641, -10, 632, -348, -328, -304, 874, 992, 793, 891, -185, 223, -751, 967, -125, -37, -602, -395, -925, 74, 300, -211, -376, 193, 919, -84, -288, -323, -471, -775, 207, -666, 898, -468, -96, 970, -975, 711, 148, -403, -477, -998, -251, 545, 642, -971, -125, -669, 845, 565, -717, 178, 148, 320, 653, -149, -634, -562, -267, 756, 983, 196, 462, 568, -316, -520, 324, 716, 63, -95, -62, -314, 457, 477, -450, 297, -961, 78, 550, 889, -959, -620, -169, -36, 942, -972, 186, -422, -121, -948, 603, 587, -22, 391, -386, 326, -461, 181, -139, 162, -296, 158, 268, -60, -373, 596, 720, 671, -231, -645, -188, 287, -112, -157, 715, 602, -636, -503, 625, -344, 294, -254, -163, 11, 301, 351, 708, -935, -137, 224, -242, -143, -783, -612, 184, -118, 112, 891, -663, -655, -693, 515, 808, -477, 239, -684, -302, -866, 676, 11, -39, -959, 555, -795, 868, 958, -679, -743, 639, 276, 888, 655, -193, 545, 597, 954, 69, -500, 658, -168, -510, -527, -840, 280, -652, 778, -62, -686, 771, -16, -348, 573, -612, 851, -737, -284, 302, -988, -481, 226, -439, -146, -748, 61, -544, -348, -293, -738, -75, 285, 246, -802, -524, -156, -480, -512, 881, -725, 857, -911, 20, -993, -515, -346, -377, -685, 266, -44, 282, -120, -348, 57, 980, -568, -729, 635, -779, 99, -177, 695, 71, -325, 388, -515, 738, -547, 96, 544, 331, 774, -165, 26, -845, -571, -795, -446, -631, 597, -563, -859, 386, 751, -20, -955, -367, -811, -783, -957, -428, -116, -734, -219, 452, -839, 18, -655, -381, 999, -85, -831, 218, 721, 624, 507, -955, 625, -99, 551, -774, 717, 266, -377, -339, -318, -691, 320, 694, 342, 852, 549, -764, 53, -28, -554, 507, -947, 574, 993, 411, 860, 935, -631, -318, -733, -78, 664, -874, 473, 999, 8, 287, -334, 816, -145, 617, 643, -881, -230, 852, 698, -350, 276, -853, 366, 933, -835, -251, 178, 999, 991, -950, -93, -861, -635, 782, -103, 940, -606, 759, -356, 193, -779, 343, -156, -738, 569, 236, -884, -172, 864, 933, -196, -859, 713, 210, -341, -779, 316, -667, -243, -85, -52, 473, -992, -43, -621, -473, 451, 73, -280, 702, 725, 10, 208, -496, -572, 933, 303, 104, -637, -72, -367, -651, -865, -942, 246, -234, -575, 155, 123, -325, -376, -940, 1, 729, -755, -253, 334, 886, 882, 42, 785, 42, -892, -839, -792, 793, -67, 209, -219, -275, -82, -789, 970, 828, -718, -402, 338, 949, 711, 612, -899, -705, 950, -956, 77, 665, -991, 478, -742, 681, -402, 416, 221, 321, 143, 590, -760, 973, 850, 452, 833, 216, -627, -603, 757, -587, -910, 172, 447, 646, 408, 384, -825, -731, -59, 489, 92, -936, 83, -458, 784, 454, -50, 100, -873, 501, -10, -351, -315, -309, -643, 365, -901, -742, 779, -116, 922, 553, -714, -336, 574, -164, -969, -388, -728, 213, 240, -49, -621, 653, -503, -824, -110, 307, 667, -621, -734, 273, -731, -744, 422, 441, -514, -245, 288, -957, 285, 916, -510, -944, 567, 538, 777, -582, -32, -53, 422, -663, -173, -86, -740, -962, -731, 32, -807, -820, -525, -208, -409, 400, -382, -352, 284, -970, 241, -867, -651, 276, 323, -771, 928, 324, -539, -677, -915, -41, -601, -529, -661, -280, -44 }, 998001 };
            yield return new object[] { new int[] { 91, -353, 85, -928, -142, 540, 603, -560, 223, -95, 507, -236, 824, -966, -151 }, 896448 }; 
            yield return new object[] { new int[] { -513, 519, -1, 977, -842, -157, -997, -672, 699, -578, 456, 475, 481, -349, -769, -257, 421, 119, 603, 811, -236, 740, -914, 931, 263, 765, 45, -864, 937, 830, 906, -503, -883, -39, -765, 299, -149, -259, 654, 85, 88, -682, 386, 650, 402, -936, -878, 788, -8, -839 }, 933192 };
            yield return new object[] { new int[] { -915, 645, -779, -778, -915, -254, 432, 68, -286, -607, 798, 867, -609, 868, -484, -42, 358, -481, -584, -68, 892, -320, 464, -483, -277, -555, -647, -564, -471, 199, 642, 256, 143, 775, 745, -740, -725, 895, -124, 488, 866, 783, -973, 260, 287, 220, 926, 517, 134, -557, -294, 602, 372, -940, -731, 404, -819, 704, 499, 639, -607, -5, -461, 515, -250, -458, -277, -385, -877, -745, -317, 463, 642, -73, 65, -891, -347, -797, 229, 502, -482, -165, 301, -915, -508, -960, 883, 83, 506, -660, -922, -429, -605, 237, 95, -130, 244, -489, -490, -255 }, 934080 };
            yield return new object[] { new int[] { -503, 311, 394, -122, 760, 243, 960, -556, -6, -841, -250, 977, -526, 996, 120, 557, 694, -547, 22, -290, -342, 639, 108, 782, -823, -889, 67, -595, 832, -806, -135, -859, 693, -516, 5, 207, 441, -577, -675, 248, -920, 438, -911, 346, 589, -900, -903, -601, -883, 538, 176, -210, 489, 799, -914, -143, -797, 611, -299, 648, -824, 554, -388, -201, 294, -391, -716, 990, -9, 913, -885, 271, -872, 773, -370, 219, 550, 761, -808, -924, -986, -333, -712, -706, 17, -926, -348, 893, -603, -853, 3, 829, 721, -324, 72, -475, -174, 289, -948, -20, 816, -894, 408, -797, 422, 905, -338, 715, 169, -134, 307, -559, 418, -375, 634, 508, 266, -683, 781, 220, 956, -609, 593, -157, -91, -715, 549, 452, -299, -895, -607, -740, 709, 212, -741, 907, 259, -916, -129, 112, 412, -63, -277, 530, -161, -439, -589, 96, 41, 564, 258, -492, 507, -169, 24, 424, -487, -436, 294, 137, -644, 209, 14, 64, -527, 47, -268, -794, -635, 726, -752, 181, 446, -331, 807, 19, 667, -938, -996, -653, 874, -547, -590, 137, -154, 885, -248, -123, -813, -165, 393, -305, -210, 734, -244, -798, 922, 658, 56, 791, 829, -796, -269, 314, 315, -924, 62, -162, 23, -996, 756, -550, -441, -54, 262, 903, -202, 876, -782, -412, -705, 854, -982, 530, -667, 553, -609, 711, 913, 605, 96, -992, 5, -788, -482, 669, 722, 96, 821, -231, -178, 913, 853, -817, 78, -57, -864, 843, -529, -147, 403, -954, 440, -532, 496, 974, -815, 200, -19, 762, 685, 350, -75, 418, -93, 747, 444, -654, -572, 593, -819, 702, -946, 449, 765, -619, -999, 835, -549, 389, 417, -453, 239, 60, -799, 50, -432, -463, -284, -457, 483, -479, -886, -941, 84, 472, -12, -565, 275, 330, 498, 789, 415, -122, -329, 701, 991, 991, -297, 115, 973, -650, -252, 591, -655, 137, -890, 865, 217, 857, 179, -93, 630, 885, -891, 659, 587, 995, -636, -708, 392, 566, -441, 121, 891, 627, 132, -639, -612, -500, 59, -424, 833, 600, -431, 133, 772, -477, 714, 946, 361, 123, 217, 418, -850, -410, -842, 530, -231, 12, -887, 995, 626, -590, 722, -593, 790, 627, 699, -283, -995, 749, 476, -284, -203, -398, 73, -970, 315, -24, 887, 64, -720, -582, -70, -732, -652, 141, -30, 301, 469, 601, 592, 376, -613, 63, -50, 423, 877, -838, 342, -856, -177, -3, 941, 612, 646, -499, -380, 548, 516, -873, -785, 792, 124, 48, 715, 208, 479, 454, -941, -351, -344, -602, 247, -597, -844, -900, -671, 734, 652, 650, -848, 152, 634, 742, -759, 282, -524, 318, -378, 846, -479, 422, 785, 341, 386, 799, -749, 339, 347, 742, 943, -577, -897, -308, 487, -575, 750, 538, 456, 545, -828, -115, 896, 865, 975, 62, -842, 381, -194, -567, -269, -839, -168, -788, -872, 234, -387, 906, 16, -643, 849, -10, -614, 910, 707, 729, 49, -59, -745, 816, 532, -62, 862, 76, 674, 635, 526, 919 }, 995004 };
            yield return new object[] { new int[] { 366, -677, 641, -130, -468, -86, 10, 781, 591, 890, -436, -747, 812, 844, -479, 98, 696, 181, -501, 985, -842, -755, -987, 216, 126, -10, -100, 792, -701, 755, -463, -507, 708, -307, -461, -308, -284, -22, -543, 471, -101, 925, -862, 158, -623, -999, -996, 688, -583, -237, 379, -508, 135, 540, 760, 120, -690, -576, 743, 542, -986, 218, 482, 835, 353, -930, -455, 118, 304, 828, -618, -283, -276, 27, 86, -768, -893, -145, -161, 124, -14, 212, 375, 536, -624, -956, 357, -833, -68, 419, -618, -709, 235, -85, 457, 681, -557, -698, 805, -694, 456, -115, -616, -412, -620, -339, 768, -892, -546, 527, 13, 455, 584, -381, -444, -199, 842, 945, 459, 308, -287, -623, -815, 885, 446, -910, 482, 809, 569, 404, 789, 804, 49, -468, 668, -900, -173, -213, 156, 714, -724, 249, 713, 404, -595, -73, -293, -385, -641, -344, 838, -503, -157, -503, 593, 78, -300, -502, 141, -711, 179, 959, -462, 49, 738, 208, -595, 51, -49, -545, 974, 55, -211, 744, 31, 463, -336, -220, 479, -481, 383, -134, 449, -87, 566, 292, -39, -448, -61, -411, 399, -672, 645, -134, -465, -684, -290, -337, 666, 197, -479, 655, 664, 903, -319, -217, 707, 99, 465, -871, -586, 919, 19, -379, -94, -688, -491, 625, 483, -555, -754, 852, -888, -638, 55, 645, 409, 923, 208, -285, -247, -1000, 113, -719, 998, 727, 201, 546, -769, -217, 584, 862, 87, -191, -826, 480, 309, 23, 960, -777, 807, 85, 180, 220, -50, -332, 543, 302, -153, 36, 373, 784, 890, -251, 376, -586, -194, -263, -377, 178, 110, -37, 393, -301, -139, -616, -235, 302, -813, 575, -665, -615, 962, -15, -93, 668, -181, 892, 330, 329, -816, 899, -302, 194, 410, 800, 971, -663, 433, 760, -326, -429, -600, -218, 112, -156, 691, -519, -641, -434, 903, -760, 115, 271, -299, -13, 821, -95, 842, 708, 594, -87, 407, 294, -6, 211, -736, -801, 289, 61, -587, -573, 869, -574, -99, 764, 985, 180, 872, -937, 977, -662, 533, -236, 425, 943, -217, 426, -507, -578, 978, 66, -505, 724, -835, 760, 164, 105, 787, 901, -421, 491, 191, 298, -847, 476, -629, -312, -630, -63, 1, -359, 32, 778, 731, 256, 379, -358, 868, 50, -573, -163, 705, -134, 83, 346, 931, -856, -739, 140, -401, -121, 392, 970, 484, -515, 146, -765, -389, 949, 572, -905, 56, 556, 421, 336, -967, -283, 993, -91, -619, -479, 237, -263, 474, 741, 785, -675, -785, -194, 544, -774, -573, 229, -663, -879, 249, 61, -706, 245, -891, 144, -969, 918, 478, -669, 780, -851, 445, 746, 313, 214, -850, 351, -241, -923, 642, -345, -504, 742, -301, -179, -981, 805, -595, 345, 668, 827, 218, 299, -913, -29, -577, -252, -200, 236, -510, 318, 258, 142, 961, 636, -121, -532, 493, -671, -925, 76, -531, -741, -521, -406, -435, -449, -454, 287, 125, -774, 513, -868, -337, 953, -70, -855, 658, -659, -209, 402, -449, 522, 587, -677, 396, 353, 781, 63, 941, 550, -688, -925, 270, -408, 357, -41, -180, 493, -594, 871, -798, 512, -889, -736, 805, 126, -521, -993, -295, -266, -190, 151, 538, -327, -475, -53, -329, -844, 197, 211, -230, 482, 345, 574, 914, 437, -138, -929, -404, 971, 325, -835, 934, -81, 200, 38, 411, 323, -483, -731, -126, 773, -643, 207, -260, 160, -463, -404, -933, -590, -713, -337, -705, 194, 101, -281, -834, -463, -650, -632, -736, -592, 411, -266, 408, -356, 216, -382, 473, 486, 535, 348, 638, -72, -663, -4, 125, -862, -167, -247, -101, -735, -996, -815, 683, -339, 869, -260, 818, -520, -128, -126, -28, -852, -995, -535, -638, 622, 798, -904, 943, 919, 123, -420, -126, -62, 25, 367, -144, -896, 594, -972, 703, 596, 469, 998, -596, 225, 51, -253, -226, -524, -201, -8, -386, -339, -624, 489, -78, 871, -366, 502, -661, -263, -190, -21, 141, 423, 310, -256, 636, -498, 883, 714, -114, -157, 170, 375, -321, -994, -939, 136, -429, 51, 321, 466, 120, -869, 966, -787, -438, 535, -556, -16, 469, -909, 688, -34, -214, -510, -143, -20, 914, -694, 111, -728, -408, 85, -894, 770, 491, 0, -190, -84, 809, 498, -70, 288, 416, 343, 858, 10, 457, 97, -818, -900, -943, -102, -756, -206, 155, -796, -411, -811, 149, 81, 221, -735, 940, 48, -127, -965, -975, -805, -278, 561, -275, 528, 175, 971, 160, -600, 549, 442, -369, 846, 523, -183, -877, 10, -785, 694, -160, 311, -385, 286, -590, -380, 766, -272, -723, -335, 347, -633, -531, 823, -15, 261, -625, -380, 374, -472, 723, -727, 634, -246, -346, 146, 558, 302, 557, -597, -859, -71, -167, 179, 194, -287, 580, 435, 151, -895, 761, -554, 693, -505, 52, 181, -27, -193, -139, -738, -559, 503, 636, 686, 970, -433, 677, 861, -369, 264, 62, -537, 171, 873, -476, -582, 534, 289, -372, -729, 681, -60, 469, 269, -234, 277, -421, 138, 701, 473, -827, -250, -559, 295, 962, -363, 293, 147, 208, -374, 36, 718, -197, 886, 43, 298, 274, 820, 970, -366, 647, 683, -821, -411, -419, 501, -966, -634, -81, -307, 988, -462, -841, 158, 90, -689, -978, 876, 910, 886, 125, -614, -919, -999, 234, 962, -864, 582, -774, 468, -998, -242, 168, 67, 825, -511, -429, 851, -287, -539, -397, -74, -772, -485, -362, -502, 559, 644, -205, -269, 276, 398, 909, -917, 508, 260, 602, -823, 355, -381, 364, -549, -860, 450, -310, 230, 370, 92, 333, -399, 740, -830, 162, 449, 283, -802, -842, 565, 363, -265, -598, -508, -214, 494, -808, -396, -152, 84, 558, -436, -113, -607, -504, -906, 97, -849, -214, -223, 824, 408, 128, -534, -689, -806, -9, 105, -764, -540, -200, 310, 101, -964, -187, -381, -784, -129, 665, -355, 258, -914, -619, -715, 533, -232, 713, 346, 673, 67, -649, 131, 411, 381, 741, 955, 607, 936, -820, -409, -497, 86, -632, -612, -717, -752, 463, -149, 579, 877, 878, -775 }, 999000 };
        }
    }
}

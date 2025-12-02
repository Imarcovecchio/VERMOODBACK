import { useState } from "react";
import { Menu, X } from "lucide-react";

export default function Navbar() {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const scrollToSection = (id: string) => {
    document.getElementById(id)?.scrollIntoView({ behavior: "smooth" });
    setIsMenuOpen(false);
  };

  return (
    <nav className="fixed top-0 left-0 right-0 z-50 bg-white/95 backdrop-blur-sm border-b border-gray-200">
      <div className="container mx-auto px-4">
        <div className="flex items-center justify-between h-20">

          {/* Logo */}
          <button
            onClick={() => scrollToSection("hero")}
            className="text-2xl font-bold"
          >
            <span className="text-pink-600">VER</span>
            <span className="text-yellow-500">MOOD</span>
          </button>

          {/* Desktop Nav */}
          <div className="hidden md:flex items-center space-x-8">
            <button onClick={() => scrollToSection("que-es")} className="text-gray-700 hover:text-pink-600 font-medium">¿QUÉ ES?</button>
            <button onClick={() => scrollToSection("vermuts")} className="text-gray-700 hover:text-pink-600 font-medium">VERMUTS</button>
            <button onClick={() => scrollToSection("preguntas")} className="text-gray-700 hover:text-pink-600 font-medium">PREGUNTAS</button>
          </div>

          {/* Mobile Button */}
          <button className="md:hidden text-gray-700" onClick={() => setIsMenuOpen(!isMenuOpen)}>
            {isMenuOpen ? <X className="w-6 h-6"/> : <Menu className="w-6 h-6" />}
          </button>
        </div>

        {/* Mobile Menu */}
        {isMenuOpen && (
          <div className="md:hidden py-4 space-y-4 border-t border-gray-200">
            <button onClick={() => scrollToSection("que-es")} className="block w-full text-left py-2">¿QUÉ ES?</button>
            <button onClick={() => scrollToSection("vermuts")} className="block w-full text-left py-2">VERMUTS</button>
            <button onClick={() => scrollToSection("preguntas")} className="block w-full text-left py-2">PREGUNTAS</button>
          </div>
        )}
      </div>
    </nav>
  );
}

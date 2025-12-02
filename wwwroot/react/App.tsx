import Navbar from "./components/navbar";
import Hero from "./components/hero";
import WhatIsVermood from "./components/what-is-vermood";
import VermutsGallery from "./components/vermuts-gallery";
import HowItWorks from "./components/how-it-works";
import WhatsIncluded from "./components/whats-included";
import CTASection from "./components/cta-section";
import SubscriptionForm from "./components/subscription-form";

export default function App() {
  return (
    <>
      <Navbar />
      <div id="hero">
        <Hero />
      </div>
      <div id="que-es">
        <WhatIsVermood />
      </div>
      <div id="vermuts">
        <VermutsGallery />
      </div>
      <div id="preguntas">
        <HowItWorks />
      </div>
      <WhatsIncluded />
      <CTASection />
      <div id="subscription-form">
        <SubscriptionForm />
      </div>
    </>
  );
}
